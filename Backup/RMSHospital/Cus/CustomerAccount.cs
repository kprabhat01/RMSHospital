using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.Cus
{

    public partial class CustomerAccount : Form
    {

        decimal amount = 0;
        decimal cr = 0;
        decimal deb = 0;
        decimal due = 0;
        bool paymentcat;
        void getValue()
        {
            try
            {
                cr = 0;
                deb = 0;
                due = 0;
                if (dataGridView1.Rows.Count >= 1)
                {
                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {
                        cr = cr + decimal.Parse((dr.Cells[4].Value.ToString() == string.Empty) ? "0" : dr.Cells[4].Value.ToString());
                        deb = deb + decimal.Parse((dr.Cells[3].Value.ToString() == string.Empty) ? "0" : dr.Cells[3].Value.ToString());

                    }
                    due = cr - deb;
                    credit.Text = cr.ToString();
                    Debit.Text = deb.ToString();
                    Due.Text = due.ToString();
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        void getAccoutInformation()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select Comment as Comment,EventDate as DateTime,username as UserName, PaidAmu as Deposit,CreditAmu as Balance from customers_credit where custid='" + Classes.Customer.selectedcustid + "' order by EventDate", detail.con))
                {
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    dataGridView1.DataSource = dt;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.Columns[0].Width = 203;
                    dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView1.Columns[1].Width = 75;
                    dataGridView1.Columns[2].Width = 75;
                    dataGridView1.Columns[3].Width = 81;
                    dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns[3].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E5E7E9");
                    dataGridView1.Columns[4].Width = 81;
                    dataGridView1.Columns[4].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FDEDEC");
                    dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    getValue();
                }

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        public CustomerAccount()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void CustomerAccount_Load(object sender, EventArgs e)
        {
            this.Text = Classes.Customer.selectedCustomerName;
            getAccoutInformation();
            paycate.Text = "Deposite";
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (paycate.Text.Length == 0)
                {
                    Classes.messagemode.messageget(false, "Please select payment category");
                    return;
                }
                else
                {

                    if (paycate.Text == "Balance")
                        paymentcat = true;
                    else if (paycate.Text == "Deposit")
                        paymentcat = false;
                    amount = Math.Round(decimal.Parse(amu.Text));
                    Classes.OrderMode.billcomment = Comment.Text;
                    Classes.OrderMode.InsertCustomerCredit(paymentcat, Classes.Customer.selectedcustid, amount);
                    getAccoutInformation();
                }

            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please enter amount in properformat");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
