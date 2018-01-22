using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class SqlHelper
    {

        public static void singltonclass()
        {
            MenuMaster.getmenugroup();
            MenuMaster.getStoreInfo();
            MenuMaster.getItemMenu();
            Tables.gettablelist();
            vendors.vendorslist();
            Inventory.getUnits();
            Inventory.getCat();
            Items.getItems();
            Customer.getCustomerdetail();
            Taxes.getTextInfo();
            OrderMode.getPayments();
            OrderMode.getOrderMode();

        }

        public static DataTable ReturnRows(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, detail.con))
                {
                    detail.con.Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                        dt.Load(rd);

                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
            return dt;
        }

        // This not for the paramtries function and can only used for the single query for the class useonly . 

        public static bool InsertInfo(string query)
        {

            try
            {

                using (MySqlCommand cmd = new MySqlCommand(query, detail.con))
                {
                    cmd.CommandTimeout = 250;
                    detail.con.Open();

                    cmd.ExecuteNonQuery();
                    detail.con.Close();

                    return true;
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);

                return false;
            }
        }


    }
}
