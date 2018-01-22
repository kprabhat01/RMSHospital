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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        DataTable usertable;

        protected void getUserInformation()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT users.id,CONCAT(users.ufname,',',users.ulname) AS 'UserName',utype.type AS Type,STATUS.name AS STATUS FROM users,STATUS,utype WHERE users.deleteflag=0 AND users.utype = utype.id AND status.id = users.status ORDER BY UserName", detail.con);
                usertable = new DataTable();
                detail.con.Open();
                da.Fill(usertable);
                detail.con.Close();
                gridcontrol();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }
        protected void gridcontrol()
        {
            dataGridView1.DataSource = usertable;
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
            }
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            getUserInformation();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)
            {
                usertable.DefaultView.RowFilter = "UserName like'%" + textBox1.Text + "%'";
                gridcontrol();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                Classes.UserManagement.userid = int.Parse(value);
                Classes.UserManagement.username = name;
                UChangePasscode pass = new UChangePasscode();
                pass.ShowDialog();
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
                string value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();                
                Classes.UserManagement.changeid = int.Parse(value);
                Users usr = new Users();
                usr.ShowDialog();
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
                string value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                if (Classes.messagemode.confirm("Are you sure to delete " + name))
                    Classes.UserManagement.deleteuser(int.Parse(value));
                getUserInformation();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error!! Please select the user and then proceed");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Classes.UserManagement.changeid = 0;
            Users usr = new Users();
            usr.ShowDialog();
        }
    }
}
