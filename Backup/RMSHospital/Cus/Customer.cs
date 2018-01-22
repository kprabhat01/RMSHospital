using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Cus
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        private void DetailForCustomer(int custid)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            if (Classes.Customer.customerid >= 1)
            {
                DataTable dt = Classes.Customer.customerprofile(Classes.Customer.customerid);
                fname.Text = dt.Rows[0][1].ToString();
                lname.Text = dt.Rows[0][2].ToString();
                ph1.Text = dt.Rows[0][3].ToString();
                ph2.Text = dt.Rows[0][4].ToString();
                line1.Text = dt.Rows[0][5].ToString();
                line2.Text = dt.Rows[0][6].ToString();
                line3.Text = dt.Rows[0][7].ToString();
                comment.Text = dt.Rows[0][9].ToString();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (fname.Text.Length == 0 || lname.Text.Length == 0 || ph1.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please enter date in mandatory field.");
                return;
            }
            else
            {
                Classes.Customer.customerinfo(fname.Text, lname.Text, ph1.Text, ph2.Text, line1.Text, line2.Text, line3.Text, comment.Text);
                if (Classes.Customer.customerid == 0)
                {
                    fname.Text = "";
                    lname.Text = "";
                    ph1.Text = "";
                    ph2.Text = "";
                    line1.Text = "";
                    line2.Text = "";
                    line3.Text = "";
                    comment.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
