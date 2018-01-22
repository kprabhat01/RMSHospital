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
    public partial class Comment : Form
    {
        public Comment()
        {
            InitializeComponent();
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            richTextBox1.Text = Classes.POS.comment;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.POS.comment = richTextBox1.Text;
            this.Close();
        }
    }
}
