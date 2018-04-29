using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1.A
{
    public partial class AttendenceReport : MetroFramework.Forms.MetroForm
    {
        public AttendenceReport()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //frmDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // ToDate.Text = dateTimePicker2.Value.ToString("MM/dd/yyyy");
        }

        private void AttendenceReport_Load(object sender, EventArgs e)
        {
            //frmDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            //ToDate.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            // FilterPanel.Controls.Add()

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {



                /*  using (MySqlDataAdapter da = new MySqlDataAdapter("select concat(users.ufname,',',users.ulname) as Name,users_atten.attendenceMode as Attendence,users_atten.timedata as DateTime,users_atten.username as MarkedBy from users,users_atten where users.id = users_atten.userid and date(users_atten.timedata) between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", detail.con))
                  {
                      DataTable dt = new DataTable();
                      detail.con.Open();
                      da.Fill(dt);
                      detail.con.Close();
                      dataGridView1.DataSource = dt;
                      dataGridView1.AllowUserToAddRows = false;
                      dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                  }*/
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmDate.Value.Date > ToDate.Value.Date)
                    Classes.messagemode.MetroMessageBox("From Date Can't be greater than to Date", this, false);
                else
                {
                    dataGridView1.DataSource = Classes.SqlHelper.ReturnRows("select concat(users.ufname,',',users.ulname) as Name,users_atten.attendenceMode as Attendence,users_atten.timedata as DateTime,users_atten.username as MarkedBy from users,users_atten where users.id = users_atten.userid and date(users_atten.timedata) between '" + frmDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "'");
                    dataGridView1.AllowUserToAddRows = false;
                    if (dataGridView1.Rows.Count != 0)
                    {
                        dataGridView1.Columns[0].Width = 150;
                        dataGridView1.Columns[3].Width = 150;
                    }
                    else {
                        Classes.messagemode.MetroMessageBox("No Data Found.", this, false);
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.messagemode.MetroMessageBox("Error while getting report", this, false);
                Classes.writeme.errorname(ex);
                return;
            }
        }
    }
}
