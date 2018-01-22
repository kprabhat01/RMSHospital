using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.I
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        void getList()
        {
            try
            {
                listBox1.DataSource = Classes.Items.getDataTable();
                listBox1.ValueMember = "id";
                listBox1.DisplayMember = "catname";

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
            {
                if (Classes.Items.InsertItemCat(textBox1.Text))
                {
                    getList();
                    textBox1.Text = "";
                }
            }
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            getList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Classes.Items.CheckEntry(int.Parse(listBox1.SelectedValue.ToString())))
                {
                    Classes.messagemode.messageget(false, "One or more Item is still mapped with the inventory Items.");
                }
                else
                {
                    if (Classes.Items.DelCatid(int.Parse(listBox1.SelectedValue.ToString())))
                        getList();
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }

        }
    }
}
