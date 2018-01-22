using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.P
{
    public partial class MenuGroup : Form
    {
        public MenuGroup()
        {
            InitializeComponent();
        }

        private void MenuGroup_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;          
            menumessage();
       }
        private void menumessage()
        {
            listBox1.DataSource = Classes.MenuMaster.menugroup;
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "id";

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
            if (groupname.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please enter Menu group Name");
                return;
            }
            else {
                try
                {

                       MySqlCommand cmd = new MySqlCommand("Insert into pro_catagories(name) values(?name)", detail.con);
                        cmd.Parameters.Add("?name", MySqlDbType.VarChar).Value = groupname.Text;
                        detail.con.Open();
                        cmd.ExecuteNonQuery();
                        detail.con.Close();                    
                        getupdatedvalue();
                        menumessage();
                        groupname.Text = "";
                        return;
                    

                }
                catch (Exception ex)
                {

                    Classes.writeme.errorname(ex);
                    return;
                }
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gpid;
            try
            {
                gpid= int.Parse(listBox1.SelectedValue.ToString());
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
                    MySqlCommand cmd = new MySqlCommand("update pro_catagories set deleteflag=1 where id=" + gpid + " limit 1", detail.con);
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    getupdatedvalue();
                    menumessage();
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
