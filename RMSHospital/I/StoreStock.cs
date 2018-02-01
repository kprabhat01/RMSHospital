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

namespace WindowsFormsApplication1.I
{
    public partial class StoreStock : MetroFramework.Forms.MetroForm
    {
        private int StoreId { get; set; }
        
        public StoreStock(int SStoreId, string SStoreName)
        {
            InitializeComponent();

            StoreId = SStoreId;
            this.Text = SStoreName;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
                string Query = @"SELECT menu_items.id,menu_items.menuname AS Item,pro_catagories.name AS 'Sub-Categories',pro_inventory_cat.catname AS Categories,inven_Stock.stock AS Qty,unit.name AS Unit 
                        FROM unit, pro_inventory_cat, menu_items, pro_catagories, inven_Stock WHERE menu_items.id = inven_Stock.menu_item_id AND menu_items.unit = unit.id AND menu_items.deleteflag= 0
                        AND menu_items.menugroup = pro_catagories.id AND pro_catagories.pro_inventory_cat_id = pro_inventory_cat.id AND menu_items.storeid = " + StoreId + "";
                StoreGrid.DataSource = SqlHelper.ReturnRows(Query);
                StoreGrid.Columns[0].Visible = false;
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
            MenuMaster.getInventoryStockEntry();
            SetStore();
            stock();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
