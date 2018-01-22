using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.U
{
    public partial class SecuritySettings : Form
    {
        public SecuritySettings()
        {
            InitializeComponent();
        }

        private void SecuritySettings_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utype utype = new Utype();
            utype.ShowDialog();
            utypename.Text = Classes.UserManagement.SutypeName;
        }

        private void getserverside()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("Select id,menuname from menude where deleteflag=0 and liesin!=0 and id not in(select mid from sec_userprofile where utype=" + Classes.UserManagement.Sutypeid + ")", detail.con);
                DataTable dt = new DataTable();
                detail.con.Open();
                da.Fill(dt);
                detail.con.Close();
                ServerList.DataSource = dt;
                ServerList.ValueMember = "id";
                ServerList.DisplayMember = "menuname";


            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while getting security serversiede");
            }

        }
        private void getUserside()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("Select id,menuname from menude where deleteflag=0 and liesin!=0 and id in(select mid from sec_userprofile where utype=" + Classes.UserManagement.Sutypeid + ")", detail.con);
                DataTable dt = new DataTable();
                detail.con.Open();
                da.Fill(dt);
                detail.con.Close();
                UserSide.DataSource = dt;
                UserSide.ValueMember = "id";
                UserSide.DisplayMember = "menuname";


            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while getting security serversiede");
            }

        }

        private bool GetExhange(Boolean type, int id)
        {
            string query;
            try
            {
                if (type)
                {
                    query = "Insert into sec_userprofile(mid,utype) values(" + id + "," + Classes.UserManagement.Sutypeid + ")";
                }
                else
                {
                    query = "Delete from sec_userprofile where mid=" + id + " and utype=" + Classes.UserManagement.Sutypeid + "";
                }
                MySqlCommand cmd = new MySqlCommand(query, detail.con);
                detail.con.Open();
                cmd.ExecuteNonQuery();
                detail.con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please select the menu and then procceed.");
                return false;
            }

        }

        private void utypename_TextChanged(object sender, EventArgs e)
        {
            try
            {
                getserverside();
                getUserside();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while getting security");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GetExhange(true, int.Parse(ServerList.SelectedValue.ToString())))
            {
                Classes.messagemode.messageget(true, "Access Granter.");
                getserverside();
                getUserside();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetExhange(false, int.Parse(UserSide.SelectedValue.ToString())))
            {
                Classes.messagemode.messageget(true, "Access Taken.");
                getserverside();
                getUserside();
            }
        }
    }
}
