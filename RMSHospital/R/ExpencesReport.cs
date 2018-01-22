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
    public partial class ExpencesReport : Form
    {
        public ExpencesReport()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            frmDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ToDate.Text = dateTimePicker2.Value.ToString("MM/dd/yyyy");
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (frmDate.Text.Length == 0 || ToDate.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please enter Date");
                return;
            }
            else if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                Classes.messagemode.messageget(false, "From Date Cannot be greater than To Date");
                return;
            }
            else
            {

                try
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter("select Comment,datedetail as Date,username as UserName,Amount as Amount from expenses where DayDate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", detail.con))
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
                        dataGridView1.Columns[0].Width = 245;
                        dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dataGridView1.Columns[1].Width = 83;
                        dataGridView1.Columns[2].Width = 83;
                        dataGridView1.Columns[3].Width = 81;
                        dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView1.Columns[4].Width = 81;
                        dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                       
                    }
                }
                catch (Exception ex)
                {
                    Classes.writeme.errorname(ex);
                    return;
                }
            }

        }

        private void ExpencesReport_Load(object sender, EventArgs e)
        {
            this.Text = "Expense Report";
            frmDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            ToDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }
    }
}
