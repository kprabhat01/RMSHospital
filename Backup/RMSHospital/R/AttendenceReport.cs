using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.A
{
    public partial class AttendenceReport : Form
    {
        public AttendenceReport()
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

        private void AttendenceReport_Load(object sender, EventArgs e)
        {
            frmDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            ToDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select concat(users.ufname,',',users.ulname) as Name,users_atten.attendenceMode as Attendence,users_atten.timedata as DateTime,users_atten.username as MarkedBy from users,users_atten where users.id = users_atten.userid and date(users_atten.timedata) between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", detail.con))
                {
                    DataTable dt = new DataTable();
                    detail.con.Open();
                    da.Fill(dt);
                    detail.con.Close();
                    dataGridView1.DataSource = dt;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
