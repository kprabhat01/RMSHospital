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

namespace WindowsFormsApplication1.U
{
    public partial class ManageUsers : MetroFramework.Forms.MetroForm
    {
        TreeNode parentNode = null;
        public ManageUsers()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Text = "Manage User Account";
        }



        protected void gridcontrol()
        {
            /* dataGridView1.DataSource = usertable;
             DataGridViewColumn column0 = dataGridView1.Columns[0];
             column0.Visible = false;
             DataGridViewColumn column1 = dataGridView1.Columns[1];
             column1.Width = 250;
             DataGridViewColumn column2 = dataGridView1.Columns[2];
             column2.Width = 100;
             DataGridViewColumn column3 = dataGridView1.Columns[3];
             column3.Width = 100;
             dataGridView1.AllowUserToResizeColumns = false;
             dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
             dataGridView1.AllowUserToAddRows = false;
             foreach (DataGridViewColumn column in dataGridView1.Columns)
             {
                 column.SortMode = DataGridViewColumnSortMode.NotSortable;
             }*/
        }
        void GetUsertree()
        {
            try
            {
                UsrTree.Nodes.Clear();
                UsrTree.ImageList = imageList1;
                foreach (DataRow Dr in UserManagement.UserType.Rows)
                {
                    parentNode = UsrTree.Nodes.Add(Dr["type"].ToString());
                    parentNode.ImageIndex = 0;
                    parentNode.SelectedImageIndex = 0;
                    parentNode.Tag = "T|" + Dr["id"].ToString();
                    TreeNode ChildNode = null;
                    foreach (DataRow UsrDr in loginmodule.UserList.Select("Utype=" + Dr["id"].ToString() + ""))
                    {
                        ChildNode = parentNode.Nodes.Add(UsrDr["ufname"].ToString() + " " + UsrDr["ulname"].ToString());
                        ChildNode.ImageIndex = UsrDr["STATUS"].ToString().ToLower().Equals("0") ? 2 : 1;
                        ChildNode.SelectedImageIndex = UsrDr["STATUS"].ToString().ToLower().Equals("0") ? 2 : 1;
                        ChildNode.Tag = "U|" + UsrDr["id"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            GetUsertree();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*if (textBox1.Text.Length >= 3)
            {
                usertable.DefaultView.RowFilter = "UserName like'%" + textBox1.Text + "%'";
                gridcontrol();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                //string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                //Classes.UserManagement.userid = int.Parse(value);
                //  Classes.UserManagement.username = name;
                //UChangePasscode pass = new UChangePasscode();
                //pass.ShowDialog();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error!! Please select the user and then proceed");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // string value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                // Classes.UserManagement.changeid = int.Parse(value);
                //Users usr = new Users();
                //usr.ShowDialog();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error!! Please select the user and then proceed");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // string value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                //string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                // if (Classes.messagemode.confirm("Are you sure to delete " + name))
                //   Classes.UserManagement.deleteuser(int.Parse(value));
                //getUserInformation();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error!! Please select the user and then proceed");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsrTree.SelectedNode.Tag.ToString().Split('|')[0].ToLower().Equals("u"))
                {
                    ChangePassword PassCode = new ChangePassword(int.Parse(UsrTree.SelectedNode.Tag.ToString().Split('|')[1]), UsrTree.SelectedNode.Text);
                    PnlObject.Text = "Change Password";
                    PnlObject.Controls.Clear();
                    PnlObject.Controls.Add(PassCode);
                    PassCode.Show();
                    //PassCode.sra
                    //U.UChangePasscode Pass = new UChangePasscode(int.Parse(UsrTree.SelectedNode.Tag.ToString().Split('|')[1]), UsrTree.SelectedNode.Text);

                    //Pass.BringToFront();
                    //Pass.ShowDialog();

                    //Pass.Show();
                }
                else
                    messagemode.MetroMessageBox("Please select user to change password", this, false);
            }
            catch (Exception ex)
            {
                messagemode.MetroMessageBox("Please select the user and then proceed.", this, false);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsrTree.SelectedNode.Tag.ToString().Split('|')[0].ToLower().Equals("t"))
                {
                    SecSettings PassCode = new SecSettings(int.Parse(UsrTree.SelectedNode.Tag.ToString().Split('|')[1]), UsrTree.SelectedNode.Text);
                    PnlObject.Text = "Manage Permission";
                    PnlObject.Controls.Clear();
                    PnlObject.Controls.Add(PassCode);
                    PassCode.Show();
                    //PassCode.sra
                    //U.UChangePasscode Pass = new UChangePasscode(int.Parse(UsrTree.SelectedNode.Tag.ToString().Split('|')[1]), UsrTree.SelectedNode.Text);

                    //Pass.BringToFront();
                    //Pass.ShowDialog();

                    //Pass.Show();
                }
                else
                    messagemode.MetroMessageBox("Please select User Type to manage permissions", this, false);
            }
            catch (Exception ex)
            {
                messagemode.MetroMessageBox("Please select the User Type and then proceed.", this, false);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add("+New");
            contextMenuStrip1.Items.Add("Update");
            contextMenuStrip1.Items.Add("Delete");
            contextMenuStrip1.Show(metroButton2, new Point(0, metroButton2.Height));
            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip1_ItemClicked);
        }
        protected void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Text)
                {
                    case "+New":
                        UserManagement.changeid = 0;
                        Users usr = new Users();
                        usr.ShowDialog();
                        break;
                    case "Update":
                        try
                        {
                            if (UsrTree.SelectedNode.Tag.ToString().Split('|')[0].ToLower().Equals("u"))
                            {
                                UserManagement.changeid = int.Parse(UsrTree.SelectedNode.Tag.ToString().Split('|')[1]);
                                Users UsUpdate = new Users();
                                UsUpdate.ShowDialog();
                                loginmodule.GetUser();
                            }
                        }
                        catch (Exception ex)
                        {
                            messagemode.MetroMessageBox("Please select the user and then proceed.", this, false);
                        }
                        break;
                    case "Delete":
                        try
                        {
                            if (UsrTree.SelectedNode.Tag.ToString().Split('|')[0].ToLower().Equals("u"))
                            {
                                UserManagement.changeid = int.Parse(UsrTree.SelectedNode.Tag.ToString().Split('|')[1]);
                                if (messagemode.confirm("Are you sure to delete " + UsrTree.SelectedNode.Text.ToString()))
                                    UserManagement.deleteuser(UserManagement.changeid);
                                loginmodule.GetUser();
                            }
                        }
                        catch (Exception ex)
                        {
                            messagemode.MetroMessageBox("Please select the user and then proceed.", this, false);
                        }
                        break;
                }
                GetUsertree();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
    }
}
