using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsApplication1.Classes
{
    class pro_inventory_cat
    {
        public int? Id { get; set; }
        public string Catname { get; set; }
        public int? deleteflag { get; set; }
    }
    class pro_catagories
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public int deleteflag { get; set; }
        public int pro_inventory_cat_Id { get; set; }
    }
    class menu_items
    {
        public int? Id { get; set; }
        public int? menugroup { get; set; }
        public int? deleteflag { get; set; }
        public string code { get; set; }
        public int? unit { get; set; }
        public string Username { get; set; }
        public string Cdate { get; set; }
        public string MenuName { get; set; }
        public string PrintName { get; set; }
        public int? ForSale { get; set; }
    }
    class menu_items_dependency
    {
        public int? id { get; set; }
        public int? StoreID { get; set; }
        public int? MenuID { get; set; }
        public int? MenuMappedId { get; set; }
        public int? DependencyType { get; set; }
        public decimal? Qty { get; set; }
    }
    class MenuMaster
    {

        public static DataTable menugroup;
        public static DataTable storegroup;
        public static DataTable menulist;
        // Information for store
        public static int storeid;
        public static string storename, printname, phone1, phone2, address;
        //
        public static DataTable MenuGropTitle;
        public static DataTable MenuDependency;

        public static void getMenuGroup()
        {
            try
            {
                List<pro_inventory_cat> Lst = new List<pro_inventory_cat>();
                Lst.Add(new pro_inventory_cat
                {
                    deleteflag = 0
                });

                MenuGropTitle = new DataTable();
                MenuGropTitle = Lst.ReturnRow();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }

        }
        public static void DataMenuDependency()
        {

            try
            {
                List<menu_items_dependency> lst = new List<menu_items_dependency>();
                MenuDependency = new DataTable();
                MenuDependency = lst.ReturnRow();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }

        public static void getStoreInfo()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("Select id,StoreName as Store,printname as PrintName,phone1 as 'Primary#',phone2 as 'Secondry#',address as Address from stores where deleteflag=0 order by StoreName", detail.con);
                storegroup = new DataTable();
                detail.con.Open();
                da.Fill(storegroup);
                detail.con.Close();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);

            }
        }


        public static void getmenugroup()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT pro_catagories.id,pro_catagories.name,pro_catagories.pro_inventory_cat_id,pro_inventory_cat.catname  FROM pro_catagories,pro_inventory_cat WHERE pro_catagories.deleteflag=0 AND pro_inventory_cat.id = pro_catagories.pro_inventory_cat_id ORDER BY pro_catagories.name", detail.con);
                menugroup = new DataTable();
                detail.con.Open();
                da.Fill(menugroup);
                detail.con.Close();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return;
            }
        }

        public static void getItemMenu()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(@"
SELECT menu_items.id,menu_items.menugroup,pro_catagories.pro_inventory_cat_id,
menu_items.code,menu_items.unit,Menu_Item_Detail.menu_item_id,menu_items.MenuName,
menu_items.printname,Menu_Item_Detail.storeid,Menu_Item_Detail.stock,Menu_Item_Detail.amount,
Menu_Item_Detail.tax,Menu_Item_Detail.sumAmu,Menu_Item_Detail.status,Menu_Item_Detail.indexcount,
Menu_Item_Detail.colorCode,menu_items.ForSale,stores.storename FROM menu_items,Menu_Item_Detail,pro_catagories,stores WHERE 
menu_items.deleteflag=0 AND menu_items.id =Menu_Item_Detail.Menu_Item_Id AND 
pro_catagories.id = menu_items.menugroup AND stores.id = Menu_Item_Detail.storeid ", detail.con);
                menulist = new DataTable();
                detail.con.Open();
                da.Fill(menulist);
                detail.con.Close();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
                return;
            }
        }

        public static void getInventoryStockEntry()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("Inventory_menu_map", detail.con);
                cmd.CommandType = CommandType.StoredProcedure;
                detail.con.Open();
                cmd.ExecuteNonQuery();
                detail.con.Close();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }


    }
}
