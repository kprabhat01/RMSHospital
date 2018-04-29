namespace WindowsFormsApplication1.P
{
    partial class OrderBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemName = new System.Windows.Forms.TextBox();
            this.Qtn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuGridview = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalSumDisplay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TblNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.taxamu = new System.Windows.Forms.TextBox();
            this.totalamu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OrderMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToLooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disamu = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.printbill = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CmbAttendent = new System.Windows.Forms.ComboBox();
            this.PanelAttendent = new System.Windows.Forms.Panel();
            this.OrderTemp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PanelAttendent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(8, 99);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(195, 20);
            this.ItemName.TabIndex = 5;
            this.ItemName.TextChanged += new System.EventHandler(this.ItemName_TextChanged);
            this.ItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemName_KeyDown);
            // 
            // Qtn
            // 
            this.Qtn.Location = new System.Drawing.Point(207, 99);
            this.Qtn.Name = "Qtn";
            this.Qtn.Size = new System.Drawing.Size(63, 20);
            this.Qtn.TabIndex = 2;
            this.Qtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Qtn_KeyDown);
            this.Qtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qtn_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qty";
            // 
            // MenuGridview
            // 
            this.MenuGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuGridview.Location = new System.Drawing.Point(8, 125);
            this.MenuGridview.Name = "MenuGridview";
            this.MenuGridview.ReadOnly = true;
            this.MenuGridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MenuGridview.Size = new System.Drawing.Size(300, 300);
            this.MenuGridview.TabIndex = 4;
            this.MenuGridview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuGridview_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TotalSumDisplay);
            this.panel1.Location = new System.Drawing.Point(357, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 52);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // TotalSumDisplay
            // 
            this.TotalSumDisplay.AutoSize = true;
            this.TotalSumDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSumDisplay.ForeColor = System.Drawing.Color.Lime;
            this.TotalSumDisplay.Location = new System.Drawing.Point(3, 20);
            this.TotalSumDisplay.Name = "TotalSumDisplay";
            this.TotalSumDisplay.Size = new System.Drawing.Size(58, 25);
            this.TotalSumDisplay.TabIndex = 7;
            this.TotalSumDisplay.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TNO.";
            // 
            // TblNo
            // 
            this.TblNo.FormattingEnabled = true;
            this.TblNo.Location = new System.Drawing.Point(8, 59);
            this.TblNo.MaxLength = 10;
            this.TblNo.Name = "TblNo";
            this.TblNo.Size = new System.Drawing.Size(87, 21);
            this.TblNo.TabIndex = 0;
            this.TblNo.SelectedIndexChanged += new System.EventHandler(this.TblNo_SelectedIndexChanged);
            this.TblNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TblNo_KeyDown);
            this.TblNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TblNo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(32, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "(F2)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(60, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "(F3)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Orders";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(389, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "(F1)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(456, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tax";
            // 
            // taxamu
            // 
            this.taxamu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taxamu.ForeColor = System.Drawing.Color.Lime;
            this.taxamu.Location = new System.Drawing.Point(357, 440);
            this.taxamu.Name = "taxamu";
            this.taxamu.ReadOnly = true;
            this.taxamu.Size = new System.Drawing.Size(127, 20);
            this.taxamu.TabIndex = 15;
            this.taxamu.Text = "0.00";
            this.taxamu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalamu
            // 
            this.totalamu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalamu.ForeColor = System.Drawing.Color.Lime;
            this.totalamu.Location = new System.Drawing.Point(490, 440);
            this.totalamu.Name = "totalamu";
            this.totalamu.ReadOnly = true;
            this.totalamu.Size = new System.Drawing.Size(146, 20);
            this.totalamu.TabIndex = 17;
            this.totalamu.Text = "0.00";
            this.totalamu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(600, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Total";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(217, 461);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "F9 Cash Pay";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(217, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Expenses";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OrderMode
            // 
            this.OrderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderMode.FormattingEnabled = true;
            this.OrderMode.Location = new System.Drawing.Point(570, 103);
            this.OrderMode.Name = "OrderMode";
            this.OrderMode.Size = new System.Drawing.Size(130, 21);
            this.OrderMode.TabIndex = 32;
            this.OrderMode.SelectedIndexChanged += new System.EventHandler(this.OrderMode_SelectedIndexChanged);
            this.OrderMode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderMode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Order Mode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(541, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "(F4)";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(706, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Customer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(570, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(226, 65);
            this.richTextBox1.TabIndex = 36;
            this.richTextBox1.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(524, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Address";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageOrdersToolStripMenuItem,
            this.addToLooseToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // manageOrdersToolStripMenuItem
            // 
            this.manageOrdersToolStripMenuItem.Name = "manageOrdersToolStripMenuItem";
            this.manageOrdersToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.manageOrdersToolStripMenuItem.Text = "Manage Orders";
            this.manageOrdersToolStripMenuItem.Click += new System.EventHandler(this.manageOrdersToolStripMenuItem_Click);
            // 
            // addToLooseToolStripMenuItem
            // 
            this.addToLooseToolStripMenuItem.Name = "addToLooseToolStripMenuItem";
            this.addToLooseToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addToLooseToolStripMenuItem.Text = "Add To Loose (Ctrl + L)";
            this.addToLooseToolStripMenuItem.Click += new System.EventHandler(this.addToLooseToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // currentStockToolStripMenuItem
            // 
            this.currentStockToolStripMenuItem.Name = "currentStockToolStripMenuItem";
            this.currentStockToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.currentStockToolStripMenuItem.Text = "Current Stock (Ctrl+C)";
            this.currentStockToolStripMenuItem.Click += new System.EventHandler(this.currentStockToolStripMenuItem_Click_1);
            // 
            // disamu
            // 
            this.disamu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.disamu.ForeColor = System.Drawing.Color.Lime;
            this.disamu.Location = new System.Drawing.Point(642, 440);
            this.disamu.Name = "disamu";
            this.disamu.Size = new System.Drawing.Size(146, 20);
            this.disamu.TabIndex = 40;
            this.disamu.Text = "0.00";
            this.disamu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(712, 428);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(57, 13);
            this.Discount.TabIndex = 39;
            this.Discount.Text = "Discount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(763, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "(F12)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(276, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printbill
            // 
            this.printbill.AutoSize = true;
            this.printbill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.printbill.Location = new System.Drawing.Point(140, 465);
            this.printbill.Name = "printbill";
            this.printbill.Size = new System.Drawing.Size(63, 17);
            this.printbill.TabIndex = 44;
            this.printbill.Text = "Print Bill";
            this.printbill.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Attendant(F5)";
            // 
            // CmbAttendent
            // 
            this.CmbAttendent.FormattingEnabled = true;
            this.CmbAttendent.Location = new System.Drawing.Point(84, 4);
            this.CmbAttendent.Name = "CmbAttendent";
            this.CmbAttendent.Size = new System.Drawing.Size(115, 21);
            this.CmbAttendent.TabIndex = 46;
            // 
            // PanelAttendent
            // 
            this.PanelAttendent.Controls.Add(this.CmbAttendent);
            this.PanelAttendent.Controls.Add(this.label15);
            this.PanelAttendent.Location = new System.Drawing.Point(4, 483);
            this.PanelAttendent.Name = "PanelAttendent";
            this.PanelAttendent.Size = new System.Drawing.Size(203, 29);
            this.PanelAttendent.TabIndex = 47;
            // 
            // OrderTemp
            // 
            this.OrderTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderTemp.Location = new System.Drawing.Point(358, 130);
            this.OrderTemp.Name = "OrderTemp";
            this.OrderTemp.ReadOnly = true;
            this.OrderTemp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrderTemp.Size = new System.Drawing.Size(438, 295);
            this.OrderTemp.TabIndex = 48;
            // 
            // OrderBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.OrderTemp);
            this.Controls.Add(this.printbill);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.disamu);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderMode);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.totalamu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.taxamu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TblNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuGridview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Qtn);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PanelAttendent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Box";
            this.Load += new System.EventHandler(this.OrderBox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderBox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MenuGridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelAttendent.ResumeLayout(false);
            this.PanelAttendent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox Qtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MenuGridview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalSumDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TblNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox taxamu;
        private System.Windows.Forms.TextBox totalamu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox OrderMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOrdersToolStripMenuItem;
        private System.Windows.Forms.TextBox disamu;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox printbill;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CmbAttendent;
        private System.Windows.Forms.Panel PanelAttendent;
        private System.Windows.Forms.ToolStripMenuItem addToLooseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentStockToolStripMenuItem;
        private System.Windows.Forms.DataGridView OrderTemp;
    }
}