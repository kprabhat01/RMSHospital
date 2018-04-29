using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.U
{
    public partial class Utype : Form
    {
        public Utype()
        {
            InitializeComponent();
        }

        private void Utype_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Select Store";
            
            // Setting user type 
            listBox1.DataSource = Classes.UserManagement.UserType;
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "type";

            //
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.UserManagement.Sutypeid = int.Parse(listBox1.SelectedValue.ToString());
                Classes.UserManagement.SutypeName = listBox1.Text;
                this.Close();

            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "UserType Not Selected");
                Classes.writeme.errorname(ex);
                return;
            }
        }
    }
}
