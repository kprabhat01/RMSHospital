using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1.P
{
    public partial class POSOrder : UserControl
    {
        private string StoreName { get; set; }
        private int StoreId { get; set; }
        public POSOrder()
        {
            try
            {
                StoreName store = new StoreName();
                store.ShowDialog();
                if (Classes.Stores.Selectedstorename != string.Empty)
                {
                    StoreId = Classes.Stores.SelectedStoreid;
                    InitializeComponent();
                    lblStore.Text = Classes.Stores.Selectedstorename;
                }
                else
                    throw new Exception("Store is not selected.");
                List<string> Lst = new List<string>();
                Lst.Add("Vikarm");
                Lst.Add("Sanjay ");
                Lst.Add("Rajesh");

                lstBill.View = View.Details;
                lstBill.GridLines = true;
                lstBill.FullRowSelect = true;
                
                //lstBill.layou
                lstBill.Columns.Add("Title", 300, HorizontalAlignment.Left);
                lstBill.Columns.Add("ID", 70, HorizontalAlignment.Left);
                lstBill.Columns.Add("Price", 70, HorizontalAlignment.Left);
                lstBill.Columns.Add("Publi-Date", 100, HorizontalAlignment.Left);
               



            }
            catch (Exception)
            {
                this.Visible = false;
            }
        }


        private void POSOrder_Load(object sender, EventArgs e)
        {
            this.Size = new Size(FrmHelper.FrmWidth,FrmHelper.Frmheight);
            
           
        }

        private void pnlCategory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
