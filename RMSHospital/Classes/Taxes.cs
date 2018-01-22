using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class Taxes
    {
        public static DataTable TaxInfo;

        public static void getTextInfo()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("select id, concat(taxname,'(',TaxPer,'%)') as taxname,taxname as tax,TaxPer from tax_detail order by taxname", detail.con))
                {
                    TaxInfo = new DataTable();
                    detail.con.Open();
                    da.Fill(TaxInfo);
                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
        public static bool InsertTax(string taxname, float tax)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Insert into tax_detail(taxname,taxper) values(?taxname," + tax + ")", detail.con))
                {
                    cmd.Parameters.Add("?taxname", MySqlDbType.VarChar).Value = taxname;
                    detail.con.Open();
                    cmd.ExecuteNonQuery();
                    detail.con.Close();
                    return true;
                }

            }
            catch (Exception e)
            {
                writeme.errorname(e);
                return false;
            }
        }

        public static bool Del_Tax(int taxid)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Delete from tax_detail where id=" + taxid + " limit 1", detail.con))
                {
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
