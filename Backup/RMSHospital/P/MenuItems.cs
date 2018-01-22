using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace WindowsFormsApplication1.P
{
    public partial class MenuItems : Form
    {
        public MenuItems()
        {
            InitializeComponent();
        }

        int activestatus;
        string foodstat;
        float sum;
        DataTable storemenu;
        TreeNode parentNode = null;
        int selectmenuid;

        private void getMenugroup()
        {
            try
            {
                groupname.DataSource = Classes.MenuMaster.menugroup;
                groupname.ValueMember = "id";
                groupname.DisplayMember = "Name";

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Menu Group is blank.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mnubut.Text = menuname.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int argb = Int32.Parse(colorcode.Text, NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);
                mnubut.BackColor = clr;
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Cannot select the color code.");
                colorcode.Text = "";
                return;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void chidmenu(int parentid, TreeNode parentNode)
        {
            string menuname;
            DataRow[] drrow = storemenu.Select("menugroup=" + parentid);
            //storemenu.DefaultView.RowFilter = "menugroup=" + parentid + "";
            TreeNode chidnode;
            foreach (DataRow dr in drrow)
            {
                if (parentNode == null)
                {
                    menuname = dr["menuname"].ToString() + "(" + dr["SumAmu"].ToString() + ")";
                    chidnode = menulist.Nodes.Add(menuname);

                }
                else
                {
                    menuname = dr["menuname"].ToString() + "(" + dr["SumAmu"].ToString() + ")";
                    chidnode = parentNode.Nodes.Add(menuname);
                    chidnode.Tag = dr["id"].ToString();
                }

            }

        }
        private void getPatantmenu()
        {
            try
            {
                menulist.Nodes.Clear();
                DataTable dt = Classes.MenuMaster.menugroup;
                

                foreach (DataRow dr in dt.Rows)
                {
                    parentNode = menulist.Nodes.Add(dr["name"].ToString());
                    chidmenu(Convert.ToInt32(dr["id"].ToString()), parentNode);

                }
                menulist.ExpandAll();

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while loading menu.");

            }
        }

        private void MenuFilter()
        {
            try
            {
                storemenu = Classes.MenuMaster.menulist;
                storemenu.DefaultView.RowFilter = "storeid=" + Classes.Stores.SelectedStoreid + "";
                storemenu = storemenu.DefaultView.ToTable(); 
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }


        private void MenuItems_Load(object sender, EventArgs e)
        {
            SelectStore st = new SelectStore();
            st.ShowDialog();
            if (Classes.Stores.SelectedStoreid >= 1)
            {
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Text = Classes.Stores.Selectedstorename;
                getMenugroup();                

                //loading menulist for the store.
                MenuFilter();
                //gettting menu from filter
                getPatantmenu();
            }
            else
            {
                Classes.messagemode.messageget(false, "Store is not selected.");
                this.Close();
            }
        }

        private void MenuItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            Classes.Stores.SelectedStoreid = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            foodstat = "V";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            foodstat = "N";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            activestatus = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            activestatus = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dg = new ColorDialog();
            dg.AllowFullOpen = false;
            dg.AnyColor = true;
            dg.SolidColorOnly = false;
            DialogResult rs = dg.ShowDialog();
            if (rs == DialogResult.OK)
            {
                colorcode.Text = dg.Color.Name;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menuname.Text.Length == 0 || Code.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please enter Menu Name and Print Name.");
                return;
            }
            else if (groupname.Text.Length == 0 || colorcode.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Group Name and Color code is blank.");
                return;
            }
            else if (activestatus < 0 || foodstat.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please select the  Status and Food type.");
                return;
            }
            else
            {

                try
                {
                    sum = float.Parse(Bcost.Text) + float.Parse(Tcost.Text);
                }
                catch (Exception ex)
                {
                    Classes.messagemode.messageget(false, "Please enter amount in proper format.");
                    return;
                }
                try
                {
                    if (New.Checked == true)
                    {
                        MySqlCommand cmd = new MySqlCommand("Insert into menu_items(menuname,printname,storeid,menugroup,status,code,orderitem,amount,tax,colorcode,sumAmu) values(?menuname,?printname," + Classes.Stores.SelectedStoreid + "," + groupname.SelectedValue.ToString() + "," + activestatus + ",'" + foodstat + "','" + orderby.Value + "','" + Bcost.Text + "','" + Tcost.Text + "','" + colorcode.Text + "','" + sum + "')", detail.con);
                        cmd.Parameters.Add("?menuname", MySqlDbType.VarChar).Value = menuname.Text;
                        cmd.Parameters.Add("?printname", MySqlDbType.VarChar).Value = Code.Text;
                        detail.con.Open();
                        cmd.ExecuteNonQuery();
                        detail.con.Close();
                        menuname.Text = "";
                        Code.Text = "";
                        Classes.messagemode.messageget(true, "Saved Successfull");    
                    }
                    else if (Update.Checked == true)
                    {
                        MySqlCommand cmd = new MySqlCommand("Update menu_items set menuname=?menuname,printname=?printname,menugroup='"+groupname.SelectedValue.ToString()+"',status='"+activestatus+"',code='"+foodstat+"',orderitem="+orderby.Value+",amount='"+Bcost.Text+"',tax='"+Tcost.Text+"',colorcode='"+colorcode.Text+"',sumAmu='"+sum+"' where id='"+selectmenuid+"'",detail.con);
                        cmd.Parameters.Add("?menuname", MySqlDbType.VarChar).Value = menuname.Text;
                        cmd.Parameters.Add("?printname", MySqlDbType.VarChar).Value = Code.Text;
                        detail.con.Open();
                        cmd.ExecuteNonQuery();
                        detail.con.Close();
                        Classes.messagemode.messageget(true, "Updated Successfull");

                    }
                    
                    Classes.MenuMaster.getItemMenu();
                    MenuFilter();
                    getPatantmenu();
                }
                catch (Exception ex)
                {
                    Classes.writeme.errorname(ex);
                    Classes.messagemode.messageget(false, "Error while saving Information.");

                }

            }
        }
        private void getMenuUpdated(int id)
        {
            try
            {
                DataTable dt = Classes.MenuMaster.menulist;
                dt.DefaultView.RowFilter = "id=" + id + "";
                dt = dt.DefaultView.ToTable();
                menuname.Text = dt.Rows[0][1].ToString();
                Code.Text = dt.Rows[0][2].ToString();
                groupname.SelectedValue = dt.Rows[0][4].ToString();
                colorcode.Text = dt.Rows[0]["colorcode"].ToString();
                orderby.Value = int.Parse(dt.Rows[0]["orderitem"].ToString());
                Tcost.Text = dt.Rows[0]["tax"].ToString();
                Bcost.Text = dt.Rows[0]["amount"].ToString();
                if (dt.Rows[0]["code"].ToString() == "V")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                if (int.Parse(dt.Rows[0]["status"].ToString()) == 0)
                {
                    radioButton4.Checked = true;
                }
                else
                {
                    radioButton3.Checked = true;
                
                }


            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error mention updated");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               // MessageBox.Show(menulist.SelectedNode.Tag.ToString());
                Update.Checked = true;
                selectmenuid = int.Parse(menulist.SelectedNode.Tag.ToString());
                getMenuUpdated(selectmenuid);
            
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false,"Error while getting information");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(menulist.SelectedNode.Tag.ToString());
                if (Classes.messagemode.confirm("Are you confirm to delete the menu"))
                {
                    MySqlCommand cmd = new MySqlCommand("update menu_items set deleteflag=1 where id=" + id + "",detail.con);
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    Classes.MenuMaster.getItemMenu();
                    MenuFilter();
                    getPatantmenu();
                }

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Selected Menu not found");
            }
        }

        private void New_CheckedChanged(object sender, EventArgs e)
        {
            selectmenuid = 0;
            menuname.Text = "";
            Code.Text="";            
            Bcost.Text = "0.00";
            Tcost.Text = "0.00";
        }

        private void Update_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(menulist.SelectedNode.Tag.ToString());
                Classes.ProductMapping.selectedproid = id;
                Classes.ProductMapping.selectedproductname = menulist.SelectedNode.Text;
                I.ProductMapping pro = new I.ProductMapping();
                pro.ShowDialog();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(menulist.SelectedNode.Tag.ToString());
                Classes.ProductMapping.selectedproid = id;
                Classes.ProductMapping.selectedproductname = menulist.SelectedNode.Text;
                I.DependentStock stk = new I.DependentStock();
                stk.ShowDialog();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MenuGroup gp = new MenuGroup();
            gp.ShowDialog();
        }
    }
}
