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
    public partial class PrintDoc : Form
    {
        public PrintDoc()
        {
            InitializeComponent();
        }

        private void PrintDoc_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Print Options";
        }
    }
}
