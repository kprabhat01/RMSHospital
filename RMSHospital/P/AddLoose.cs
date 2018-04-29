using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1.P
{
    public partial class AddLoose : MetroFramework.Forms.MetroForm
    {
        private int _MenuID { get; set; }
        private string _MenuName { get; set; }
        private int _StoreId { get; set; }
        private DataTable _StoreStock;
        private DataRow[] Dr;
        private DataRow[] _DependencyStock;
        public AddLoose(int IMenuID, string IMenuName, int IstoreId, int? Qty = null)
        {
            InitializeComponent();
            this.Text = IMenuName;
            _MenuID = IMenuID;
            _MenuName = IMenuName;
            _StoreId = IstoreId;
            ShowQty();
            _DependencyStock = MenuMaster.MenuDependency.Select("MenuMappedId=" + _MenuID + " and StoreId=" + _StoreId + " and DependencyType=1");
            this.MaximizeBox = false;
            if (Qty != null)
            {
                txtQty.Text = Qty.ToString();
                txtQty.Enabled = false;
            }
        }
        void ShowQty()
        {
            try
            {
                _StoreStock = new DataTable();
                _StoreStock = SqlHelper.ReturnRows(@"SELECT Menu_Item_Detail.id, menu_items.id as MID,menu_items.menuname AS Item,pro_catagories.name AS 'Sub-Categories',pro_inventory_cat.catname AS Categories,Menu_Item_Detail.stock AS Qty,unit.name AS Unit 
                                                    FROM unit, pro_inventory_cat, menu_items, pro_catagories, Menu_Item_Detail WHERE menu_items.id = Menu_Item_Detail.menu_item_id AND menu_items.unit = unit.id AND menu_items.deleteflag= 0
                                                    AND menu_items.menugroup = pro_catagories.id AND pro_catagories.pro_inventory_cat_id = pro_inventory_cat.id AND Menu_Item_Detail.storeid = " + _StoreId + "");

            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
        void GridValue()
        {

            MenuGrid.Columns.Add("ItemName", "Item Name");
            MenuGrid.Columns.Add("ItemName", "Qty");
            MenuGrid.Columns[0].Width = 150;
            MenuGrid.AllowUserToAddRows = false;
            Dr = _StoreStock.Select("MID=" + _MenuID + "");
            foreach (DataRow dr in Dr)
            {
                MenuGrid.Rows.Add(dr["Item"].ToString(), dr["qty"].ToString());
            }
        }

        private void AddLoose_Load(object sender, EventArgs e)
        {
            GridValue();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection SqlCon = detail.con;
            MySqlTransaction Trans = null;
            try
            {
                int.Parse(txtQty.Text);
            }
            catch (Exception ex)
            {
                messagemode.MetroMessageBox("Please enter 'Qty' in proper format.", this, false);
            }
            try
            {
                if (decimal.Parse(txtQty.Text) > decimal.Parse(Dr[0]["Qty"].ToString()))
                {
                    messagemode.MetroMessageBox("Entered Qty is greater than available Stock.", this, false);
                    return;
                }

                SqlCon.Open();
                Trans = SqlCon.BeginTransaction();
                List<Inven_Logs> CrDLogs = new List<Inven_Logs>();
                CrDLogs.Add(new Inven_Logs
                {
                    Credit = decimal.Parse(txtQty.Text),
                    DebitType = 0,
                    LogMode = "Dependency",
                    menu_items_Id = int.Parse(Dr[0]["MId"].ToString()),
                    menu_item_name = Dr[0]["Item"].ToString(),
                    StoreID = _StoreId,
                    LastQty = decimal.Parse(Dr[0]["Qty"].ToString()),
                    CurrentQty = decimal.Parse(Dr[0]["Qty"].ToString()) - decimal.Parse(txtQty.Text),
                    Username = loginmodule.username
                });
                List<Menu_Item_Detail> Mnu = new List<Menu_Item_Detail>();
                Mnu.Add(new Menu_Item_Detail
                {
                    Id = int.Parse(Dr[0]["Id"].ToString()),
                    stock = decimal.Parse(Dr[0]["Qty"].ToString()) - decimal.Parse(txtQty.Text)
                });

                if (CrDLogs.SaveChanges(SqlCon, Trans) && Mnu.UpdateChanges(SqlCon, Trans))
                {
                    CrDLogs.Clear();
                    foreach (DataRow dr in _DependencyStock)
                    {
                        Dr = _StoreStock.Select("MID=" + dr["MenuID"].ToString() + "");
                        CrDLogs.Add(new Inven_Logs
                        {
                            Debit = decimal.Parse(dr["Qty"].ToString()) * decimal.Parse(txtQty.Text),
                            DebitType = 0,
                            LogMode = "Dependency",
                            menu_items_Id = int.Parse(Dr[0]["MId"].ToString()),
                            menu_item_name = Dr[0]["Item"].ToString(),
                            StoreID = _StoreId,
                            LastQty = decimal.Parse(Dr[0]["Qty"].ToString()),
                            CurrentQty = decimal.Parse(Dr[0]["Qty"].ToString()) + (decimal.Parse(dr["Qty"].ToString()) * decimal.Parse(txtQty.Text)),
                            Username = loginmodule.username
                        });
                        Mnu.Clear();
                        Mnu.Add(new Menu_Item_Detail
                        {
                            Id = int.Parse(Dr[0]["id"].ToString()),
                            stock = decimal.Parse(Dr[0]["Qty"].ToString()) + (decimal.Parse(dr["Qty"].ToString()) * decimal.Parse(txtQty.Text))
                        });
                        if (!Mnu.UpdateChanges(SqlCon, Trans))
                        {
                            Trans.Rollback();
                            break;
                        }
                    }
                    if (CrDLogs.SaveChanges(SqlCon, Trans))
                    {
                        Trans.Commit();
                        messagemode.MetroMessageBox("Add to Loose Operation has been successfull", this, true);
                        this.Close();
                    }
                    else Trans.Rollback();
                }
                else
                {
                    Trans.Rollback();
                }


            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                Trans.Rollback();
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }

        }
    }
}
