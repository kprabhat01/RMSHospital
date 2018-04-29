using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;
using System.Threading;
namespace WindowsFormsApplication1
{
    public partial class RMSLogin : MetroFramework.Forms.MetroForm
    {
        public RMSLogin()
        {
            InitializeComponent();
            this.Text = "RSM Login";
            this.TopMost = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void RMSLogin_Load(object sender, EventArgs e)
        {

        }

        private void StatusBar(string Text)
        {
            StsLevel.Text = Text;
            Application.DoEvents();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                messagemode.MetroMessageBox("Username OR Password is empty.", this, false);
            }
            else
            {
                try
                {
                    StatusBar("Verifing Credential...");
                    List<users> Usr = new List<users>();
                    Usr.Add(new users
                    {
                        uname = txtUsername.Text,
                        pwd = enc.Encrypt(txtPassword.Text)
                    });
                    DataTable dt = Usr.ReturnRow();
                    if (dt.Rows.Count >= 1)
                    {
                        if (dt.Rows[0]["ublk"].ToString().Equals(1))
                            messagemode.MetroMessageBox("User Account has been locked.", this, false);
                        else if (dt.Rows[0]["status"].ToString().Equals(1))
                            messagemode.MetroMessageBox("User Status is InActive.", this, false);
                        else
                        {
                            loginmodule.uid = int.Parse(dt.Rows[0]["Id"].ToString());
                            loginmodule.username = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(dt.Rows[0]["ufname"].ToString()) + " " + Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(dt.Rows[0]["ulname"].ToString());
                            loginmodule.utype = int.Parse(dt.Rows[0]["utype"].ToString());
                            StatusBar("Preparing Cache...");
                            UserManagement.getutype();
                            SqlHelper.singltonclass();
                            ItemKeys.getItemKeys();
                            AttendanceMode.getAttandanceMode();
                            Home hm = new Home();
                            hm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        messagemode.MetroMessageBox("Incorrect Username and Password.", this, false);
                    }

                }
                catch (Exception ex)
                {
                    writeme.errorname(ex);
                }
                finally
                {
                    StsLevel.Text = string.Empty;
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButton1.PerformClick();
            }
        }
        
    }
}
