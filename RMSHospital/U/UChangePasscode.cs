using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.U
{
    public partial class UChangePasscode : Form
    {
        
        public UChangePasscode()
        {
            InitializeComponent();
        }
        

        private void UChangePasscode_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Text = Classes.UserManagement.username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (passcode.Text.Length == 0 || repasscode.Text.Length == 0)
            {
                Classes.messagemode.messageget(false,"Please enter Password and Confirm Password.");
                return;
            }
            else if (passcode.Text != repasscode.Text)
            {
                Classes.messagemode.messageget(false, "Password doesn't match with confirm password.");
                return;
            }
            else {

                if (Classes.UserManagement.changepassword(Classes.UserManagement.userid, passcode.Text))
                {
                    Classes.messagemode.messageget(true, "Password has been changed Successfully.");
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
