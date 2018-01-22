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
    public partial class StockOutWards : Form
    {
        public StockOutWards()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        DataTable storeStock;
        private void getInserteValue()
        {
            dataGridView1.DataSource = Classes.Inventory.getOutwardsStock(Classes.Stores.SelectedStoreid);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Width = 200;

        }
        private void StockOutWards_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            P.StoreName st = new P.StoreName();
            st.ShowDialog();
            storename.Text = Classes.Stores.Selectedstorename;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (storename.Text.Length >= 1)
            {
                storeStock.DefaultView.RowFilter = "ItemName like '%" + ItemName.Text + "%'";
                menulist.DataSource = storeStock;
                menulist.ValueMember = "Itemid";
                menulist.DisplayMember = "ItemName";
            }
        }

        private void storename_TextChanged(object sender, EventArgs e)
        {
            if (storename.Text.Length >= 1)
            {
                storeStock = Classes.Inventory.IndividualStoreStock(Classes.Stores.SelectedStoreid);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int proid = 0;
            float qty = 0;
            try
            {
                if (ItemName.Text.Length >= 1)
                {
                    proid = int.Parse(menulist.SelectedValue.ToString());
                    qty = float.Parse(quantity.Text);
                }
                else
                {
                    Classes.messagemode.messageget(false, "Please enter Item ");
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Please enter qty in numbers");
            }
            try
            {

                if (Classes.Inventory.outwardstock(proid, qty, Classes.Stores.SelectedStoreid))
                    getInserteValue();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            int storeid = 0;
            int itemid = 0;
            float qty = 0;

            try
            {
                id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                storeid = int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                itemid = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                qty = float.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the ItemName");
                return;
            }
            try
            {
                if (Classes.Inventory.RemoveOutWardStock(id, itemid, storeid, qty))
                {
                    getInserteValue();
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }

        }

        private void StockOutWards_FormClosing(object sender, FormClosingEventArgs e)
        {
            Classes.Inventory.SaveTempInformation();
        }
    }
}
