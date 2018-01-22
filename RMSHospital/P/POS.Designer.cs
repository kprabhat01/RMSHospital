namespace WindowsFormsApplication1.P
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.MenuItem = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.placeorder = new System.Windows.Forms.Button();
            this.Comment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.storename = new System.Windows.Forms.Label();
            this.LiveOrder = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tempmenu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.amu = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tables = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Clr = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.leftpanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiveOrder)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempmenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.MenuItem);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(291, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 525);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(115, 441);
            this.panel5.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(119, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(582, 100);
            this.panel8.TabIndex = 2;
            // 
            // MenuItem
            // 
            this.MenuItem.AutoScroll = true;
            this.MenuItem.Location = new System.Drawing.Point(119, 0);
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(585, 441);
            this.MenuItem.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.cancel);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.close);
            this.panel4.Controls.Add(this.placeorder);
            this.panel4.Controls.Add(this.Comment);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(925, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 522);
            this.panel4.TabIndex = 0;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(3, 231);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 61);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Olive;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 61);
            this.button4.TabIndex = 6;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 61);
            this.button3.TabIndex = 5;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(66)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(3, 176);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(94, 61);
            this.close.TabIndex = 4;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // placeorder
            // 
            this.placeorder.BackColor = System.Drawing.Color.Green;
            this.placeorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeorder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeorder.ForeColor = System.Drawing.Color.White;
            this.placeorder.Location = new System.Drawing.Point(3, 405);
            this.placeorder.Name = "placeorder";
            this.placeorder.Size = new System.Drawing.Size(94, 61);
            this.placeorder.TabIndex = 3;
            this.placeorder.Text = "Place Order";
            this.placeorder.UseVisualStyleBackColor = false;
            this.placeorder.Click += new System.EventHandler(this.placeorder_Click);
            // 
            // Comment
            // 
            this.Comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(66)))));
            this.Comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Comment.ForeColor = System.Drawing.Color.White;
            this.Comment.Location = new System.Drawing.Point(3, 116);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(94, 61);
            this.Comment.TabIndex = 2;
            this.Comment.Text = "Comment";
            this.Comment.UseVisualStyleBackColor = false;
            this.Comment.Click += new System.EventHandler(this.Comment_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(66)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Store";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(66)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Order History";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // leftpanel
            // 
            this.leftpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.leftpanel.BackColor = System.Drawing.Color.White;
            this.leftpanel.Controls.Add(this.panel7);
            this.leftpanel.Controls.Add(this.LiveOrder);
            this.leftpanel.Controls.Add(this.panel3);
            this.leftpanel.Controls.Add(this.tempmenu);
            this.leftpanel.Controls.Add(this.panel1);
            this.leftpanel.Location = new System.Drawing.Point(1, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(285, 573);
            this.leftpanel.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Maroon;
            this.panel7.Controls.Add(this.storename);
            this.panel7.Location = new System.Drawing.Point(0, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(285, 27);
            this.panel7.TabIndex = 4;
            // 
            // storename
            // 
            this.storename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.storename.AutoSize = true;
            this.storename.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storename.ForeColor = System.Drawing.Color.Yellow;
            this.storename.Location = new System.Drawing.Point(100, 7);
            this.storename.Name = "storename";
            this.storename.Size = new System.Drawing.Size(0, 16);
            this.storename.TabIndex = 1;
            // 
            // LiveOrder
            // 
            this.LiveOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LiveOrder.Location = new System.Drawing.Point(2, 383);
            this.LiveOrder.Name = "LiveOrder";
            this.LiveOrder.ReadOnly = true;
            this.LiveOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LiveOrder.Size = new System.Drawing.Size(283, 190);
            this.LiveOrder.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 20);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(109, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // tempmenu
            // 
            this.tempmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tempmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tempmenu.Location = new System.Drawing.Point(1, 78);
            this.tempmenu.Name = "tempmenu";
            this.tempmenu.ReadOnly = true;
            this.tempmenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tempmenu.Size = new System.Drawing.Size(283, 364);
            this.tempmenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.amu);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 48);
            this.panel1.TabIndex = 0;
            // 
            // amu
            // 
            this.amu.AutoSize = true;
            this.amu.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.amu.Location = new System.Drawing.Point(27, 9);
            this.amu.Name = "amu";
            this.amu.Size = new System.Drawing.Size(65, 25);
            this.amu.TabIndex = 1;
            this.amu.Text = "0.00";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.ForeColor = System.Drawing.Color.Lime;
            this.Price.Location = new System.Drawing.Point(3, 19);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(25, 13);
            this.Price.TabIndex = 0;
            this.Price.Text = "Rs.";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.tables);
            this.panel6.Controls.Add(this.Delete);
            this.panel6.Controls.Add(this.Clr);
            this.panel6.Controls.Add(this.but1);
            this.panel6.Controls.Add(this.but2);
            this.panel6.Controls.Add(this.but3);
            this.panel6.Controls.Add(this.but8);
            this.panel6.Controls.Add(this.but7);
            this.panel6.Controls.Add(this.but6);
            this.panel6.Controls.Add(this.but4);
            this.panel6.Controls.Add(this.but5);
            this.panel6.Controls.Add(this.but9);
            this.panel6.Controls.Add(this.but0);
            this.panel6.Location = new System.Drawing.Point(290, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1026, 48);
            this.panel6.TabIndex = 3;
            // 
            // tables
            // 
            this.tables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tables.BackColor = System.Drawing.Color.Maroon;
            this.tables.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables.ForeColor = System.Drawing.Color.White;
            this.tables.Location = new System.Drawing.Point(66, -1);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(159, 48);
            this.tables.TabIndex = 12;
            this.tables.UseVisualStyleBackColor = false;
            this.tables.Click += new System.EventHandler(this.tables_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Delete.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(225, -1);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(76, 48);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Del";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clr
            // 
            this.Clr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clr.BackColor = System.Drawing.Color.Maroon;
            this.Clr.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clr.ForeColor = System.Drawing.Color.White;
            this.Clr.Location = new System.Drawing.Point(300, -1);
            this.Clr.Name = "Clr";
            this.Clr.Size = new System.Drawing.Size(76, 48);
            this.Clr.TabIndex = 10;
            this.Clr.Text = "Clear";
            this.Clr.UseVisualStyleBackColor = false;
            this.Clr.Click += new System.EventHandler(this.Clr_Click);
            // 
            // but1
            // 
            this.but1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.Location = new System.Drawing.Point(374, -1);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(66, 48);
            this.but1.TabIndex = 9;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // but2
            // 
            this.but2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but2.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.Location = new System.Drawing.Point(439, -1);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(66, 48);
            this.but2.TabIndex = 8;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but3
            // 
            this.but3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but3.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.Location = new System.Drawing.Point(504, -1);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(66, 48);
            this.but3.TabIndex = 7;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // but8
            // 
            this.but8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but8.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but8.Location = new System.Drawing.Point(829, -1);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(66, 48);
            this.but8.TabIndex = 6;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.but8_Click);
            // 
            // but7
            // 
            this.but7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but7.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but7.Location = new System.Drawing.Point(764, -1);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(66, 48);
            this.but7.TabIndex = 5;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.but7_Click);
            // 
            // but6
            // 
            this.but6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but6.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but6.Location = new System.Drawing.Point(699, -1);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(66, 48);
            this.but6.TabIndex = 4;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.but6_Click);
            // 
            // but4
            // 
            this.but4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but4.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but4.Location = new System.Drawing.Point(569, -1);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(66, 48);
            this.but4.TabIndex = 3;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.button5_Click);
            // 
            // but5
            // 
            this.but5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but5.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but5.Location = new System.Drawing.Point(634, -1);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(66, 48);
            this.but5.TabIndex = 2;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but5_Click);
            // 
            // but9
            // 
            this.but9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but9.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but9.Location = new System.Drawing.Point(894, -1);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(66, 48);
            this.but9.TabIndex = 1;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.but9_Click);
            // 
            // but0
            // 
            this.but0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but0.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but0.Location = new System.Drawing.Point(959, -1);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(66, 48);
            this.but0.TabIndex = 0;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.but0_Click);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 572);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POS_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.leftpanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiveOrder)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempmenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label amu;
        private System.Windows.Forms.DataGridView tempmenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView LiveOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label storename;
        private System.Windows.Forms.Button Clr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel MenuItem;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Comment;
        private System.Windows.Forms.Button placeorder;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button tables;
    }
}