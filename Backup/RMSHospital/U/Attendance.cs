using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.U
{
    public partial class Attendance : Form
    {
        string userId = "";
        StringBuilder query;
        public Attendance()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        void getUsers()
        {
            try
            {
                dataGridView1.DataSource = Classes.AttendanceMode.getUsers();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 220;

                DataGridViewComboBoxColumn comb = new DataGridViewComboBoxColumn();
                comb.DataSource = Classes.AttendanceMode.AttandenceData;
                comb.DisplayMember = "Mode";
                comb.ValueMember = "Mode";
                comb.HeaderText = "Attendance";
                comb.Width = 70;
                /*
                 * 
                 * DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.ValueType = typeof(bool);
                dgvCmb.Name = "Chk";
                 * 
                 * 
                 * */

                dataGridView1.Columns.Add(comb);
                dataGridView1.Columns[2].ReadOnly = false;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //datagridcolum

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            //var chekbox = dataGridView1
            getUsers();
            getCheckedUser();
        }
        void getCheckedUser()
        {
            try
            {
                DataTable dt = Classes.AttendanceMode.getUsersChecked();
                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataGridViewRow drow in dataGridView1.Rows)
                        {
                            if (drow.Cells[0].Value.ToString() == dr["userid"].ToString())
                            {
                                drow.Cells[2].Value = dr["AttendenceMode"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {

            try
            {
                bool checkInfo = true;
                query = new StringBuilder();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string value = (dataGridView1.Rows[i].Cells[2].Value) == null ? "" : dataGridView1.Rows[i].Cells[2].Value.ToString();
                    query.Append("(" + dataGridView1.Rows[i].Cells[0].Value.ToString() + ",'" + value + "','" + Classes.loginmodule.username + "'),");
                    if (value == string.Empty)
                    {
                        checkInfo = false;
                        break;
                    }
                    /*bool chek = bool.Parse(value);
                    if (chek)
                    {
                        userId += dataGridView1.Rows[i].Cells[0].Value.ToString() + ",";
                    }*/
                }
                if (checkInfo)
                {
                    userId = query.ToString();
                    userId = userId.TrimEnd(',');
                    if (Classes.AttendanceMode.InsertVaue(userId))
                    {
                        Classes.messagemode.messageget(true, "Successfully stored");
                        return;
                    }
                }
                else
                {
                    Classes.messagemode.messageget(false, "One or more attendence is still not marked.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }


        }
    }
}
