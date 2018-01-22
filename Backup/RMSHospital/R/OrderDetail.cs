using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.R
{
    public partial class OrderDetail : Form
    {
        public OrderDetail()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frmDate.Text.Length == 0 || ToDate.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please select Date and then proceed.");
                return;
            }
            else
            {

                if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
                {
                    Classes.messagemode.messageget(false, "From Date Cannot be greater than.");
                    return;
                }
                else
                {
                    try
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("SELECT order_detail.id AS OrderID,stores.storeName AS Store, order_detail.orderdatetime AS DATETIME,order_detail.username AS UserName,case when order_detail.status=1 Then 'Instore' when order_detail.status=2 then 'Parcel' end as OrderType,case when order_detail.orderlive=0 then 'Closed' when order_detail.orderlive=1 then 'Canceled' end as Status,order_detail.PaidAmu AS Amount FROM order_detail,stores,STATUS WHERE status.id = order_detail.status AND stores.id = order_detail.storeid AND DATE(order_detail.openday) BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", detail.con);
                        DataTable dt = new DataTable();
                        detail.con.Close();
                        da.Fill(dt);
                        detail.con.Close();
                        OrderReport.DataSource = dt;
                        OrderReport.AllowUserToAddRows = false;
                        OrderReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        OrderReport.CellBorderStyle = DataGridViewCellBorderStyle.None;
                        /*DataGridViewColumn column0 = OrderReport.Columns[0];
                        column0.Width = 200;
                        DataGridViewColumn column1 = OrderReport.Columns[1];
                        column1.Width = 300;
                        OrderReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        OrderReport.CellBorderStyle = DataGridViewCellBorderStyle.None;*/

                    }
                    catch (Exception ex)
                    {
                        Classes.writeme.errorname(ex);
                        Classes.messagemode.messageget(false, "Error while getting report");
                    }

                }
            }
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            frmDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            ToDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            frmDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ToDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Classes.OrderMode.SelectedOrderId = int.Parse(OrderReport.Rows[OrderReport.CurrentRow.Index].Cells[0].Value.ToString());
                Classes.PrintReport.printbill(Classes.OrderMode.SelectedOrderId);
                ShowInternal inter = new ShowInternal();
                inter.ShowDialog();
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the order");
                Classes.writeme.errorname(ex);
                return;
            }
        }
    }
}
