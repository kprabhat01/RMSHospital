using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.A
{
    public partial class VendorAccount : Form
    {
        public static int vendorid;
        public static string VendorName;

        void getVendorAccount(string frmDate, string toDate)
        {
            try
            {
                string query="";
                if (frmDate.Length == 0 || toDate.Length == 0)
                    query = "select * from vendorAccount where vendorid="+vendorid+"";
                else
                    query = "select * from vendorAccount where vendorid=" + vendorid + " and CreateDate between '" + frmDate + "' and '" + toDate + "'";
                DataTable dt = Classes.SqlHelper.ReturnRows(query);
                dt.DefaultView.Sort="CreatedDate desc";
                dt.Columns[2].ColumnName = "TimeStamp";
                dt.Columns[3].ColumnName = "Transaction Comment";
                dt.Columns[4].ColumnName = "Balance";
                dt.Columns[5].ColumnName = "Deposite";
                dt.Columns[6].ColumnName = "Entered By";
                dt.Columns[7].ColumnName = "Pay.Mode";
                dt = dt.DefaultView.ToTable(true, "id", "Transaction Comment", "TimeStamp","Entered By", "Pay.Mode","Deposite","Balance");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 251;
                dataGridView1.Columns[2].Width = 80;                
                dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[5].DefaultCellStyle.BackColor = Color.LightGreen;
                dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[6].DefaultCellStyle.BackColor = Color.LightPink;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
                dataGridView1.AllowUserToAddRows = false;

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        void getPaymentMode()
        {
            try
            {
                DataTable dt = Classes.OrderMode.Payments;
                payMode.DataSource = dt;
                payMode.DisplayMember = "ModeName";
                payMode.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;

            }
        }

        public VendorAccount()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "0.0" && textBox1.Focus() == true)
            {
                textBox1.Text = "";
            }
        }

        private void VendorAccount_Load(object sender, EventArgs e)
        {
            this.Text = VendorName;
            getPaymentMode();
            getVendorAccount("", "");
        }
    }
}
