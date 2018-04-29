using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.I
{

    public partial class SendRequisition : MetroFramework.Forms.MetroForm
    {
        private int StoreId { get; set; }
        private string StoreName { get; set; }
        private DataTable TempProductInfo;
        private DataTable ProInformation;
        private int proid;
        private float QtyVal;
        private string ProName;
        DataTable ReturnBack;

        public SendRequisition(int StId, string StName)
        {
            InitializeComponent();

            this.MaximizeBox = false; ;
            this.MinimizeBox = false;
            this.StoreId = StId;
            this.StoreName = StName;
            this.Text = "Send Requisition from " + StoreName;
            this.ProInformation = new DataTable();
            GetTempProductTableInfo();
        }
        void GetTempProductTableInfo()
        {
            TempProductInfo = new DataTable();
            TempProductInfo.Columns.Add("Id", typeof(int));
            TempProductInfo.Columns.Add("Item Name", typeof(string));
            TempProductInfo.Columns.Add("Qty", typeof(float));
            TempProductInfo.Columns.Add("Unit", typeof(string));
        }
        void GetMenuName()
        {
            try
            {
                Inventory.GetStockInfo(Stores.SelectedStoreid);
                CmbItemName.DataSource = Classes.Inventory.stocklist;
                CmbItemName.DisplayMember = "Item";
                CmbItemName.ValueMember = "id";
                CmbItemName.Items.Insert(0, "");


            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
        private void SendRequisition_Load(object sender, EventArgs e)
        {

            storename.DataSource = MenuMaster.storegroup;
            storename.ValueMember = "id";
            storename.DisplayMember = "Store";
            GetMenuName();
            storename_SelectedIndexChanged(null, null);
        }
        void getViewProduct()
        {
            ProductList.DataSource = TempProductInfo;
            ProductList.Columns[0].Visible = false;
            ProductList.Columns[1].Width = 400;
            ProductList.Columns[2].Width = 50;
            ProductList.Columns[3].Width = 150;
            ProductList.AllowUserToAddRows = false;

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (!OpenDay.getstoreOpenlog(int.Parse(storename.SelectedValue.ToString())))
            {
                messagemode.MetroMessageBox("Unable to add item. Day for the 'To Store' is not open", this, false);
                return;
            }
            try
            {
                QtyVal = float.Parse(Qty.Text);
                proid = int.Parse(CmbItemName.SelectedValue.ToString());
                ProName = CmbItemName.Text;
            }
            catch (Exception)
            {
                messagemode.MetroMessageBox("Please enter quantity in proper format", this, false);
            }
            if (QtyVal > 0)
            {
                if (Stores.SelectedStoreid.ToString().Equals(storename.SelectedValue.ToString()))
                {
                    messagemode.MetroMessageBox("Cannot send the requestion for the same store.", this, false);
                    return;
                }
                DataRow[] Dr = ProInformation.Select("id=" + CmbItemName.SelectedValue.ToString() + "");
                if (Dr.Length >= 1)
                {
                    TempProductInfo.Rows.Add(int.Parse(CmbItemName.SelectedValue.ToString()), CmbItemName.Text, QtyVal, Dr[0]["unit"].ToString());
                    getViewProduct();
                    Qty.Text = string.Empty;
                    CmbItemName.Focus();
                }
                else
                {
                    messagemode.MetroMessageBox("Product is not availble in Other store.", this, false);
                    CmbItemName.Focus();
                }
            }
            else
                messagemode.MetroMessageBox("Quantity Should be not be zero", this, false);

        }
        bool GetProductQty()
        {
            try
            {
                ProInformation = new DataTable();
                Inventory.GetStockInfo(int.Parse(storename.SelectedValue.ToString()));
                ProInformation = Inventory.stocklist;
                Inventory.GetStockInfo(Stores.SelectedStoreid);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void storename_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetProductQty();
                TempProductInfo.Clear();
            }
            catch (Exception) { }
        }

        private void ProductList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (ProductList.SelectedRows.Count >= 1)
                {
                    DataRow[] Dr = TempProductInfo.Select("id=" + ProductList.SelectedRows[0].Cells[0].Value.ToString() + "");
                    Dr[0].Delete();
                    getViewProduct();
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (OpenDay.getstoreOpenlog(Stores.SelectedStoreid) && OpenDay.getstoreOpenlog(int.Parse(storename.SelectedValue.ToString())))
            {
                MySqlConnection SqlCon = detail.con;
                MySqlTransaction Trans = null;
                try
                {
                    if (GetProductQty())
                    {
                        SqlCon.Open();
                        Trans = SqlCon.BeginTransaction();
                        string dttime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        if (ProductList.Rows.Count >= 1)
                        {

                            if (messagemode.confirm("Are you sure to send the requisition to the " + storename.Text + "?"))
                            {
                                List<Inven_Requsition> lst = new List<Inven_Requsition>();
                                lst.Add(new Inven_Requsition
                                {
                                    CDate = dttime,
                                    Username = loginmodule.username,
                                    FrmStoreID = Stores.SelectedStoreid,
                                    ToStoreID = int.Parse(storename.SelectedValue.ToString())
                                });
                                if (lst.SaveChanges())
                                {
                                    lst.Clear();
                                    lst.Add(new Inven_Requsition
                                    {
                                        Username = loginmodule.username,
                                        CDate = dttime
                                    });
                                    ReturnBack = new DataTable();
                                    ReturnBack = lst.ReturnRow();
                                    if (ReturnBack.Rows.Count >= 1)
                                    {
                                        List<Inven_Requsition_Items> Requ = new List<Inven_Requsition_Items>();
                                        List<Inven_Logs> logs = new List<Inven_Logs>();
                                        List<Inven_Logs> logs_credit = new List<Inven_Logs>();
                                        List<Menu_Item_Detail> Inven = new List<Menu_Item_Detail>();
                                        List<Menu_Item_Detail> InvenCredit = new List<Menu_Item_Detail>();

                                        foreach (DataRow dr in TempProductInfo.Rows)
                                        {
                                            Requ.Add(new Inven_Requsition_Items
                                            {
                                                menu_items_id = int.Parse(dr["id"].ToString()),
                                                Menu_items_productName = dr["Item Name"].ToString(),
                                                unit = dr["Unit"].ToString(),
                                                qty = decimal.Parse(dr["qty"].ToString())
                                            });
                                            logs.Add(new Inven_Logs
                                            {
                                                menu_items_Id = int.Parse(dr["id"].ToString()),
                                                menu_item_name = dr["Item Name"].ToString(),
                                                StoreID = int.Parse(storename.SelectedValue.ToString()),
                                                dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                                LogMode = "Requsition",
                                                Username = loginmodule.username,
                                                DebitType = 0,
                                                Debit = decimal.Parse(dr["qty"].ToString()),
                                                CurrentQty = decimal.Parse(dr["qty"].ToString()) + decimal.Parse(ProInformation.Select("id=" + dr["id"].ToString() + "")[0]["qty"].ToString()),
                                                LastQty = decimal.Parse(ProInformation.Select("id =" + dr["id"].ToString() + "")[0]["qty"].ToString())
                                            });
                                            logs_credit.Add(new Inven_Logs
                                            {
                                                menu_items_Id = int.Parse(dr["id"].ToString()),
                                                menu_item_name = dr["Item Name"].ToString(),
                                                StoreID = Stores.SelectedStoreid,
                                                dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                                LogMode = "Requsition",
                                                Username = loginmodule.username,
                                                DebitType = 0,
                                                Credit = decimal.Parse(dr["qty"].ToString()),
                                                LastQty = decimal.Parse(Inventory.stocklist.Select("id=" + dr["id"].ToString() + "")[0]["qty"].ToString()),
                                                CurrentQty = decimal.Parse(Inventory.stocklist.Select("id=" + dr["id"].ToString() + "")[0]["qty"].ToString()) - decimal.Parse(dr["qty"].ToString()),
                                            });
                                            Inven.Clear();
                                            Inven.Add(new Menu_Item_Detail
                                            {
                                                Id = int.Parse(ProInformation.Select("id=" + int.Parse(dr["id"].ToString()) + "")[0]["menuMapId"].ToString()),
                                                stock = decimal.Parse(ProInformation.Select("id=" + int.Parse(dr["id"].ToString()) + "")[0]["Qty"].ToString()) + decimal.Parse(dr["qty"].ToString())
                                            });
                                            InvenCredit.Clear();
                                            InvenCredit.Add(new Menu_Item_Detail
                                            {
                                                Id = int.Parse(Inventory.stocklist.Select("id=" + int.Parse(dr["id"].ToString()) + "")[0]["menuMapId"].ToString()),
                                                stock = decimal.Parse(Inventory.stocklist.Select("id=" + int.Parse(dr["id"].ToString()) + "")[0]["Qty"].ToString()) - decimal.Parse(dr["qty"].ToString())
                                            });
                                            if (!Inven.UpdateChanges(SqlCon, Trans) || !InvenCredit.UpdateChanges(SqlCon, Trans))
                                                throw new Exception("Error while Updating Information.");
                                        }
                                        if (Requ.SaveChanges(SqlCon, Trans) && logs.SaveChanges(SqlCon, Trans) && logs_credit.SaveChanges(SqlCon, Trans))
                                        {
                                            Trans.Commit();
                                            messagemode.MetroMessageBox("Requisition has been sent to the store.", this, true);
                                            this.Close();
                                        }
                                        else
                                            Trans.Rollback();

                                    }
                                }
                                else
                                    messagemode.MetroMessageBox("Unable to process your request kindly contact administrator.", this, false);
                            }
                        }
                        else
                            messagemode.MetroMessageBox("Unable to process the request, no item has been selected.", this, false);
                    }
                }
                catch (Exception ex)
                {
                    if (ReturnBack.Rows.Count >= 1)
                    {
                        List<Inven_Requsition> req = new List<Inven_Requsition>();
                        req.Add(new Inven_Requsition
                        {
                            ID = int.Parse(ReturnBack.Rows[0]["id"].ToString())
                        }); req.DeleteChanges();
                    }
                    writeme.errorname(ex);
                    Trans.Rollback();

                }
                finally
                {
                    if (SqlCon.State == ConnectionState.Open)
                        SqlCon.Close();
                    this.Close();
                }
            }
            else
                messagemode.MetroMessageBox("Selected store hasn't open the day", this, false);

        }
    }
}
