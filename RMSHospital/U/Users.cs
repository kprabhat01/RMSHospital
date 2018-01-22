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
    public partial class Users : Form
    {

        private int status;
        public Users()
        {
            InitializeComponent();
        }
        private void getinformationdetail()
        {
            try
            {
                if (Classes.UserManagement.changeid >= 1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM users where id="+Classes.UserManagement.changeid+" limit 1", detail.con);
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    if (dt.Rows.Count >= 1)
                    {
                        firstname.Text = dt.Rows[0][1].ToString();
                        lastname.Text = dt.Rows[0][2].ToString();
                        login.Text = dt.Rows[0][3].ToString();
                        comboBox1.SelectedValue = dt.Rows[0][5].ToString();
                        if (int.Parse(dt.Rows[0][6].ToString()) == 0)
                            checkBox1.Checked = true;
                        else
                            checkBox1.Checked = false;    
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, ex.Message);
            }
        }
        protected void getUserInfo()
        {
            try
            {
                comboBox1.DataSource = Classes.UserManagement.datata;
                comboBox1.ValueMember = "id";
                comboBox1.DisplayMember = "type";

            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, ex.Message);
            }
        }
        private void chekstat()
        {
            if (checkBox1.Checked)
            {
                status = 0;
            }
            else
            {
                status = 1;
            }
        }

        private void chekpasscode()
        {
            if (Classes.UserManagement.changeid >= 1)
            {
                passcode.Enabled = false;
                repasscode.Enabled = false;
            }
            
        }
        private void Users_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            chekpasscode();
            getUserInfo();
            getinformationdetail();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            chekstat();
            if (firstname.Text.Length == 0 || lastname.Text.Length == 0 || login.Text.Length==0)
            {
                Classes.messagemode.messageget(false, "FirstName or Lastname is blank.");
                return;
            }
            else if (Classes.UserManagement.changeid == 0)
            {
                if (passcode.Text.Length == 0 || repasscode.Text.Length == 0)
                {
                    Classes.messagemode.messageget(false, "Password OR Confirm Password is blank.");
                    return;
                }
                if (passcode.Text != repasscode.Text)
                {
                    Classes.messagemode.messageget(false, "Password doesn't match with confirm password.");
                    return;
                }
                else {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("Insert into users(ufname,ulname,uname,pwd,utype,status) values(?ufname,?ulname,?uname,?pwd," + comboBox1.SelectedValue.ToString() + "," + status + ")",detail.con);
                        cmd.Parameters.Add("?ufname", MySqlDbType.VarChar).Value = firstname.Text;
                        cmd.Parameters.Add("?ulname", MySqlDbType.VarChar).Value = lastname.Text;
                        cmd.Parameters.Add("?pwd", MySqlDbType.VarChar).Value = Classes.enc.Encrypt(passcode.Text);
                        cmd.Parameters.Add("?uname", MySqlDbType.VarChar).Value = login.Text;
                        detail.con.Open();
                        cmd.ExecuteNonQuery();
                        detail.con.Close();
                        Classes.messagemode.messageget(true, "Successfully Inserted.");
                    }
                    catch (Exception ex)
                    {
                        Classes.writeme.errorname(ex);
                        Classes.messagemode.messageget(false, "Error while saving information");
                    }                
                }
            }
            else if (Classes.UserManagement.changeid == 0)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("update users ufname=?ufname,ulname=?ulname,uname=?uname,utype=" + comboBox1.SelectedValue.ToString() + ",status=" + status + " where id=" + Classes.UserManagement.changeid + "",detail.con);
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    Classes.messagemode.messageget(true, "Successfully Updated.");
                }
                catch (Exception ex)
                {
                    Classes.writeme.errorname(ex);
                    Classes.messagemode.messageget(false, "Error while saving information"); 
                }
               
            }
        }
    }
}
