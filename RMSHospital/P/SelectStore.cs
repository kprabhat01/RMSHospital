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
    public partial class SelectStore : Form
    {
        public SelectStore()
        {
            InitializeComponent();
        }

        private void SelectStore_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Stores";
            storename.DataSource = Classes.MenuMaster.storegroup;
            storename.ValueMember = "id";
            storename.DisplayMember = "Store";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Stores.SelectedStoreid = int.Parse(storename.SelectedValue.ToString());
                Classes.Stores.Selectedstorename = storename.Text;
                this.Close();
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the store.");
            }
        }
    }
}
