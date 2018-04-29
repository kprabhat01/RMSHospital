using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;
using System.Configuration;

namespace WindowsFormsApplication1.I
{
    public partial class StoreStocIntery : MetroFramework.Forms.MetroForm
    {

        public StoreStocIntery()
        {
            InitializeComponent();
            //this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.TopLevel = true;
            SetDefaultStore();
        }
        Inventory StockInventor = new Classes.Inventory();

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
                writeme.errorname(ex);

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
                    return SqlHelper.InsertInfo(query.ToString());
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
                writeme.errorname(ex);
                return false;
            }

        }
        void getItemlist()
        {
            try
            {
                Inventory.GetStockInfo(Stores.SelectedStoreid);
                DataTable dt = Inventory.stocklist;
                ItemListDetail.DataSource = dt;
                ItemListDetail.DisplayMember = "item";
                ItemListDetail.ValueMember = "id";
                ItemListDetail.Items.Insert(0, "");
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
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

        }
        public void addItems(AutoCompleteStringCollection col)
        {
            DataTable dt = Classes.Items.Itemslist;
            foreach (DataRow dr in dt.Rows)
            {
                col.Add(dr[2].ToString() + " " + dr[3].ToString());
            }
        }
        private void SetDefaultStore()
        {
            try
            {
                string StoreValue = ConfigurationSettings.AppSettings["DefaultStockStore"];
                if (StoreValue != null && int.Parse(StoreValue) > 0)
                {
                    DataRow[] Dr = MenuMaster.storegroup.Select("id=" + int.Parse(StoreValue));

                    foreach (DataRow dr in Dr)
                    {
                        if (OpenDay.getstoreOpenlog(int.Parse(dr["id"].ToString())))
                        {
                            Classes.Stores.SelectedStoreid = int.Parse(dr["id"].ToString());
                            Classes.Stores.Selectedstorename = dr["store"].ToString();
                            Storename.Text = dr["store"].ToString();
                            select.Enabled = false;
                            Classes.Inventory.GetStockInfo(int.Parse(dr["id"].ToString()));
                            getItemlist();

                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            P.StoreName store = new P.StoreName();
            store.ShowDialog();
            Storename.Text = Classes.Stores.Selectedstorename;
            if (Storename.Text.Length >= 1)
                select.Enabled = false;
            Classes.Inventory.GetStockInfo(Classes.Stores.SelectedStoreid);
            getItemlist();
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
                dt = dt.DefaultView.ToTable(true, "ProductName", "Qty", "Rate", "Total", "ProductId");
                dataGridView1.DataSource = dt; //Classes.Inventory.getInsertedData(Classes.Stores.SelectedStoreid, Classes.OpenDay.day);
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToResizeColumns = false;
                //dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[1].Visible = false;
                //dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[0].Width = 375;
                dataGridView1.Columns[0].HeaderText = "Product Name";
                dataGridView1.Columns[1].Width = 50;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
                dataGridView1.GridColor = Color.DodgerBlue;
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
                    StockInventor.stockInwards.Rows.Add(int.Parse(ItemListDetail.SelectedValue.ToString()), ItemListDetail.Text, qty.Text, float.Parse(rate.Text).ToString("F2"), Math.Round(totalValue).ToString("F2"), Classes.vendors.selectedVendorid);

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
            MySqlTransaction Trs = null;
            MySqlConnection SqlCon = detail.con;
            SqlCon.Open();
            Trs = SqlCon.BeginTransaction();
            try
            {

                if (Classes.Stores.SelectedStoreid >= 1 && Storename.Text.Length >= 1 && vendors.Text.Length >= 1 && Classes.vendors.selectedVendorid >= 1 && txtBillNo.Text.Length >= 1 && dataGridView1.Rows.Count >= 1)
                {
                    string CDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    List<inven_inwards> lst = new List<inven_inwards>();
                    lst.Add(new inven_inwards
                    {
                        StoreID = Stores.SelectedStoreid,
                        VendorID = Classes.vendors.selectedVendorid,
                        BillNo = txtBillNo.Text,
                        CreatedDate = CDate,
                        UserName = loginmodule.username,
                    });

                    if (lst.SaveChanges())
                    {
                        lst = new List<inven_inwards>();
                        lst.Add(new inven_inwards
                        {
                            UserName = loginmodule.username,
                            CreatedDate = CDate
                        });
                        DataTable dt = lst.ReturnRow();
                        if (dt.Rows.Count >= 1)
                        {
                            List<inven_inwards_stock> Stocklst = new List<inven_inwards_stock>();
                            List<Menu_Item_Detail> Stock = new List<Menu_Item_Detail>();
                            Stock.Add(new Menu_Item_Detail
                            {
                                StoreId = Stores.SelectedStoreid
                            });
                            var StkItem = Stock.ReturnRow();
                            foreach (DataRow dr in StockInventor.stockInwards.Rows)
                            {
                                Stocklst.Add(new inven_inwards_stock
                                {
                                    Inven_inwards_ID = int.Parse(dt.Rows[0]["Id"].ToString()),
                                    menu_items_id = int.Parse(dr[0].ToString()),
                                    Qty = float.Parse(dr["Qty"].ToString()),
                                    Rate = float.Parse(dr["Rate"].ToString()),
                                    TotalAmount = float.Parse(dr["Total"].ToString())
                                });
                            }
                            if (Stocklst.SaveChanges(SqlCon, Trs))
                            {
                                var DtSet = StockInventor.stockInwards;
                                var newDt = (from detail in DtSet.AsEnumerable()
                                             group detail by new { ID = detail.Field<int>("ProductId"), PrName = detail.Field<string>("ProductName") } into g
                                             join bp in StkItem.AsEnumerable() on g.Key.ID equals bp.Field<int>("Menu_Item_Id")
                                             select new
                                             {
                                                 ProductIdValue = g.Key.ID,
                                                 ProductNameValue = g.Key.PrName,
                                                 SumQty = g.Sum(R => R.Field<Decimal>("Qty")),
                                                 Qty = bp.Field<decimal>("stock"),
                                                 StokId = bp.Field<int>("Id")
                                             }).ToList();
                                List<Inven_Logs> InLogs = new List<Inven_Logs>();
                                Stock = new List<Menu_Item_Detail>();
                                for (int i = 0; i < newDt.Count; i++)
                                {
                                    InLogs.Add(new Inven_Logs
                                    {
                                        menu_items_Id = newDt[i].ProductIdValue,
                                        menu_item_name = newDt[i].ProductNameValue,
                                        DebitType = 0,
                                        Debit = newDt[i].SumQty,
                                        LastQty = newDt[i].Qty,
                                        CurrentQty = newDt[i].SumQty + newDt[i].Qty,
                                        Username = loginmodule.username,
                                        LogMode = "Inventory Inwards",
                                        StoreID = Stores.SelectedStoreid
                                    });
                                    Stock.Clear();
                                    Stock.Add(new Menu_Item_Detail
                                    {
                                        Id = newDt[i].StokId,
                                        stock = newDt[i].SumQty + newDt[i].Qty
                                    });
                                    if (!Stock.UpdateChanges(SqlCon, Trs))
                                        throw new Exception("Error while saving the information");

                                }
                                if (InLogs.SaveChanges(SqlCon, Trs))
                                {
                                    SumAmount.Text = getSum();

                                    //DataTable GetVendorAccount = Acc

                                    List<inven_inwards_vendoraccount> Acc = new List<inven_inwards_vendoraccount>();
                                    DataTable dtVendorScore = Classes.vendors.GetOpeningBalance(Classes.vendors.selectedVendorid, SqlCon);
                                    Acc.Add(new inven_inwards_vendoraccount
                                    {
                                        Inven_inwards_ID = int.Parse(dt.Rows[0]["id"].ToString()),
                                        CreditAmount = decimal.Parse(SumAmount.Text),
                                        VendorId = Classes.vendors.selectedVendorid,
                                        username = loginmodule.username,
                                        PaymentMode = 0,
                                        OpeningBalance = decimal.Parse(dtVendorScore.Rows[0][0].ToString()),
                                        ClosingBalance = decimal.Parse(dtVendorScore.Rows[0][0].ToString()) + decimal.Parse(SumAmount.Text)
                                    });
                                    if (Acc.SaveChanges(SqlCon, Trs))
                                    {
                                        Trs.Commit();
                                        messagemode.MetroMessageBox("Stock has been saved", this, true);
                                        this.Close();
                                    }
                                    else
                                    {
                                        Trs.Rollback();
                                    }
                                }
                                else
                                    Trs.Rollback();
                            }
                            else
                                Trs.Rollback();
                        }
                        else
                            Trs.Rollback();
                    }
                    else
                    {
                        Trs.Rollback();
                    }
                }
                else
                {
                    Classes.messagemode.messageget(false, "Option OR Bill number has not be selected.");
                }

                /* //tans = detail.con.BeginTransaction();
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
                 }

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
                 }*/
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Trs.Rollback();
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
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
                // getDataBase();
                Classes.writeme.errorname(ex);
                // Classes.messagemode.messageget(false, "Error while deleting information, Make sure the row has been selected.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                P.MenuItems item = new P.MenuItems();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                P.MenuItems item = new P.MenuItems(Stores.SelectedStoreid, Stores.Selectedstorename);
                item.ShowDialog();
                getItemlist();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Storename_Click(object sender, EventArgs e)
        {

        }

        private void vendors_Click(object sender, EventArgs e)
        {

        }

        private void StoreStocIntery_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void StoreStocIntery_KeyDown(object sender, KeyEventArgs e)
        {
            /* ModifierKeys modifiers = e.KeyboardDevice.Modifiers;
             if (e.KeyCode.ToString()=="F1")
             {

             }*/
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            SumAmount.Text = getSum();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView1.SelectedRows.Count >= 1)
                {
                    button4.PerformClick();
                }
            }
        }

        private void ItemListDetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
