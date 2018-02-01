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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM menu_items WHERE deleteflag=0", detail.con);
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
                MySqlCommand cmd = new MySqlCommand("Inventory_menu_map",detail.con);
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
