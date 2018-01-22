using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.Classes
{
    class MenuMaster
    {

        public static DataTable menugroup;
        public static DataTable storegroup;
        public static DataTable menulist;


        // Information for store
        public static int storeid;
        public static string storename,printname,phone1,phone2,address;


        //


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
                MySqlDataAdapter da = new MySqlDataAdapter("select * from pro_catagories where deleteflag=0 order by name",detail.con);
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM menu_items WHERE deleteflag=0",detail.con);
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


    }
}
