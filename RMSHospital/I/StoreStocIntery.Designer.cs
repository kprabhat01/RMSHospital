namespace WindowsFormsApplication1.I
{
    partial class StoreStocIntery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SumAmount = new System.Windows.Forms.TextBox();
            this.stk = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemListDetail = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proname = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBillNo = new MetroFramework.Controls.MetroTextBox();
            this.vendors = new MetroFramework.Controls.MetroTextBox();
            this.Storename = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Store";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(255, 42);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(26, 23);
            this.select.TabIndex = 2;
            this.select.Text = "..";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SumAmount);
            this.panel1.Controls.Add(this.stk);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 334);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total ";
            // 
            // SumAmount
            // 
            this.SumAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumAmount.Location = new System.Drawing.Point(548, 269);
            this.SumAmount.Name = "SumAmount";
            this.SumAmount.ReadOnly = true;
            this.SumAmount.Size = new System.Drawing.Size(142, 20);
            this.SumAmount.TabIndex = 9;
            this.SumAmount.Text = "0.00";
            this.SumAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stk
            // 
            this.stk.AutoSize = true;
            this.stk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stk.ForeColor = System.Drawing.Color.Maroon;
            this.stk.Location = new System.Drawing.Point(3, 312);
            this.stk.Name = "stk";
            this.stk.Size = new System.Drawing.Size(11, 13);
            this.stk.TabIndex = 8;
            this.stk.Text = ".";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(522, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(609, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(687, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ItemListDetail);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.qty);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 47);
            this.panel2.TabIndex = 8;
            // 
            // ItemListDetail
            // 
            this.ItemListDetail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemListDetail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemListDetail.FormattingEnabled = true;
            this.ItemListDetail.Location = new System.Drawing.Point(6, 21);
            this.ItemListDetail.Name = "ItemListDetail";
            this.ItemListDetail.Size = new System.Drawing.Size(412, 23);
            this.ItemListDetail.TabIndex = 1;
            this.ItemListDetail.SelectedIndexChanged += new System.EventHandler(this.ItemListDetail_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(603, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "+ Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Purchase Rate";
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(490, 21);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(104, 23);
            this.rate.TabIndex = 3;
            this.rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Qty";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(427, 21);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(51, 23);
            this.qty.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Name";
            // 
            // proname
            // 
            this.proname.Location = new System.Drawing.Point(341, 83);
            this.proname.Name = "proname";
            this.proname.Size = new System.Drawing.Size(49, 25);
            this.proname.TabIndex = 13;
            this.proname.TextChanged += new System.EventHandler(this.proname_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "..";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vendor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bill No";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBillNo);
            this.groupBox1.Controls.Add(this.vendors);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.Storename);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.proname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.select);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.CustomButton.Image = null;
            this.txtBillNo.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.txtBillNo.CustomButton.Name = "";
            this.txtBillNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBillNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBillNo.CustomButton.TabIndex = 1;
            this.txtBillNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBillNo.CustomButton.UseSelectable = true;
            this.txtBillNo.CustomButton.Visible = false;
            this.txtBillNo.Lines = new string[0];
            this.txtBillNo.Location = new System.Drawing.Point(9, 123);
            this.txtBillNo.MaxLength = 40;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.PasswordChar = '\0';
            this.txtBillNo.PromptText = "Invoice Number";
            this.txtBillNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillNo.SelectedText = "";
            this.txtBillNo.SelectionLength = 0;
            this.txtBillNo.SelectionStart = 0;
            this.txtBillNo.ShortcutsEnabled = true;
            this.txtBillNo.Size = new System.Drawing.Size(243, 23);
            this.txtBillNo.TabIndex = 17;
            this.txtBillNo.UseSelectable = true;
            this.txtBillNo.WaterMark = "Invoice Number";
            this.txtBillNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBillNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // vendors
            // 
            // 
            // 
            // 
            this.vendors.CustomButton.Image = null;
            this.vendors.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.vendors.CustomButton.Name = "";
            this.vendors.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.vendors.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.vendors.CustomButton.TabIndex = 1;
            this.vendors.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vendors.CustomButton.UseSelectable = true;
            this.vendors.CustomButton.Visible = false;
            this.vendors.Lines = new string[0];
            this.vendors.Location = new System.Drawing.Point(9, 81);
            this.vendors.MaxLength = 32767;
            this.vendors.Name = "vendors";
            this.vendors.PasswordChar = '\0';
            this.vendors.PromptText = "Select Vendors";
            this.vendors.ReadOnly = true;
            this.vendors.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vendors.SelectedText = "";
            this.vendors.SelectionLength = 0;
            this.vendors.SelectionStart = 0;
            this.vendors.ShortcutsEnabled = true;
            this.vendors.Size = new System.Drawing.Size(240, 23);
            this.vendors.TabIndex = 4;
            this.vendors.UseSelectable = true;
            this.vendors.WaterMark = "Select Vendors";
            this.vendors.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.vendors.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.vendors.TextChanged += new System.EventHandler(this.vendors_TextChanged);
            this.vendors.Click += new System.EventHandler(this.vendors_Click);
            // 
            // Storename
            // 
            // 
            // 
            // 
            this.Storename.CustomButton.Image = null;
            this.Storename.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.Storename.CustomButton.Name = "";
            this.Storename.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Storename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Storename.CustomButton.TabIndex = 1;
            this.Storename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Storename.CustomButton.UseSelectable = true;
            this.Storename.CustomButton.Visible = false;
            this.Storename.Lines = new string[0];
            this.Storename.Location = new System.Drawing.Point(10, 42);
            this.Storename.MaxLength = 32767;
            this.Storename.Name = "Storename";
            this.Storename.PasswordChar = '\0';
            this.Storename.PromptText = "Select Store/Outlet";
            this.Storename.ReadOnly = true;
            this.Storename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Storename.SelectedText = "";
            this.Storename.SelectionLength = 0;
            this.Storename.SelectionStart = 0;
            this.Storename.ShortcutsEnabled = true;
            this.Storename.Size = new System.Drawing.Size(239, 23);
            this.Storename.TabIndex = 5;
            this.Storename.UseSelectable = true;
            this.Storename.WaterMark = "Select Store/Outlet";
            this.Storename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Storename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Storename.TextChanged += new System.EventHandler(this.Storename_TextChanged);
            this.Storename.Click += new System.EventHandler(this.Storename_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(546, 144);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(95, 65);
            this.metroTile1.TabIndex = 17;
            this.metroTile1.Text = "New Item";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // StoreStocIntery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 612);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StoreStocIntery";
            this.Text = "StoreStocIntery";
            this.Load += new System.EventHandler(this.StoreStocIntery_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StoreStocIntery_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StoreStocIntery_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proname;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label stk;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ItemListDetail;
        private System.Windows.Forms.TextBox SumAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox Storename;
        private MetroFramework.Controls.MetroTextBox txtBillNo;
        private MetroFramework.Controls.MetroTextBox vendors;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}