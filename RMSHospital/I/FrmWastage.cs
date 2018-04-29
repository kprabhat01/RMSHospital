using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1.I
{
    public partial class FrmWastage : MetroFramework.Forms.MetroForm
    {
        private string ItemName { get; set; }
        private int ItemId { get; set; }
        private int StoreId { get; set; }
       
        public FrmWastage(int IItemId, string IItemName, int IStoreId, string Unit)
        {
            InitializeComponent();
            ItemName = IItemName;
            ItemId = IItemId;
            StoreId = IStoreId;
            this.Text = ItemName;
            lblUnit.Text = Unit;
        }

        private void FrmWastage_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(metroTextBox1.Text);
            }
            catch (Exception)
            {
                messagemode.MetroMessageBox("Please enter proper qty.", this, false);
                return;
            }

            string Query = @"SELECT Menu_Item_Detail.id, menu_items.id as menuid,menu_items.menuname AS Item,pro_catagories.name AS 'Sub-Categories',pro_inventory_cat.catname AS Categories,Menu_Item_Detail.stock AS Qty,unit.name AS Unit 
                             FROM unit, pro_inventory_cat, menu_items, pro_catagories, Menu_Item_Detail WHERE menu_items.id = Menu_Item_Detail.menu_item_id AND menu_items.unit = unit.id AND menu_items.deleteflag= 0
                             AND menu_items.menugroup = pro_catagories.id AND pro_catagories.pro_inventory_cat_id = pro_inventory_cat.id AND Menu_Item_Detail.storeid = " + StoreId + " and menu_items.id=" + ItemId + "";

            DataTable dt = new DataTable();
            MySqlConnection SqlCon = detail.con;
            MySqlTransaction Trns = null;
            if (SqlCon.State == ConnectionState.Open)
                SqlCon.Close();
            try
            {
                dt = SqlHelper.ReturnRows(Query);
                SqlCon.Open();
                Trns = SqlCon.BeginTransaction();
                List<Menu_Item_Detail> lst = new List<Menu_Item_Detail>();
                lst.Add(new Menu_Item_Detail
                {
                    stock = decimal.Parse(dt.Rows[0]["Qty"].ToString()) - decimal.Parse(metroTextBox1.Text),
                    Id = int.Parse(dt.Rows[0]["id"].ToString())
                });
                List<Inven_Logs> logs = new List<Inven_Logs>();
                logs.Add(new Inven_Logs
                {
                    Credit = decimal.Parse(metroTextBox1.Text),
                    CurrentQty = decimal.Parse(dt.Rows[0]["Qty"].ToString()) - decimal.Parse(metroTextBox1.Text),
                    LastQty = decimal.Parse(dt.Rows[0]["Qty"].ToString()),
                    menu_items_Id = int.Parse(dt.Rows[0]["menuid"].ToString()),
                    menu_item_name = dt.Rows[0]["Item"].ToString(),
                    StoreID = StoreId,
                    DebitType = 0,
                    LogMode = "Westage",
                    Username = loginmodule.username
                });
                if (lst.UpdateChanges() && logs.SaveChanges())
                {
                    Trns.Commit();
                    messagemode.MetroMessageBox("Westage has been added to the system.", this, true);
                    this.Close();
                }
                else
                    Trns.Rollback();


            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                Trns.Rollback();
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }


        }
    }
}
