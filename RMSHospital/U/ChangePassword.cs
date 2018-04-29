using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1.U
{
    public partial class ChangePassword : MetroFramework.Controls.MetroUserControl
    {

        private int UserID { get; set; }
        public ChangePassword(int IUserId, string Iusername)
        {
            UserID = IUserId;
            InitializeComponent();
            txtUserName.Text = Iusername;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length <= 0)
                messagemode.messageget(false, "Please enter password");
            else if (txtPassword.Text != txtConfirmPassword.Text)
                messagemode.messageget(false, "Password doesn't match with confirm password");
            else
            {
                List<users> Usr = new List<users>();
                Usr.Add(new users
                {
                    pwd = enc.Encrypt(txtPassword.Text),
                    Id = UserID
                });
                bool UserPassword = Usr.UpdateChanges();
                messagemode.messageget(UserPassword, UserPassword ? "Password has been updated." : "Error While updating password.");
            }

        }
    }
}
