using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.I
{
    public partial class AddVendor : Form
    {
        int check;
        public AddVendor()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        void getVendorDetail()
        {
            if (Classes.vendors.vendorflag >= 1)
            {
                try
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter("select * from vendors where id=" + Classes.vendors.vendorflag + "", detail.con))
                    {
                        DataTable dt = new DataTable();
                        detail.con.Open();
                        da.Fill(dt);
                        detail.con.Close();
                        name.Text = dt.Rows[0]["vendorname"].ToString();
                        phone.Text = dt.Rows[0]["phoneno"].ToString();
                        email.Text = dt.Rows[0]["email"].ToString();
                        comment.Text = dt.Rows[0]["contact_detail"].ToString();
                        name.Text = dt.Rows[0]["vendorname"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Classes.writeme.errorname(ex);
                    return;
                }
            }
        }
        private void AddVendor_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            getVendorDetail();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (name.Text.Length == 0 || phone.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please enter the proper details of vendor");
                return;
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    check = 0;
                }
                else
                {
                    check = 1;
                }
                if (Classes.vendors.VendorManage(Classes.vendors.vendorflag, name.Text, email.Text, phone.Text, comment.Text, check))
                {
                    Classes.messagemode.messageget(true, "Sucessfully Stored");
                }
                else
                {
                    Classes.messagemode.messageget(false, "Error while saving please check the logs.");
                }
                Classes.vendors.vendorslist();
                if (Classes.vendors.vendorflag == 0)
                {
                    name.Text = "";
                    phone.Text = "";
                    comment.Text = "";
                    email.Text = "";
                }
                else
                    this.Close();
            }
        }
    }
}
