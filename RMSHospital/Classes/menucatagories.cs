using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class menucatagories
    {
        public static DataTable pro_catdata;

        public static void getprodata()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM pro_catagories",detail.con);
                pro_catdata= new DataTable();
                detail.con.Open();
                da.Fill(pro_catdata);
                detail.con.Close();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);

            }
        
        }



    }
}
