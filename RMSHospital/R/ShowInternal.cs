using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1.R
{
    public partial class ShowInternal : Form
    {
        private int? OrderId { get; set; }
        public ShowInternal()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        void getUpdatedBill()
        {
            webBrowser1.Url = new Uri(Classes.PrintReport.filedetail);
        }
        private void ShowInternal_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            getUpdatedBill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Classes.PrintReport.printfile(Classes.PrintReport.filedetail);
            OrderId = OrderMode.SelectedOrderId;
            printDocument1.Print();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Classes.OrderMode.GetLastOrderID(Classes.OrderMode.SelectedOrderId, true);
            Classes.PrintReport.printbill(Classes.OrderMode.SelectedOrderId);
            getUpdatedBill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.OrderMode.GetLastOrderID(Classes.OrderMode.SelectedOrderId, false);
            Classes.PrintReport.printbill(Classes.OrderMode.SelectedOrderId);
            getUpdatedBill();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (OrderId != null)
                {
                    DataTable dtdetail = PrintReport.getStore(OrderId);
                    DataTable menuitem = PrintReport.getOrderItems(OrderId);
                    DataTable taxses = PrintReport.getTaxInfo(OrderId);
                    Graphics graphics = e.Graphics;

                    Font font10 = new Font("Arial", 8);
                    Font font12 = new Font("Arial", 8);
                    Font font14 = new Font("Arial", 10, FontStyle.Bold);

                    float leading = 4;
                    float lineheight10 = font10.GetHeight() + leading;
                    float lineheight12 = font12.GetHeight() + leading;
                    float lineheight14 = font14.GetHeight() + leading;

                    float startX = 0;
                    float startY = leading;
                    float Offset = 0;

                    StringFormat formatLeft = new StringFormat(StringFormatFlags.NoClip);
                    StringFormat formatCenter = new StringFormat(formatLeft);
                    StringFormat formatRight = new StringFormat(formatLeft);

                    formatCenter.Alignment = StringAlignment.Center;
                    formatRight.Alignment = StringAlignment.Far;
                    formatLeft.Alignment = StringAlignment.Near;

                    SizeF layoutSize = new SizeF(270 - Offset * 2, lineheight14);
                    RectangleF layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

                    Brush brush = Brushes.Black;
                    graphics.DrawString(dtdetail.Rows[0]["printname"].ToString(), font14, brush, layout, formatCenter);
                    Offset = Offset + lineheight14;
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

                    graphics.DrawString("Receipt No :" + OrderId, font14, brush, layout, formatLeft);
                    Offset = Offset + lineheight14;
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

                    graphics.DrawString("Date :" + DateTime.Parse(dtdetail.Rows[0]["orderdatetime"].ToString()).ToString("dd MMM yyyy HH:mm"), font12, brush, layout, formatLeft);
                    Offset = Offset + lineheight12;
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

                    graphics.DrawString("Table No :" + dtdetail.Rows[0]["tableid"].ToString(), font12, brush, layout, formatLeft);
                    Offset = Offset + lineheight12;
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

                    graphics.DrawString("Attendent :" + dtdetail.Rows[0]["AttenName"].ToString(), font12, brush, layout, formatLeft);
                    Offset = Offset + lineheight12;
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                    graphics.DrawString("Customer :", font12, brush, layout, formatLeft);
                    Offset = Offset + lineheight12;
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                    if (dtdetail.Rows[0]["Add_Comment"].ToString().Length >= 1)
                    {
                        graphics.DrawString(dtdetail.Rows[0]["Add_Comment"].ToString(), font12, brush, layout, formatLeft);
                        Offset = Offset + lineheight12;
                        layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                    }
                    graphics.DrawString("".PadRight(84, '.'), font10, brush, layout, formatLeft);
                    Offset = Offset + lineheight10;
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                    graphics.DrawString("Item Name".PadLeft(4), font10, brush, layout, formatLeft);
                    graphics.DrawString("Qty".PadLeft(4), font10, brush, layout, formatCenter);
                    graphics.DrawString("Price".PadLeft(4), font10, brush, layout, formatRight);
                    Offset = Offset + lineheight12;
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                    graphics.DrawString("".PadRight(84, '.'), font10, brush, layout, formatLeft);
                    Offset = Offset + lineheight10;
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                    for (int i = 0; i < menuitem.Rows.Count; i++)
                    {
                        layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                        graphics.DrawString(menuitem.Rows[i][0].ToString().PadLeft(4), font10, brush, layout, formatLeft);
                        graphics.DrawString(menuitem.Rows[i][1].ToString().PadLeft(4), font10, brush, layout, formatCenter);
                        graphics.DrawString(menuitem.Rows[i][2].ToString().PadLeft(30), font10, brush, layout, formatRight);
                        Offset = Offset + lineheight10;
                    }
                    Offset = Offset + lineheight10;
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                    graphics.DrawString("".PadRight(84, '.'), font10, brush, layout, formatLeft);
                    Offset = Offset + lineheight10;
                    foreach (DataRow taxRow in taxses.Rows)
                    {
                        layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                        graphics.DrawString(taxRow["taxname"].ToString().PadLeft(4), font10, brush, layout, formatCenter);
                        graphics.DrawString(taxRow["Amount"].ToString().PadLeft(4), font10, brush, layout, formatRight);
                        Offset = Offset + lineheight10;
                    }
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                    graphics.DrawString("Total".PadLeft(4), font14, brush, layout, formatCenter);
                    graphics.DrawString(dtdetail.Rows[0]["PaidAmu"].ToString().PadLeft(4), font14, brush, layout, formatRight);
                    Offset = Offset + lineheight10;
                    layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
                    graphics.DrawString("".PadRight(20, '*'), font10, brush, layout, formatLeft);
                    graphics.DrawString("Thankyou".PadRight(30), font10, brush, layout, formatCenter);
                    graphics.DrawString("".PadRight(20, '*'), font10, brush, layout, formatRight);
                    font10.Dispose(); font12.Dispose(); font14.Dispose();

                }
            }
            catch (Exception ex)
            {
                writeme.errorname(ex);
            }
            finally
            {
                OrderId = null;
            }
        }
    }
}
