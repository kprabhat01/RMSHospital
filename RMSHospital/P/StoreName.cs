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
    public partial class StoreName : Form
    {
        public StoreName()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;

        }

        private void StoreName_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Stores";
            Store.DataSource = Classes.MenuMaster.storegroup;
            Store.ValueMember = "id";
            Store.DisplayMember = "Store";
            //

            Classes.Stores.SelectedStoreid = 0;
            Classes.Stores.Selectedstorename ="";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Classes.OpenDay.getstoreOpenlog(int.Parse(Store.SelectedValue.ToString())))
                {
                    Classes.POS.storeid = int.Parse(Store.SelectedValue.ToString());
                    Classes.POS.storename = Store.Text;
                    Classes.Stores.SelectedStoreid = int.Parse(Store.SelectedValue.ToString());
                    Classes.Stores.Selectedstorename = Store.Text;
                    this.Close();
                }
                else {
                    Classes.messagemode.messageget(false, "Please open the day in proper and then proceed.");
                }

            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the store and then proceed.");
                return;
            }
        }
    }
}
