using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApplication1.Classes
{
    static class UnitHelper
    {
        public static void BindDataToComboBox(this ComboBox Cmd, DataTable dt, string DisplayMember, string ValueMember)
        {
            try
            {
                Cmd.DataSource = dt;
                Cmd.DisplayMember = DisplayMember;
                Cmd.ValueMember = ValueMember;
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
        public static bool InsertUnit(string name)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Insert into unit (name) values(?name)", detail.con))
                {
                    cmd.Parameters.Add("?name", MySqlDbType.VarChar).Value = name;
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

        public static bool CheckUnitMark(int UnitId)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("select Id from inventory_items where units=" + UnitId + "", detail.con))
                {
                    detail.con.Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        detail.con.Close();
                        return true;
                    }
                    else
                    {
                        detail.con.Close();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
                return false;
            }
        }
        public static bool DelUnit(int unitID)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Update unit set deleteflag=1 where id=" + unitID + "", detail.con))
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

        public static DataTable getUnits()
        {
            DataTable dt = new DataTable();
            try
            {

                using (MySqlCommand cmd = new MySqlCommand("select * from unit where deleteflag=0 order by name", detail.con))
                {
                    detail.con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                        dt.Load(dr);

                    detail.con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return dt;
        }

    }
}
