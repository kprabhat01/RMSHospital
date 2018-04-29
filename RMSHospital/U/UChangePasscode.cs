using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.U
{
    public partial class UChangePasscode : MetroFramework.Forms.MetroForm
    {
        private int Userid { get; set; }

        public UChangePasscode(int IUserId, string IUsername)
        {
            InitializeComponent();
            this.Text = IUsername;
            
            
        }

        private void UChangePasscode_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btnChangePasscode_Click(object sender, EventArgs e)
        {
            if (passcode.Text.Length == 0 || repasscode.Text.Length == 0)
            {
                Classes.messagemode.MetroMessageBox("Please enter Password and Confirm Password.", this, false);
                return;
            }
            else if (passcode.Text != repasscode.Text)
            {
                Classes.messagemode.MetroMessageBox("Password doesn't match with confirm password.", this, false);
                return;
            }
            else
            {

                if (Classes.UserManagement.changepassword(Userid, passcode.Text))
                {
                    Classes.messagemode.MetroMessageBox("Password has been changed Successfully.",this,true);
                    this.Close();
                    return;
                }
                else
                {
                    Classes.messagemode.messageget(false, "Error while password change.Please contact administrator");
                    this.Close();
                    return;
                }
            }
        }
    }
}
