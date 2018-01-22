using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.I
{
    public partial class DependentStock : Form
    {
        public DependentStock()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        DataTable ListMenu;
        private void getStockInfo()
        {
            try
            {
                Dictionary<int,string> List = new Dictionary<int,string>();
                Classes.Inventory.GetStockInfo(Classes.Stores.SelectedStoreid);
                DataTable dt = Classes.Inventory.stocklist;
                int i=0;
                foreach (DataRow dr in dt.Rows)
                { 
                    
                    string getmenuname = dr["productname"].ToString()+" "+ dr["name"].ToString();
                    int getproid = int.Parse( dr["id"].ToString());
                    ListMenu.Rows.Add(getproid, getmenuname);                   
                }
                dependentList.DataSource = ListMenu;
                dependentList.ValueMember = "id";
                dependentList.DisplayMember = "itemname";
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }

        protected void getMenufield()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select * from menu_items_dependency where menuid="+Classes.ProductMapping.selectedproid+"",detail.con))
                {
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    if (dt.Rows.Count >= 1)
                    {
                        dependentList.SelectedValue = dt.Rows[0]["menuMapId"].ToString();
                        qty.Text = dt.Rows[0]["qty"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }
        private void DependentStock_Load(object sender, EventArgs e)
        {
            MenuName.Text = Classes.ProductMapping.selectedproductname;
            getStockInfo();
            ListMenu = new DataTable();
            ListMenu.Columns.Add("id", typeof(int));
            ListMenu.Columns.Add("itemname", typeof(string));
            getStockInfo();
            getMenufield();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Classes.messagemode.confirm("Are you sure save the mapping ?"))
            {
                try
                {
                    float.Parse(qty.Text);
                    int.Parse(dependentList.SelectedValue.ToString());
                }
                catch (Exception ex)
                {
                    Classes.messagemode.messageget(false, "Please enter the data in proper format");
                }
                try
                {
                    if (Classes.Inventory.InsertDependent(int.Parse(dependentList.SelectedValue.ToString()), Classes.ProductMapping.selectedproid, float.Parse(qty.Text)))
                    {
                        getMenufield();
                    }

                }
                catch (Exception ex)
                {
                    Classes.writeme.errorname(ex);
                    return;
                }
            }
        }
    }
}
