using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.P
{
    public partial class NewStore : Form
    {
        public NewStore()
        {
            InitializeComponent();
        }
        private void getStoreInfomration()
        {
            if (Classes.MenuMaster.storeid >= 1)
            {
                storename.Text = Classes.MenuMaster.storename;
                printname.Text = Classes.MenuMaster.printname;
                ppno.Text = Classes.MenuMaster.phone1;
                spno.Text = Classes.MenuMaster.phone2;
                address.Text = Classes.MenuMaster.address;

            }
        }

        private void NewStore_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            getStoreInfomration();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (storename.Text.Length == 0 || printname.Text.Length == 0)
            {
                Classes.messagemode.messageget(false, "Please enter store name and print name");
                return;
            }
            else
            {
                if (Classes.MenuMaster.storeid == 0)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("Insert into stores (storeName,printname,phone1,phone2,address) values (?storeName,?printname,'" + ppno.Text + "','" + spno.Text + "',?address)",detail.con);
                        cmd.Parameters.Add("?storeName", MySqlDbType.VarChar).Value = storename.Text;
                        cmd.Parameters.Add("?printname", MySqlDbType.VarChar).Value = printname.Text;
                        cmd.Parameters.Add("?address", MySqlDbType.VarChar).Value = address.Text;
                        detail.con.Open();
                        cmd.ExecuteNonQuery();
                        detail.con.Close();
                        Classes.MenuMaster.getmenugroup();
                        Classes.messagemode.messageget(true, "Successfully stored");                        
                        ppno.Text = "";
                        storename.Text = "";
                        printname.Text = "";
                        address.Text = "";
                        spno.Text = "";

                    }
                    catch (Exception ex)
                    {
                        Classes.writeme.errorname(ex);
                        return;
                    }

                }
                else if (Classes.MenuMaster.storeid >= 1)
               {
                   if (Classes.messagemode.confirm("Are you sure to update the store?"))
                   {
                       try
                       {
                           MySqlCommand cmd = new MySqlCommand("Update stores set storeName=?storeName,printname=?printname,phone1='" + ppno.Text + "',phone2='" + spno.Text + "',address=?address where id=" + Classes.MenuMaster.storeid + "",detail.con);
                           cmd.Parameters.Add("?storeName", MySqlDbType.VarChar).Value = storename.Text;
                           cmd.Parameters.Add("?printname", MySqlDbType.VarChar).Value = printname.Text;
                           cmd.Parameters.Add("?address", MySqlDbType.VarChar).Value = address.Text;
                           detail.con.Open();
                           cmd.ExecuteNonQuery();
                           detail.con.Close();
                           Classes.MenuMaster.getmenugroup();
                           Classes.messagemode.messageget(true, "Successfully stored");
                       }
                       catch (Exception ex)
                       {
                           Classes.writeme.errorname(ex);
                           return;
                       }
                   }
                }
            }
        }
    }
}
