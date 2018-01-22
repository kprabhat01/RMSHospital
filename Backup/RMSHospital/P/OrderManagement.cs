using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1.P
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        DataTable dt;
        private void OrderManagement_Load(object sender, EventArgs e)
        {
            dt = Classes.OrderMode.getOrderSummary(Classes.OpenDay.day);
            getDataGrid(dt);
        }
        void getDataGrid(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[4].DefaultCellStyle.BackColor = Color.Green;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.White;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                int orderid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Classes.PrintReport.printbill(orderid);
                ViewOrder order = new ViewOrder();
                order.ShowDialog();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please select the row and then proceed.");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
            {
                try
                {
                    DataTable getOrderformat = dt;
                    getOrderformat.DefaultView.RowFilter = "  Customer like'" + textBox1.Text + "%' or phone like'" + textBox1.Text + "%' or UserName like '" + textBox1.Text + "%'";
                    getOrderformat = getOrderformat.DefaultView.ToTable();
                    getDataGrid(getOrderformat);
                }
                catch (Exception ex)
                { 
                    // do nothing
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Classes.messagemode.confirm("Are you sure to cancel the order ?"))
                {
                    int orderid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    if (Classes.OrderMode.cancelorder(orderid))
                    {
                        Classes.messagemode.messageget(true, "Order has been canceled successfully.");
                        getDataGrid(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please select the row and then proceed.");
                return;
            }
        }
    }
}
