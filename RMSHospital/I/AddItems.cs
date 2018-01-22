using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.I
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;

        }
        TreeNode parentNode = null;

        protected void getParentMenu()
        {
            try
            {
                Itemlist.Nodes.Clear();
                DataTable dt = Classes.Inventory.listcat;
                foreach (DataRow dr in dt.Rows)
                {
                    parentNode = Itemlist.Nodes.Add(dr["catname"].ToString());
                    chidmenu(Convert.ToInt32(dr["id"].ToString()), parentNode);

                }
                Itemlist.ExpandAll();

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);

            }
        }
        private void chidmenu(int parentid, TreeNode parentNode)
        {
            string menuname;
            DataTable dt = Classes.Items.Itemslist;
            DataRow[] drrow = dt.Select("procat=" + parentid);
            //storemenu.DefaultView.RowFilter = "menugroup=" + parentid + "";
            TreeNode chidnode;
            foreach (DataRow dr in drrow)
            {
                if (parentNode == null)
                {
                    menuname = dr["Productname"].ToString() + "(" + dr["procode"].ToString() + ")";
                    chidnode = Itemlist.Nodes.Add(menuname);
                }
                else
                {
                    menuname = dr["Productname"].ToString() + "(" + dr["procode"].ToString() + ")";
                    chidnode = parentNode.Nodes.Add(menuname);
                    chidnode.Tag = dr["id"].ToString();
                }

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please enter item name");
                return;
            }
            else
            {

                if (Classes.Items.InsertItems(name.Text, int.Parse(cat.SelectedValue.ToString()), int.Parse(unit.SelectedValue.ToString()), comment.Text))
                {
                    Classes.messagemode.messageget(true, "Inserted Sucessfull");
                    name.Text = "";
                    comment.Text = "";

                    getParentMenu();

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            // Getting units 
            unit.DataSource = Classes.Inventory.listdata;
            unit.ValueMember = "id";
            unit.DisplayMember = "name";
            // Getting Categories
            cat.DataSource = Classes.Inventory.listcat;
            cat.DisplayMember = "catname";
            cat.ValueMember = "id";
            //Loading menu
            getParentMenu();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int itemid = int.Parse(Itemlist.SelectedNode.Tag.ToString());
                if (Classes.messagemode.confirm("Are you sure to remove the selected the item ?"))
                    Classes.Items.DelItems(itemid);
                getParentMenu();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please select the Item and then proceed.");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Units uts = new Units();
            uts.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            cat.ShowDialog();
        }
    }
}
