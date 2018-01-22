using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.M
{
    public partial class MenuCatagories : Form
    {
        public MenuCatagories()
        {
            InitializeComponent();
        }
        protected void getmenulist()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Classes.writeme.errorname(ex);
            }
        }

        private void MenuCatagories_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }
    }
}
