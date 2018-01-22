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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        void getInsertedData()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("select Comment,Amount from expenses where DayDate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and storeid='" + Classes.Stores.SelectedStoreid + "' order by id desc", detail.con))
                {
                    detail.con.Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    detail.con.Close();
                    if (dt.Rows.Count >= 1)
                        dataGridView1.DataSource = dt;

                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.Columns[0].Width = 250;
                    dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView1.Columns[1].Width = 103;
                    dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    float sum = 0;
                    if (dataGridView1.Rows.Count >= 1)
                    { 
                        for(int i=0; i<dataGridView1.Rows.Count; i++)
                        {
                            sum = sum + float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        }
                        SumValue.Text = string.Format("{0:0.00}", sum);
                    }

                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        private void Expences_Load(object sender, EventArgs e)
        {
            this.Text = "Expenses";
            getInsertedData();
        }

        private void Credit_Click(object sender, EventArgs e)
        {
            decimal amount;
            try
            {
                amount = decimal.Parse(Amu.Text);
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please enter the Amount in proper format.");
                return;
            }
            try
            {
                if (Comment.Text.Length < 1)
                {
                    Classes.messagemode.messageget(false, "Please enter information in proper format.");
                    return;
                }
                else
                {
                    if (Classes.OpenDay.CheckOpenStat(Classes.Stores.SelectedStoreid))
                    {
                        if (Classes.messagemode.confirm("Are you sure to save the information ?"))
                        {
                            MySqlCommand cmd = new MySqlCommand("Insert into expenses(Comment,Amount,dateDetail,username,DayDate,storeid) values(?comment," + amount + ",'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Classes.loginmodule.username + "','" + Classes.OpenDay.day + "','" + Classes.Stores.SelectedStoreid + "')", detail.con);
                            cmd.Parameters.Add("?comment", MySqlDbType.Text).Value = Comment.Text;
                            detail.con.Open();
                            cmd.ExecuteNonQuery();
                            detail.con.Close();
                            Classes.messagemode.messageget(true, "Information saved.");
                            Comment.Text = "";
                            Amu.Text = "0.00";
                            getInsertedData();
                        }
                    }
                    else
                    {
                        Classes.messagemode.messageget(false, "Day is not open.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Error while saving Information.");
                return;
            }
        }
    }
}
