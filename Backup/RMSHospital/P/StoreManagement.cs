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
    public partial class StoreManagement : Form
    {

        public StoreManagement()
        {
            InitializeComponent();
        }

        private void shortinfo(string info)
        {
            DataTable dt = Classes.MenuMaster.storegroup;
            dt.DefaultView.RowFilter = "Store like'%" + textBox1.Text + "%'";
            dataGridView1.DataSource = dt;
            managegrid();
        }
        private void getstoreinfo()
        {
            dataGridView1.DataSource = Classes.MenuMaster.storegroup;
            managegrid();
        }
        private void managegrid()
        {
            try
            {
                DataGridViewColumn column0 = dataGridView1.Columns[0];
                column0.Visible = false;
                DataGridViewColumn column1 = dataGridView1.Columns[1];
                column1.Width = 200;
                DataGridViewColumn column2 = dataGridView1.Columns[2];
                column2.Width = 100;
                DataGridViewColumn column3 = dataGridView1.Columns[3];
                column3.Width = 100;
                DataGridViewColumn column4 = dataGridView1.Columns[4];
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
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, ex.Message);
                return;
            }
        }
        private void StoreManagement_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            getstoreinfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classes.MenuMaster.storeid = 0;
            NewStore store = new NewStore();
            store.ShowDialog();
            getstoreinfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)
                shortinfo(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                int data = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

                if (Classes.messagemode.confirm("Are you sure to delete the store ?"))
                {
                    MySqlCommand cmd = new MySqlCommand("Update stores set deleteflag=1  where id=" + data + "", detail.con);
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    Classes.MenuMaster.getStoreInfo();
                    getstoreinfo();
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.MenuMaster.storeid = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                Classes.MenuMaster.storename = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                Classes.MenuMaster.printname = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                Classes.MenuMaster.phone1 = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                Classes.MenuMaster.phone2 = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                Classes.MenuMaster.address = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                NewStore store = new NewStore();
                store.ShowDialog();
                getstoreinfo();

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
    }
}
