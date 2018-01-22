using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.I
{
    public partial class StoreStocIntery : Form
    {

        public StoreStocIntery()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        Classes.Inventory StockInventor = new Classes.Inventory();

        string getSum()
        {
            float sum = 0;
            try
            {

                if (dataGridView1.Rows.Count >= 1)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        sum += float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);

            }
            return sum.ToString("F2");
        }
        bool UpdateInfo()
        {
            try
            {
                StringBuilder query = new StringBuilder();
                DataTable dt = new DataTable();
                dt = StockInventor.stockInwards;
                //Inserting item if not available


                // Getting inserted the main the main menu on the parts of the requirement.
                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        query.Append("Update storestock set cur_stock=cur_stock+" + dr["qty"].ToString() + " ,lastupdate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where itemid ='" + dr["Product ID"].ToString() + "' and  storeid='" + Classes.Stores.SelectedStoreid + "'; ");
                    }
                    return Classes.SqlHelper.InsertInfo(query.ToString());
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        bool InsertInfo(int AcId)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                DataTable dt = new DataTable();
                dt = StockInventor.stockInwards;
                if (dt.Rows.Count >= 1)
                {
                    query.Append("Insert into storestock_logs(itemid,storeid,qty,rate,total,dateDetail,username,day,lockmenu,vendorid,Accid) values ");
                    foreach (DataRow dr in dt.Rows)
                    {
                        query.Append(" ('" + dr["Product ID"].ToString() + "','" + Classes.Stores.SelectedStoreid + "','" + dr["Qty"].ToString() + "','" + dr["Rate"].ToString() + "','" + dr["Total"].ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Classes.loginmodule.username + "','" + Classes.OpenDay.day + "',1,'" + Classes.vendors.selectedVendorid + "','" + AcId + "'),");
                    }
                    string runningQuery = query.ToString().TrimEnd(',');
                    return Classes.SqlHelper.InsertInfo(runningQuery);
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return false;
            }

        }
        void getItemlist()
        {
            try
            {
                DataTable dt = Classes.Items.Itemslist;
                ItemListDetail.DataSource = dt;
                ItemListDetail.DisplayMember = "productname";
                ItemListDetail.ValueMember = "id";
                ItemListDetail.Items.Insert(0, "");
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }
        }

        private void StoreStocIntery_Load(object sender, EventArgs e)
        {
            this.Text = "Invard Stock Entry";
            panel2.Visible = false;
            proname.Visible = false;
            rate.TextAlign = HorizontalAlignment.Right;

            proname.AutoCompleteMode = AutoCompleteMode.Suggest;
            proname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            addItems(DataCollection);
            proname.AutoCompleteCustomSource = DataCollection;
            getItemlist();

        }
        public void addItems(AutoCompleteStringCollection col)
        {
            DataTable dt = Classes.Items.Itemslist;
            foreach (DataRow dr in dt.Rows)
            {
                col.Add(dr[2].ToString() + " " + dr[3].ToString());
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            P.StoreName store = new P.StoreName();
            store.ShowDialog();
            Storename.Text = Classes.Stores.Selectedstorename;
            if (Storename.Text.Length >= 1)
                select.Enabled = false;
        }
        void getDataForstores()
        {
            try
            {
                if (Storename.Text.Length >= 1 && vendors.Text.Length >= 1)
                {
                    panel2.Visible = true;
                }
                else
                {
                    panel2.Visible = false;
                }
                if (Classes.Stores.SelectedStoreid >= 1 && Classes.vendors.selectedVendorid >= 1)
                {
                    getDataBase();
                    Classes.Inventory.GetStockInfo(Classes.Stores.SelectedStoreid);
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return;
            }

        }


        private void Storename_TextChanged(object sender, EventArgs e)
        {
            getDataForstores();
        }
        private void getDataBase()
        {
            try
            {
                DataTable dt = StockInventor.stockInwards;
                dt = dt.DefaultView.ToTable(true, "Product Name", "Qty", "Rate", "Total");
                dataGridView1.DataSource = dt; //Classes.Inventory.getInsertedData(Classes.Stores.SelectedStoreid, Classes.OpenDay.day);
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToResizeColumns = false;
                //dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[1].Visible = false;
                //dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[0].Width = 275;
                dataGridView1.Columns[1].Width = 50;
                dataGridView1.Columns[2].Width = 70;
                dataGridView1.Columns[3].Width = 70;
                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                SumAmount.Text = getSum();
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ItemListDetail.Text.Length >= 1)
            {
                try
                {
                    float.Parse(qty.Text);
                    float.Parse(rate.Text);
                }
                catch (Exception ex)
                {
                    Classes.messagemode.messageget(false, "Entry is not in proper format");
                    return;

                }
                try
                {
                    float totalValue = float.Parse(qty.Text) * float.Parse(rate.Text);
                    StockInventor.stockInwards.Rows.Add(int.Parse(ItemListDetail.SelectedValue.ToString()), ItemListDetail.Text, qty.Text, rate.Text, Math.Round(totalValue).ToString("F2"), Classes.vendors.selectedVendorid);

                    getDataBase();
                    /*String[] getItemid = proname.Text.ToString().Split('-');
                    for (int i = 0; i < getItemid.Length; i++)
                    {

                        if (Classes.Inventory.CorrectMenu(Classes.Stores.SelectedStoreid, int.Parse(ItemListDetail.SelectedValue.ToString())))
                        {
                            if (Classes.Inventory.prostockInsert(Classes.Stores.SelectedStoreid, int.Parse(getItemid[i]), float.Parse(qty.Text), float.Parse(rate.Text)))
                            {
                                getDataBase();
                            }
                        }
                    }*/
                }
                catch (Exception ex)
                {
                    Classes.messagemode.messageget(false, "Cannot find the item from list.");
                    return;
                }
            }
            ItemListDetail.Text = "";
            qty.Text = "";
            rate.Text = "";
            ItemListDetail.Focus();
        }
        void clearInput()
        {
            StockInventor.stockInwards.Rows.Clear();
            dataGridView1.DataSource = null;
            SumAmount.Text = "0.00";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //tans = detail.con.BeginTransaction();
                StockInventor.getListofStoreInventory(Classes.Stores.SelectedStoreid);
                StockInventor.insertDifference();
                /*string selectedid = "";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    selectedid += dataGridView1.Rows[i].Cells[0].Value.ToString() + ",";
                }
                selectedid = selectedid.TrimEnd(',');
                if (selectedid.Length >= 1)
                {
                    if (Classes.messagemode.confirm("Are you sure to save the information?"))
                    {
                        if (Classes.Inventory.saveInventory(selectedid))
                        {
                            getDataBase();
                        }
                    }
                }*/

                if (Classes.messagemode.confirm("Are you sure to save the information ?"))
                {
                    int vendorid = 0;
                    if (dataGridView1.Rows.Count >= 1)
                    {
                        vendorid = Classes.Inventory.getVendorID(Classes.Stores.SelectedStoreid, Classes.vendors.selectedVendorid, getSum(), "Amount Added to the Inventory", "0.00", true);
                        if (vendorid >= 1)
                        {
                            if (InsertInfo(vendorid))
                            {
                                if (UpdateInfo())
                                {
                                    Classes.messagemode.messageget(true, "Stock has been stored.");
                                    clearInput();
                                }
                            }
                        }
                    }
                    else
                    {
                        Classes.messagemode.messageget(false, "No Data found in List to insert");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Classes.messagemode.confirm("Are you sure to delete the selected Item ?"))
                {
                    string product = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    string qty = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string rate = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    string amount = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                    foreach (DataRow dr in StockInventor.stockInwards.Rows)
                    {
                        if (dr["Product Name"].ToString() == product && dr["Qty"].ToString() == qty && dr["Rate"].ToString() == rate && dr["Total"].ToString() == amount)
                        {
                            dr.Delete();
                        }
                    }
                    getDataBase();
                }
            }
            catch (Exception ex)
            {
                getDataBase();
                Classes.writeme.errorname(ex);
                // Classes.messagemode.messageget(false, "Error while deleting information, Make sure the row has been selected.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AddItems item = new AddItems();
                item.ShowDialog();
                getItemlist();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void proname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                stk.Text = "";
                DataTable dt = Classes.Inventory.stocklist;
                // DataRow dr = dt.Select("itemid=")
                String[] getItemid = proname.Text.ToString().Split('-');
                for (int i = 0; i < getItemid.Length; i++)
                {
                    if (i == (getItemid.Length - 1))
                    {
                        DataRow[] dr = dt.Select("itemid=" + getItemid[i] + "");
                        stk.Text = dr[0]["cur_stock"].ToString() + " " + dr[0]["name"].ToString() + "|" + dr[0]["lastupdate"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Classes.vendors.selectflag = 1;
            Vendors vs = new Vendors();
            vs.ShowDialog();
            vendors.Text = Classes.vendors.selectvedorname;
            if (vendors.Text.Length >= 1)
                button5.Enabled = false;
        }

        private void vendors_TextChanged(object sender, EventArgs e)
        {
            getDataForstores();
        }

    }
}
