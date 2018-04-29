using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.I
{
    public partial class StoreMenu : MetroFramework.Forms.MetroForm
    {
        private int StoreId { get; set; }
        private string StoreName { get; set; }
        public StoreMenu(int stid, string stName)
        {
            InitializeComponent();
            this.Text = "Copy Store Menu";
            StoreId = stid;
            StoreName = stName;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void StoreMenu_Load(object sender, EventArgs e)
        {
            FrmCmb.Items.Add(StoreName);
            FrmCmb.SelectedIndex = 0;
            FrmCmb.Enabled = false;

            ToCmb.DataSource = Classes.MenuMaster.storegroup;
            ToCmb.ValueMember = "id";
            ToCmb.DisplayMember = "Store";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (ToCmb.Items.Count >= 1)
            {
                if (!ToCmb.SelectedValue.ToString().Equals(StoreId.ToString()))
                {
                    try
                    {
                        if (Classes.messagemode.confirm("Are you sure to copy ?"))
                        {
                            MySqlCommand Cmd = new MySqlCommand("Copy_StoreMenu", detail.con);
                            Cmd.Parameters.AddWithValue("FromStoreID", StoreId);
                            Cmd.Parameters.AddWithValue("ToStoreId", int.Parse(ToCmb.SelectedValue.ToString()));
                            Cmd.CommandType = CommandType.StoredProcedure;
                            detail.con.Open();
                            Cmd.ExecuteNonQuery();
                            detail.con.Close();
                            Classes.messagemode.MetroMessageBox("Menu has been successfully copy. \n Please logout and login back for the change to be effected.", this, true);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Classes.messagemode.MetroMessageBox("Error while copy menu", this, false);
                    }
                    finally
                    {
                        if (detail.con.State == ConnectionState.Open)
                            detail.con.Close();
                    }
                }
                else
                    Classes.messagemode.MetroMessageBox("Destination to copy the menu should not be same", this, false);
            }
        }
    }
}
