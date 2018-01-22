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
    public partial class ProductWise : Form
    {
        public ProductWise()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            frmDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ToDate.Text = dateTimePicker2.Value.ToString("MM/dd/yyyy");
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
                        MySqlDataAdapter da = new MySqlDataAdapter("SELECT menu_items.menuname AS MenuName,menu_items.printname AS PrintName,SUM(order_items.qty) AS 'Count',SUM(order_items.oamu) AS Amount FROM order_items,menu_items WHERE order_items.menuid=menu_items.id  AND order_items.orderid IN (SELECT id FROM order_detail WHERE status!=4 and ( DATE(openday) BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')) GROUP BY menu_items.id", detail.con);
                        DataTable dt = new DataTable();
                        detail.con.Close();
                        da.Fill(dt);
                        detail.con.Close();
                        ProductReport.DataSource = dt;
                        ProductReport.AllowUserToAddRows = false;
                        DataGridViewColumn column0 = ProductReport.Columns[0];
                        column0.Width = 200;
                        DataGridViewColumn column1 = ProductReport.Columns[1];
                        column1.Width = 200;
                        DataGridViewColumn column2 = ProductReport.Columns[2];
                        column2.Width = 100;                        
                        DataGridViewColumn column3 = ProductReport.Columns[3];
                        column3.Width = 100;
                        ProductReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        ProductReport.CellBorderStyle = DataGridViewCellBorderStyle.None;

                    }
                    catch (Exception ex)
                    {
                        Classes.writeme.errorname(ex);
                        Classes.messagemode.messageget(false, "Error while getting report");
                    }

                }
            }
        }

        private void ProductWise_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            frmDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            ToDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }
    }
}
