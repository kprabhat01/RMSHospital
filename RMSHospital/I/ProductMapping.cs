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
    public partial class ProductMapping : Form
    {
        public ProductMapping()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        private void getMappedItem()
        {
            try
            {
                dataGridView1.DataSource = Classes.ProductMapping.getInsertedValue(Classes.Stores.SelectedStoreid, Classes.ProductMapping.selectedproid);
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 240;
                dataGridView1.Columns[0].HeaderText = "Product Name";
                dataGridView1.Columns[0].HeaderText = "Qty";
                proname.Text = "";
                proname.Focus();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Error while getting the information");
                return;
            }


        }
        private void ProductMapping_Load(object sender, EventArgs e)
        {
            getMappedItem();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Classes.Inventory.GetStockInfo(Classes.Stores.SelectedStoreid);
            DataTable dt = Classes.Inventory.stocklist;
            dt.DefaultView.RowFilter = "productname like '%" + proname.Text + "%'";
            dt = dt.DefaultView.Table;
            prolist.DataSource = dt;
            prolist.DisplayMember = "productname";
            prolist.ValueMember = "Itemid";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Classes.ProductMapping.checkproinsert(int.Parse(prolist.SelectedValue.ToString()), Classes.ProductMapping.selectedproid, Classes.Stores.SelectedStoreid))
                {
                    Classes.ProductMapping.insertmenu(Classes.ProductMapping.selectedproid, Classes.Stores.SelectedStoreid, int.Parse(prolist.SelectedValue.ToString()), float.Parse(qty.Text), Classes.loginmodule.username);
                    getMappedItem();
                }
                else
                {
                    Classes.messagemode.messageget(false, "Item is already mapped, Please remove and then add the item");
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Classes.messagemode.messageget(false, "Item is not selected");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (Classes.messagemode.confirm("Are you sure to delete the selected menu?"))
                {
                    if (Classes.ProductMapping.DeleteItems(id))
                    {
                        getMappedItem();
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.messagemode.messageget(false, "Please select the item properly");
                Classes.writeme.errorname(ex);
                return;
            }
        }

        private void proname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                proname.Text = prolist.Text;
                qty.Text = "";
                qty.Focus();
            }
        }

        private void proname_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}