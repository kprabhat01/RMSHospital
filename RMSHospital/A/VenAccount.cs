using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1.A
{
    public partial class VenAccount : Form
    {
        public VenAccount()
        {
            InitializeComponent();
        }
        void Lableformat()
        {
            label1.Text = string.Empty;
            label1.AutoSize = false;
            label1.Height = 2;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Width = FrmHelper.FrmWidth;

            label3.Text = string.Empty;
            label3.AutoSize = false;
            label3.Height = 2;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Width = FrmHelper.FrmWidth;


            //lblTotal.Text = "12393824.00";
            //dataGrid
        }
        void getVendor()
        {
            try
            {
                comboBox1.DataSource = vendors.vendordt;
                comboBox1.DisplayMember = "VendorName";
                comboBox1.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
        void GetConsolidate()
        {
            try
            {
                DataTable dt = SqlHelper.ReturnRows("select * from inven_inwards_vendoraccount where VendorId=" + int.Parse(comboBox1.SelectedValue.ToString()) + " and datetime between '" + frmDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' order by Id");
                lblCredit.Text = decimal.Parse(dt.Rows[0]["OpeningBalance"].ToString()).ToString("N2");
                lblDebit.Text = decimal.Parse(dt.Compute("sum(DebitAmount)", "DebitAmount is not null").ToString().Length == 0 ? "0.00" : dt.Compute("sum(DebitAmount)", "DebitAmount is not null").ToString()).ToString("N2");
                lblClosing.Text = decimal.Parse(dt.Rows[dt.Rows.Count - 1]["ClosingBalance"].ToString()).ToString("N2");
                dt = new DataTable();
                detail.con.Open();
                dt = vendors.GetOpeningBalance(int.Parse(comboBox1.SelectedValue.ToString()), detail.con);
                detail.con.Close();
                lblTotal.Text = decimal.Parse(dt.Rows[0][0].ToString()).ToString("N2");
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }

        }

        private void VenAccount_Load(object sender, EventArgs e)
        {
            getVendor();
            Lableformat();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmDate.Value.Date > toDate.Value.Date)
                {
                    messagemode.MetroMessageBox("From Date Can't be greater than To Date.", this, false);
                    return;
                }
                else
                {
                    if (int.Parse(comboBox1.SelectedValue.ToString()) >= 1)
                    {
                        dataGrid.DataSource = vendors.vendor_CurrentAccount(int.Parse(comboBox1.SelectedValue.ToString()), frmDate.Value.ToString("yyyy-MM-dd"), toDate.Value.ToString("yyyy-MM-dd"));
                        if (dataGrid.Rows.Count >= 1)
                        {
                            dataGrid.Columns[0].Visible = false;
                            dataGrid.Columns[1].Visible = false;
                            dataGrid.AllowUserToAddRows = false;
                            dataGrid.Width = FrmHelper.FrmWidth;
                            dataGrid.GridColor = Color.DodgerBlue;
                            dataGrid.Columns[2].Width = 150;
                            dataGrid.Columns[3].Width = 150;
                            dataGrid.Columns[3].HeaderText = "User Name";
                            dataGrid.Columns[4].Width = FrmHelper.FrmWidth - (150 + 150 + 100 + 100 + 60);
                            dataGrid.Columns[5].Width = 100;
                            dataGrid.Columns[5].HeaderText = "Debit";
                            dataGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dataGrid.Columns[6].Width = 100;
                            dataGrid.Columns[6].HeaderText = "Credit";
                            dataGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            GetConsolidate();
                        }
                        else
                            messagemode.MetroMessageBox("No Data Found.", this, false);
                    }
                }
            }
            catch (Exception ex)
            {
                messagemode.MetroMessageBox("Error in filteration. Please contact administrator", this, false);
                dataGrid.DataSource = null;
                lblClosing.Text = "0.00";
                lblCredit.Text = "0.00";
                lblTotal.Text = "0.00";
                lblDebit.Text = "0.00";

            }
        }

        private void VenAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(comboBox1.SelectedValue.ToString()) >= 1)
                {
                    AcEntry Entry = new AcEntry(int.Parse(comboBox1.SelectedValue.ToString()), comboBox1.Text);
                    Entry.ShowDialog();
                    metroButton1.PerformClick();
                }
            }
            catch (Exception)
            {
                messagemode.MetroMessageBox("Error while getting vendor list.", this, false);
            }

        }
    }
}
