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
    public partial class StoreOpen : Form
    {
        public StoreOpen()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void StoreOpen_Load(object sender, EventArgs e)
        {
            // Getting store List 
            Stores.DataSource = Classes.MenuMaster.storegroup;
            Stores.ValueMember = "id";
            Stores.DisplayMember = "Store";
            getListOpenStores();
            //
        }

        protected void getListOpenStores()
        {
            try
            {
                dataGridView1.DataSource = Classes.OpenDay.getOpenStores();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Classes.messagemode.confirm("Are you sure to open the day ?"))
            {
                if (Classes.OpenDay.getOldList(int.Parse(Stores.SelectedValue.ToString())))
                {
                    if (Classes.OpenDay.OpenStoreDay(int.Parse(Stores.SelectedValue.ToString())))
                    {
                        Classes.messagemode.messageget(true, "Selected store has been open");
                        getListOpenStores();
                    }
                }
                else
                {
                    Classes.messagemode.messageget(false, "One or more store is still open");
                    return;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int storeid;
            string date;
            try
            {
                storeid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                date = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the item to close the store");
                return;
            }
            try
            {
                if (Classes.messagemode.confirm("Are you sure to close the store ? This will close the application once done."))
                {
                    if (Classes.DayEndStatement.closeDay(storeid, date))
                    {
                        Application.Exit();
                    }
                }

            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false,"Error while closing the day");
                Classes.writeme.errorname(ex);
                return;
            }


        }
    }
}
