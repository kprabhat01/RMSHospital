using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.P
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        void GetAmountVerified()
        {
            if (Classes.OrderMode.placedOrderAmount < Classes.OrderMode.discountAmount)
            {
                Classes.messagemode.messageget(false, "Disounted Amount cannot be greater than Order Amount");
                this.Close();
            }
            else
            {
                Classes.OrderMode.PaidAmount = Classes.OrderMode.placedOrderAmount - Classes.OrderMode.discountAmount;
                discount.Text = Classes.OrderMode.discountAmount.ToString();
                BilledAmount.Text = Math.Round(Classes.OrderMode.PaidAmount).ToString("F2");
                receivedAmu.Text = Math.Round(Classes.OrderMode.PaidAmount).ToString("F2");
                Returned.Text = "0.00";
            }
        }
        void getPaymentMode()
        {
            try
            {
                paymentMode.DataSource = Classes.OrderMode.Payments;
                paymentMode.DisplayMember = "ModeName";
                paymentMode.ValueMember = "id";

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }
        private void Transaction_Load(object sender, EventArgs e)
        {
            GetAmountVerified();
            Submit.Visible = true;
            Tamount.Text = Classes.OrderMode.placedOrderAmount.ToString("F2");
            //receivedAmu.Text = "";
            //receivedAmu.Focus();
            getPaymentMode();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            Classes.OrderMode.creditCustomeId = 0;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (decimal.Parse(BilledAmount.Text) <= decimal.Parse(receivedAmu.Text))
                    {
                        decimal refund = decimal.Parse(receivedAmu.Text) - decimal.Parse(BilledAmount.Text);
                        Returned.Text = refund.ToString("F2");
                        Submit.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //do nothing;
            }
        }

        private void receivedAmu_TextChanged(object sender, EventArgs e)
        {


        }

        private void Submit_Click(object sender, EventArgs e)
        {

            try
            {
                Classes.OrderMode.amount = decimal.Parse(receivedAmu.Text);
                Classes.OrderMode.refundAmount = decimal.Parse(Returned.Text);
                Classes.OrderMode.ordermode = int.Parse(paymentMode.SelectedValue.ToString());
                Classes.OrderMode.billcomment = comment.Text;
                Classes.OrderMode.creditAmu = 0;
                if (Classes.OrderMode.amount >= decimal.Parse(BilledAmount.Text))
                {
                    Classes.OrderMode.placeflag = true;
                    this.Close();
                }
                else {
                    Classes.messagemode.messageget(false, "Somthing wrong in amount");
                }
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please enter amount in proper format");
                return;
            }


        }

        private void paymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(paymentMode.SelectedValue.ToString()) == 2)
                {
                    receivedAmu.Enabled = false;
                    Returned.Enabled = false;
                    Submit.Visible = true;
                    receivedAmu.Text = "0.00";
                    Returned.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                // do nothing
            }
        }
        void Form_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control == true && e.KeyCode == Keys.C)
            {
                Credit.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                Submit.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                paymentMode.Focus();
            }

        }
        private void Transaction_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Credit_Click(object sender, EventArgs e)
        {
            decimal creditAmount = decimal.Parse(BilledAmount.Text) - decimal.Parse(receivedAmu.Text);
            if (BilledAmount.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please enter billed amount");
                return;
            }
            else if (receivedAmu.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please enter any amount atlead 0");
                return;
            }
            else if (float.Parse(BilledAmount.Text) < float.Parse(receivedAmu.Text))
            {
                Classes.messagemode.messageget(false, "Cannot make credit sale as it is lesser than Received Amount.");
                return;

            }
            else
            {
                Classes.OrderMode.CreditMode = true;
                Cus.CustomerManagement manage = new Cus.CustomerManagement();
                manage.ShowDialog();

                if (Classes.OrderMode.creditCustomeId >= 1)
                {
                    Classes.OrderMode.amount = decimal.Parse(receivedAmu.Text);
                    Classes.OrderMode.refundAmount = decimal.Parse(Returned.Text);
                    Classes.OrderMode.ordermode = int.Parse(paymentMode.SelectedValue.ToString());
                    Classes.OrderMode.billcomment = comment.Text;
                    Classes.OrderMode.creditAmu = creditAmount;
                    Classes.OrderMode.placeflag = true;
                    this.Close();
                }

            }
        }

    }
}
