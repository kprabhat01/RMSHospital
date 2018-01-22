using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1.A
{
    public partial class TaxManagement : Form
    {
        public TaxManagement()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        protected void getTaxInformation()
        {
            try
            {
                listBox1.DataSource = Classes.Taxes.TaxInfo;
                listBox1.ValueMember = "id";
                listBox1.DisplayMember = "taxname";

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (taxname.Text.Length == 0 || PerCent.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please enter data to insert info.");
                return;
            }
            else
            {
                try
                {
                    float.Parse(PerCent.Text);
                }
                catch (Exception ex)
                {
                    Classes.messagemode.messageget(false, "Please enter proper Percentage for the information.");
                    return;
                }
                try
                {
                    if (Classes.Taxes.InsertTax(taxname.Text, float.Parse(PerCent.Text)))
                    {
                        Classes.Taxes.getTextInfo();
                        getTaxInformation();
                        taxname.Text = "";
                        PerCent.Text = "";
                        taxname.Focus();
                    }
                }
                catch (Exception ex)
                {
                    Classes.writeme.errorname(ex);
                }


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Classes.messagemode.confirm("Are you sure to delete the tax ?"))
                {
                    if (Classes.Taxes.Del_Tax(int.Parse(listBox1.SelectedValue.ToString())))
                    {

                        Classes.Taxes.getTextInfo();
                        getTaxInformation();
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the Tax and Process.");
                return;
            }
        }

        private void TaxManagement_Load(object sender, EventArgs e)
        {
            getTaxInformation();


        }
    }
}
