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
    public partial class SnapShot : Form
    {
        public SnapShot()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            frmDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ToDate.Text = dateTimePicker2.Value.ToString("MM/dd/yyyy");
        }

        private void SnapShot_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            frmDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            ToDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
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
                        Classes.SnapShot.getOrderDetail(dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                        Classes.SnapShot.getDataTable();
                        sumReport.DataSource = Classes.SnapShot.getDetail;
                        sumReport.AllowUserToAddRows = false;
                        sumReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        sumReport.CellBorderStyle = DataGridViewCellBorderStyle.None;
                        sumReport.Columns[3].DefaultCellStyle.BackColor = Color.Pink;
                        sumReport.Columns[4].DefaultCellStyle.BackColor = Color.Pink;
                        /* MySqlDataAdapter da = new MySqlDataAdapter("SELECT COUNT(id) AS 'Count', SUM(PaidAmu) AS 'TotalAmout' FROM order_detail WHERE status!=4 AND (DATE(openday) BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')", detail.con);
                         DataTable dt = new DataTable();
                         detail.con.Close();
                         da.Fill(dt);
                         detail.con.Close();
                         sumReport.DataSource = dt;
                         sumReport.AllowUserToAddRows = false;
                         DataGridViewColumn column0 = sumReport.Columns[0];
                         column0.Width = 200;
                         DataGridViewColumn column1 = sumReport.Columns[1];
                         column1.Width = 300;
                         sumReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         sumReport.CellBorderStyle = DataGridViewCellBorderStyle.None;*/

                    }
                    catch (Exception ex)
                    {
                        Classes.writeme.errorname(ex);
                        Classes.messagemode.messageget(false, "Error while getting report");
                    }

                }
            }
        }
    }
}
