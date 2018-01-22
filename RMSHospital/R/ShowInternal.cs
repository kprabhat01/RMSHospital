using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.R
{
    public partial class ShowInternal : Form
    {
        public ShowInternal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        void getUpdatedBill()
        {
            webBrowser1.Url = new Uri(Classes.PrintReport.filedetail);
        }
        private void ShowInternal_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            getUpdatedBill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Classes.PrintReport.printfile(Classes.PrintReport.filedetail);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Classes.OrderMode.GetLastOrderID(Classes.OrderMode.SelectedOrderId, true);
            Classes.PrintReport.printbill(Classes.OrderMode.SelectedOrderId);
            getUpdatedBill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.OrderMode.GetLastOrderID(Classes.OrderMode.SelectedOrderId, false);
            Classes.PrintReport.printbill(Classes.OrderMode.SelectedOrderId);
            getUpdatedBill();
        }
    }
}
