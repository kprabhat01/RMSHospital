using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1.A
{
    public partial class AcEntry : MetroFramework.Forms.MetroForm
    {
        public int VendorID { get; set; }
        public AcEntry(int IVendorId, string IvendorName)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = IvendorName;
            VendorID = IVendorId;
        }

        private void AcEntry_Load(object sender, EventArgs e)
        {
            rdDebit.Checked = true;
            cmbPayment.DataSource = OrderMode.Payments;
            cmbPayment.DisplayMember = "ModeName";
            cmbPayment.ValueMember = "id";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            float Amount;
            try
            {
                Amount = float.Parse(txtAmount.Text);
            }
            catch (Exception)
            {
                messagemode.MetroMessageBox("Please enter amount in proper format.", this, false);
                return;
            }
            try
            {
                if (rdCredit.Checked || rdDebit.Checked)
                {
                    if (int.Parse(cmbPayment.SelectedValue.ToString()) >= 1) {

                        if (Amount >= 1)
                        {
                            detail.con.Open();
                            DataTable dt = vendors.GetOpeningBalance(VendorID, detail.con);
                            List<inven_inwards_vendoraccount> lst = new List<inven_inwards_vendoraccount>();
                            lst.Add(new inven_inwards_vendoraccount
                            {
                                Inven_inwards_ID = 0,
                                username = loginmodule.username,
                                VendorId = VendorID,
                                Comment = txtComment.Text,
                                PaymentMode = int.Parse(cmbPayment.SelectedValue.ToString()),
                                CreditAmount = rdCredit.Checked ? decimal.Parse(txtAmount.Text) : (decimal?)null,
                                DebitAmount = rdDebit.Checked ? decimal.Parse(txtAmount.Text) : (decimal?)null,
                                OpeningBalance = decimal.Parse(dt.Rows[0][0].ToString()),
                                ClosingBalance = rdCredit.Checked ? decimal.Parse(dt.Rows[0][0].ToString()) + decimal.Parse(txtAmount.Text) : decimal.Parse(dt.Rows[0][0].ToString()) - decimal.Parse(txtAmount.Text)
                                
                            });
                            if(lst.SaveChanges())
                                messagemode.MetroMessageBox("Information has been saved.", this, true);
                            else
                                messagemode.MetroMessageBox("Error while saving information, Kindly contact administrator.", this, false);
                            this.Close();
                        }
                    }
                    else
                        messagemode.MetroMessageBox("Amount suppose to be greater than 1.", this, false);
                }
                else
                    messagemode.MetroMessageBox("Please select any tranasaction mode.", this, false);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (detail.con.State == ConnectionState.Open)
                    detail.con.Close();
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtComment_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
