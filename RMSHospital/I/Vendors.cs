using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.I
{
    public partial class Vendors : Form
    {
        DataTable dt;
        public bool selectmode;
       

        public Vendors()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            dt = Classes.vendors.vendordt;
            getData();
            if (Classes.vendors.selectflag == 0)
                button2.Visible = false;
            else
                button2.Visible = true;
            

        }
        protected void getData()
        {
            try
            {

                dataGridView1.DataSource = dt;
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                DataGridViewColumn column = dataGridView1.Columns[0];
                column.Visible = false;
                DataGridViewColumn column1 = dataGridView1.Columns[1];
                column1.Width = 190;
                DataGridViewColumn column2 = dataGridView1.Columns[2];
                column2.Visible = false;
                DataGridViewColumn column6 = dataGridView1.Columns[6];
                column6.Visible = false;
                DataGridViewColumn column5 = dataGridView1.Columns[5];
                column5.Visible = false;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (int.Parse(dataGridView1.Rows[1].Cells[5].Value.ToString()) == 0)
                    {
                        dataGridView1.Rows[1].Cells[1].Style.BackColor = Color.LightGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Classes.vendors.vendorflag = 0;
            AddVendor ven = new AddVendor();
            ven.ShowDialog();
            dt = Classes.vendors.vendordt;
            getData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.vendors.selectedVendorid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Classes.vendors.selectvedorname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select Vendor and then proceed.");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "Vendorname like '%" + src.Text + "%'";
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Classes.messagemode.confirm("Are you sure to delete the vendor"))
                    Classes.vendors.deletevendor(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                dt = Classes.vendors.vendordt;
                getData();
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select Vendor and then proceed.");
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int vendorid;
            try
            {
                vendorid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please select the vendor.");
                return;

            }
            try
            {
                Classes.vendors.vendorflag = vendorid;
                AddVendor ven = new AddVendor();
                ven.ShowDialog();
                dt = Classes.vendors.vendordt;
                getData();

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                A.VendorAccount.vendorid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                A.VendorAccount.VendorName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                A.VendorAccount account = new A.VendorAccount();
                account.ShowDialog();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please select the vendor and then proceed.");
                return;
            }
        }
    }
}
