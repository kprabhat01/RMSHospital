using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1.I
{
    public partial class FrmDependency : MetroFramework.Forms.MetroForm
    {
        private int FrmMenuId { get; set; }
        private string FrmMenuName { get; set; }
        private int FrmStoreId { get; set; }
        private string selectionId { get; set; }
        private DataTable StoreMenu;
        private DataTable DependencyMenu;


        public FrmDependency(int Istore, int ImenuID, string MenuName, DataTable IstoreMenu)
        {
            InitializeComponent();
            FrmStoreId = Istore;
            FrmMenuName = MenuName;
            this.Text = FrmMenuName;
            FrmMenuId = ImenuID;
            StoreMenu = new DataTable();
            IstoreMenu.DefaultView.RowFilter = "";
            StoreMenu = IstoreMenu;
        }
        void GetSavedMenuDependency()
        {
            try
            {
                int? DependncyId = cmbDependency.Text.ToLower().Equals("to loose") ? 1 : cmbDependency.Text.ToLower().Equals("to sell") ? 0 : -10;
                DataRow[] SelectedRow = MenuMaster.MenuDependency.Select("StoreID = " + FrmStoreId + " and MenuMappedId = " + FrmMenuId + " and DependencyType=" + DependncyId + "");
                foreach (DataRow Dr in SelectedRow)
                    DependencyMenu.Rows.Add(int.Parse(Dr["MenuMappedId"].ToString()), MenuMaster.menulist.Select("menu_item_id = " + Dr["MenuId"].ToString() + " and storeid=" + FrmStoreId + "")[0]["MenuName"].ToString(), Dr["Qty"].ToString());
                getData();
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }

        }

        private void FrmDependency_Load(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
            // StoreMenu.DefaultView.RowFilter = "id != " + FrmMenuId + "";
            StoreMenu.DefaultView.Sort = "Item asc";
            cmbItemName.DataSource = StoreMenu;
            cmbItemName.DisplayMember = "Item";
            cmbItemName.ValueMember = "id";
            DependencyMenu = new DataTable();
            DependencyMenu.Columns.Add("MenuId", typeof(int));
            DependencyMenu.Columns.Add("MenuName", typeof(string));
            DependencyMenu.Columns.Add("Qty", typeof(string));



            gridProduct.DataSource = DependencyMenu;
            getData();
        }

        private void gridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void getData()
        {
            gridProduct.DataSource = DependencyMenu;
            gridProduct.Columns[0].Visible = false;
            gridProduct.Columns[1].Width = 250;
            gridProduct.AllowUserToAddRows = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                float.Parse(txtQty.Text);
                int.Parse(cmbItemName.SelectedValue.ToString());
            }
            catch (Exception)
            {
                messagemode.MetroMessageBox("Selected Item OR 'Qty' in proper format.", this, false);
                return;
            }
            if (cmbDependency.Text.Length >= 1)
            {
                if (!cmbItemName.SelectedValue.ToString().Equals(FrmMenuId))
                {
                    selectionId = radioButton1.Checked ? "+" : radioButton2.Checked ? "-" : "";
                    if (selectionId.Length > 0)
                    {
                        DependencyMenu.Rows.Add(cmbItemName.SelectedValue.ToString(), cmbItemName.Text, selectionId + txtQty.Text);
                        getData();
                    }
                    else
                        messagemode.MetroMessageBox("Please select the Formula code.", this, false);
                }
                else
                    messagemode.MetroMessageBox("Same product can't be mapped with the dependency, It will have deduction on individual basis.", this, false);
            }
            else
                messagemode.MetroMessageBox("Please select Dependency type", this, false);
        }

        private void cmbDependency_SelectedIndexChanged(object sender, EventArgs e)
        {
            DependencyMenu.Clear();
            GetSavedMenuDependency();

        }

        private void gridProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataRow Dr in DependencyMenu.Rows)
                {
                    if (Dr[0].ToString().Equals(gridProduct.SelectedRows[0].Cells[0].ToString()) && Dr[1].ToString().Equals(gridProduct.SelectedRows[0].Cells[1].ToString()) && Dr[2].ToString().Equals(gridProduct.SelectedRows[0].Cells[2].ToString()))
                    {
                        Dr.Delete();
                        break;
                    }
                    getData();
                }
            }
        }

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblUnit.Text = StoreMenu.Select("id=" + cmbItemName.SelectedValue.ToString() + "")[0]["unit"].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDependency.Text.Length >= 1 && cmbItemName.Text.Length >= 1)
                {
                    if (gridProduct.Rows.Count >= 1)
                    {
                        List<menu_items_dependency> lst = new List<menu_items_dependency>();
                        int? DependncyId = cmbDependency.Text.ToLower().Equals("to loose") ? 1 : cmbDependency.Text.ToLower().Equals("to sell") ? 0 : -10;
                        lst.Add(new menu_items_dependency
                        {
                            MenuMappedId = FrmMenuId,
                            StoreID = FrmStoreId,
                            DependencyType = DependncyId

                        });
                        if (lst.DeleteChanges())
                        {
                            lst.Clear();
                            foreach (DataRow dr in DependencyMenu.Rows)
                            {
                                lst.Add(new menu_items_dependency
                                {
                                    MenuMappedId = FrmMenuId,
                                    MenuID = int.Parse(dr["MenuId"].ToString()),
                                    Qty = decimal.Parse(dr["Qty"].ToString()),
                                    DependencyType = cmbDependency.Text.ToLower().Equals("to loose") ? 1 : cmbDependency.Text.ToLower().Equals("to sell") ? 0 : -1,
                                    StoreID = FrmStoreId
                                });
                            }
                            if (lst.SaveChanges())
                            {
                                messagemode.MetroMessageBox("Dependency has been saved. Please restart the application in order to make an effect.", this, true);
                                MenuMaster.DataMenuDependency();
                            }
                            else
                                messagemode.MetroMessageBox("Error while saving dependency.", this, false);
                            this.Close();
                        }
                        else
                            messagemode.MetroMessageBox("Error while saving dependency.Please contact administrator.", this, false);
                    }
                    else
                        messagemode.MetroMessageBox("No Item found to be mapped.", this, false);
                }
                else
                    messagemode.MetroMessageBox("Store or depenedcy type yet to be selected.", this, false);
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
    }
}
