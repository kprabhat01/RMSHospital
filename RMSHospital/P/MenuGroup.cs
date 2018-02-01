using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1.P
{
    public partial class MenuGroup : Form
    {
        public MenuGroup()
        {
            InitializeComponent();
        }
        void GetCategories()
        {
            CmbCatogories.BindDataToComboBox(MenuMaster.MenuGropTitle, "catname", "id");
        }
        void SetGridMenuGroup()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = MenuMaster.menugroup;
                dt = dt.DefaultView.ToTable(true, "Id", "name", "catname");
                GridMenuGroup.DataSource = dt;
                GridMenuGroup.AllowUserToAddRows = false;
                GridMenuGroup.Columns[0].Visible = false;
                GridMenuGroup.Columns[1].Width = 150;
                GridMenuGroup.Columns[1].HeaderText = "Group";
                GridMenuGroup.Columns[2].Width = 150;
                GridMenuGroup.Columns[2].HeaderText = "Category";
                GridMenuGroup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
        private void MenuGroup_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            menumessage();
            GetCategories();
            SetGridMenuGroup();
        }
        private void menumessage()
        {
            /* listBox1.DataSource = Classes.MenuMaster.menugroup;
             listBox1.DisplayMember = "name";
             listBox1.ValueMember = "id";*/

        }
        private void getupdatedvalue()
        {
            try
            {
                Classes.MenuMaster.getmenugroup();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupname.Text.Length == 0 || CmbCatogories.Text == string.Empty)
            {
                Classes.messagemode.messageget(false, "Please enter Menu group Name");
                return;
            }
            else
            {
                try
                {
                    List<pro_catagories> Lst = new List<pro_catagories>();
                    Lst.Add(new pro_catagories
                    {
                        deleteflag = 0,
                        name = groupname.Text,
                        pro_inventory_cat_Id = int.Parse(CmbCatogories.SelectedValue.ToString())
                    });
                    if (Lst.SaveChanges())
                    {
                        MenuMaster.getmenugroup();
                        SetGridMenuGroup();
                    }
                }
                catch (Exception ex)
                {
                    writeme.errorname(ex);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // int gpid;
            try
            {
                //  gpid = int.Parse(listBox1.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the group to delete");
                return;
            }
            try
            {
                if (Classes.messagemode.confirm("Are you sure to delete the group ?"))
                {
                    /* MySqlCommand cmd = new MySqlCommand("update pro_catagories set deleteflag=1 where id=" + gpid + " limit 1", detail.con);
                     detail.con.Open();
                     cmd.ExecuteNonQuery();
                     detail.con.Close();
                     getupdatedvalue();
                     menumessage();*/
                }

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(GridMenuGroup.SelectedRows[0].Cells[0].Value.ToString()) >= 1)
                {
                    List<pro_inventory_cat> lst = new List<pro_inventory_cat>();
                    lst.Add(new pro_inventory_cat
                    {
                        Id = int.Parse(GridMenuGroup.SelectedRows[0].Cells[0].Value.ToString()),
                        deleteflag = 1
                    });
                    if (lst.UpdateChanges())
                    {
                        MenuMaster.getmenugroup();
                        SetGridMenuGroup();
                    }
                }
            }
            catch (Exception ex)
            {
                messagemode.messageget(false, "Please select the group");
            }
        }
    }
}
