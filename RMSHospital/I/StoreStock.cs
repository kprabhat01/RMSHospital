using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;
using WindowsFormsApplication1.P;

namespace WindowsFormsApplication1.I
{
    public partial class StoreStock : MetroFramework.Forms.MetroForm
    {
        private int StoreId { get; set; }
        private DataTable StoreStockData;

        public StoreStock()
        {
            SelectStore st = new SelectStore();
            st.ShowDialog();
            if (Stores.SelectedStoreid >= 1)
            {               
                InitializeComponent();
                StoreId = Stores.SelectedStoreid;
                this.Text = Stores.Selectedstorename;
            }
            else
            {
                Classes.messagemode.MetroMessageBox("Store has not been selected", this, false);
                this.Close();
            }
        }
        public StoreStock(int SStoreId, string SStoreName)
        {
            InitializeComponent();

            StoreId = SStoreId;
            this.Text = SStoreName;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        public StoreStock(int SStoreId, string SStoreName, bool ChangeEnable,string Query=null)
        {
            InitializeComponent();
            StoreId = SStoreId;
            this.Text = SStoreName;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.pnlStoreSide.Visible = ChangeEnable;
            if(Query!=null)
            {
                txtSearch.Text = Query;
                metroButton1.PerformClick();
                //metroButton1.Click();
                //metroButton1_Click(new object(), new EventArgs());
            }
        }

        private void SetStore()
        {
            try
            {
                CmbCtegory.DataSource = MenuMaster.MenuGropTitle;
                CmbCtegory.DisplayMember = "catname";
                CmbCtegory.ValueMember = "id";
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }

        }
        private void stock()
        {
            try
            {
                string Query = @"SELECT menu_items.id,menu_items.menuname AS Item,pro_catagories.name AS 'Sub-Categories',pro_inventory_cat.catname AS Categories,Menu_Item_Detail.stock AS Qty,unit.name AS Unit 
                        FROM unit, pro_inventory_cat, menu_items, pro_catagories, Menu_Item_Detail WHERE menu_items.id = Menu_Item_Detail.menu_item_id AND menu_items.unit = unit.id AND menu_items.deleteflag= 0
                        AND menu_items.menugroup = pro_catagories.id AND pro_catagories.pro_inventory_cat_id = pro_inventory_cat.id AND Menu_Item_Detail.storeid = " + Stores.SelectedStoreid + "";
                StoreStockData = new DataTable();
                StoreStockData = SqlHelper.ReturnRows(Query);
                SetDataTable();

            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }

        }
        private void SetDataTable()
        {
            try
            {
                StoreGrid.DataSource = StoreStockData;
                StoreGrid.Columns[0].Visible = false;
                StoreGrid.Columns[1].Width = 120;
                StoreGrid.AllowUserToAddRows = false;
                StoreGrid.ReadOnly = true;
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
        }
        private void StoreStock_Load(object sender, EventArgs e)
        {
            //if ()
            MenuMaster.getInventoryStockEntry();
            SetStore();
            stock();
            pnlStoreSide.Enabled = OpenDay.getstoreOpenlog(Stores.SelectedStoreid) ? true : false;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            StoreStockData.DefaultView.RowFilter = "Categories='" + CmbCtegory.Text + "' and Item like'%" + txtSearch.Text + "%'";
            SetDataTable();
        }

        private void btnWastage_Click_1(object sender, EventArgs e)
        {
            if (StoreGrid.SelectedRows.Count != 1)
            {
                messagemode.MetroMessageBox("Please select the individual Item", this, false);
            }
            else
            {
                FrmWastage Wtg = new FrmWastage(int.Parse(StoreGrid.SelectedRows[0].Cells[0].Value.ToString()), StoreGrid.SelectedRows[0].Cells[1].Value.ToString(), Stores.SelectedStoreid, StoreGrid.SelectedRows[0].Cells[5].Value.ToString());
                Wtg.ShowDialog();
                stock();
            }
        }

        private void btnAddloose_Click_1(object sender, EventArgs e)
        {
            if (StoreGrid.SelectedRows.Count != 1)
            {
                messagemode.MetroMessageBox("Please select the individual Item", this, false);
            }
            else
            {
                if (StoreGrid.SelectedRows[0].Cells["categories"].Value.ToString().ToLower().Equals("finished"))
                {
                    FrmDependency Dep = new FrmDependency(Stores.SelectedStoreid, int.Parse(StoreGrid.SelectedRows[0].Cells[0].Value.ToString()), StoreGrid.SelectedRows[0].Cells[1].Value.ToString(), StoreStockData);
                    Dep.ShowDialog();
                }
                else
                    messagemode.MetroMessageBox("Only 'Finished' product can be mapped.", this, false);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (OpenDay.getstoreOpenlog(StoreId))
            {
                I.SendRequisition Req = new I.SendRequisition(StoreId, this.Text);
                Req.ShowDialog();
            }
            else
                messagemode.messageget(false, "Day is not open for the selected store");
        }
    }
}
