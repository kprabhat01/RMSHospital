using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Cus
{
    public partial class CustomerManagement : Form
    {
        DataTable dt;
        public CustomerManagement()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        private void insertdata()
        {
            try
            {
                dt = Classes.Customer.CustomerData;
                dataGridView1.DataSource = dt;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[4].Width = 250;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Classes.OrderMode.creditCustomeId = 0;
            insertdata();
            if (Classes.Customer.selectid == 1 || Classes.OrderMode.CreditMode == true)
                selectcus.Visible = true;
            else
                selectcus.Visible = false;

            textBox1.Focus();

        }

        private void New_Click(object sender, EventArgs e)
        {
            Classes.OrderMode.creditCustomeId = 0;
            Classes.OrderMode.customerid = 0;
            Classes.Customer.selectedcustid = 0;
            Customer cus = new Customer();
            cus.ShowDialog();
            Classes.Customer.getCustomerdetail();
            insertdata();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
            {
                dt.DefaultView.RowFilter = "Name like '%" + textBox1.Text + "%' OR phone like '%" + textBox1.Text + "%' OR Phone2 like '%" + textBox1.Text + "%'";

                insertdata();

            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Customer.customerid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Customer cus = new Customer();
                cus.ShowDialog();
                Classes.Customer.getCustomerdetail();
                insertdata();
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the customer and then process");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Classes.OrderMode.CreditMode)
                {
                    Classes.Customer.selectid = 0;
                    Classes.OrderMode.creditCustomeId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    Classes.OrderMode.CreditMode = false;
                    this.Close();
                }
                else
                {
                    Classes.Customer.selectid = 0;
                    Classes.Customer.selectedcustid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    Classes.OrderMode.customerid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    Classes.OrderMode.customerinfo = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + ",\n" + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "\n" + dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + "\n" + dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the customer");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dataGridView1.Focus();
            }
            if (e.KeyCode == Keys.F1)
            {
                selectcus.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                textBox1.Focus();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CustomerManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                selectcus.Focus();

            if (e.KeyCode == Keys.F2)
                textBox1.Focus();

            if (e.KeyCode == Keys.F3)
                dataGridView1.Focus();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Classes.Customer.selectedcustid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Classes.Customer.selectedCustomerName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                CustomerAccount act = new CustomerAccount();
                act.ShowDialog();
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the customer and then process");
                return;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int customerid;
            try
            {
                customerid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the customer to delete");
                return;
            }
            try
            {
                if (Classes.messagemode.confirm("Are you sure to delete the customer?"))
                {
                    if (Classes.Customer.AccountClear(customerid))
                    {
                        Classes.Customer.DelCustomer(customerid);
                        Classes.Customer.getCustomerdetail();
                        insertdata();
                    }
                    else
                    {
                        Classes.messagemode.messageget(false, "Balance for the customer is still pending");
                    }
                }

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
    }
}
