namespace WindowsFormsApplication1.P
{
    partial class MenuItems
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItems));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orderby = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Bcost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tcost = new System.Windows.Forms.TextBox();
            this.colorcode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mnubut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menulist = new System.Windows.Forms.TreeView();
            this.New = new System.Windows.Forms.RadioButton();
            this.Update = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CmbProductType = new MetroFramework.Controls.MetroComboBox();
            this.groupname = new MetroFramework.Controls.MetroComboBox();
            this.menuname = new MetroFramework.Controls.MetroTextBox();
            this.Code = new MetroFramework.Controls.MetroTextBox();
            this.CmbUnit = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSale = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderby)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menu Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menu Code*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(484, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Type";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Maroon;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(69, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non Veg";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(17, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Veg";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Menu Group*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Series*";
            // 
            // orderby
            // 
            this.orderby.Location = new System.Drawing.Point(487, 328);
            this.orderby.Name = "orderby";
            this.orderby.Size = new System.Drawing.Size(120, 21);
            this.orderby.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(484, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 47);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Maroon;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(81, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "InActive";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(17, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Active";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Bcost
            // 
            this.Bcost.Location = new System.Drawing.Point(484, 473);
            this.Bcost.MaxLength = 16;
            this.Bcost.Name = "Bcost";
            this.Bcost.Size = new System.Drawing.Size(100, 21);
            this.Bcost.TabIndex = 10;
            this.Bcost.Text = "0.00";
            this.Bcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Bcost.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Basic(Rs)*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(484, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tax(Rs)*";
            // 
            // Tcost
            // 
            this.Tcost.Location = new System.Drawing.Point(484, 514);
            this.Tcost.MaxLength = 16;
            this.Tcost.Name = "Tcost";
            this.Tcost.Size = new System.Drawing.Size(100, 21);
            this.Tcost.TabIndex = 11;
            this.Tcost.Text = "0.00";
            this.Tcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tcost.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // colorcode
            // 
            this.colorcode.Location = new System.Drawing.Point(610, 327);
            this.colorcode.Name = "colorcode";
            this.colorcode.ReadOnly = true;
            this.colorcode.Size = new System.Drawing.Size(100, 21);
            this.colorcode.TabIndex = 16;
            this.colorcode.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mnubut
            // 
            this.mnubut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnubut.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnubut.ForeColor = System.Drawing.Color.Yellow;
            this.mnubut.Location = new System.Drawing.Point(631, 457);
            this.mnubut.Name = "mnubut";
            this.mnubut.Size = new System.Drawing.Size(113, 78);
            this.mnubut.TabIndex = 18;
            this.mnubut.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(565, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(5, 611);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(88, 611);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menulist
            // 
            this.menulist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menulist.Location = new System.Drawing.Point(8, 87);
            this.menulist.Name = "menulist";
            this.menulist.Size = new System.Drawing.Size(467, 518);
            this.menulist.TabIndex = 23;
            // 
            // New
            // 
            this.New.AutoSize = true;
            this.New.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(640, 27);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(49, 19);
            this.New.TabIndex = 24;
            this.New.TabStop = true;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.CheckedChanged += new System.EventHandler(this.New_CheckedChanged);
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.Enabled = false;
            this.Update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(695, 27);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(63, 19);
            this.Update.TabIndex = 25;
            this.Update.TabStop = true;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.CheckedChanged += new System.EventHandler(this.Update_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(175, 611);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 23);
            this.button7.TabIndex = 28;
            this.button7.Text = "+Categories";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Product Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(484, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Unit";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_drop_down_16__1_;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(276, 611);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 23);
            this.button8.TabIndex = 34;
            this.button8.Text = "StoreStock ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Category");
            this.imageList1.Images.SetKeyName(1, "food");
            this.imageList1.Images.SetKeyName(2, "Item");
            // 
            // CmbProductType
            // 
            this.CmbProductType.FormattingEnabled = true;
            this.CmbProductType.ItemHeight = 23;
            this.CmbProductType.Location = new System.Drawing.Point(487, 232);
            this.CmbProductType.Name = "CmbProductType";
            this.CmbProductType.Size = new System.Drawing.Size(260, 29);
            this.CmbProductType.TabIndex = 4;
            this.CmbProductType.UseSelectable = true;
            this.CmbProductType.SelectedIndexChanged += new System.EventHandler(this.CmbProductType_SelectedIndexChanged_1);
            // 
            // groupname
            // 
            this.groupname.FormattingEnabled = true;
            this.groupname.ItemHeight = 23;
            this.groupname.Location = new System.Drawing.Point(487, 280);
            this.groupname.Name = "groupname";
            this.groupname.Size = new System.Drawing.Size(260, 29);
            this.groupname.TabIndex = 5;
            this.groupname.UseSelectable = true;
            // 
            // menuname
            // 
            // 
            // 
            // 
            this.menuname.CustomButton.Image = null;
            this.menuname.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.menuname.CustomButton.Name = "";
            this.menuname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.menuname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.menuname.CustomButton.TabIndex = 1;
            this.menuname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menuname.CustomButton.UseSelectable = true;
            this.menuname.CustomButton.Visible = false;
            this.menuname.Lines = new string[0];
            this.menuname.Location = new System.Drawing.Point(487, 84);
            this.menuname.MaxLength = 50;
            this.menuname.Name = "menuname";
            this.menuname.PasswordChar = '\0';
            this.menuname.PromptText = "Item Name *";
            this.menuname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.menuname.SelectedText = "";
            this.menuname.SelectionLength = 0;
            this.menuname.SelectionStart = 0;
            this.menuname.ShortcutsEnabled = true;
            this.menuname.Size = new System.Drawing.Size(257, 29);
            this.menuname.TabIndex = 0;
            this.menuname.UseSelectable = true;
            this.menuname.WaterMark = "Item Name *";
            this.menuname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.menuname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.menuname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Code
            // 
            // 
            // 
            // 
            this.Code.CustomButton.Image = null;
            this.Code.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.Code.CustomButton.Name = "";
            this.Code.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Code.CustomButton.TabIndex = 1;
            this.Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Code.CustomButton.UseSelectable = true;
            this.Code.CustomButton.Visible = false;
            this.Code.Lines = new string[0];
            this.Code.Location = new System.Drawing.Point(487, 130);
            this.Code.MaxLength = 16;
            this.Code.Name = "Code";
            this.Code.PasswordChar = '\0';
            this.Code.PromptText = "Print Name *";
            this.Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Code.SelectedText = "";
            this.Code.SelectionLength = 0;
            this.Code.SelectionStart = 0;
            this.Code.ShortcutsEnabled = true;
            this.Code.Size = new System.Drawing.Size(257, 29);
            this.Code.TabIndex = 1;
            this.Code.UseSelectable = true;
            this.Code.WaterMark = "Print Name *";
            this.Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CmbUnit
            // 
            this.CmbUnit.FormattingEnabled = true;
            this.CmbUnit.ItemHeight = 23;
            this.CmbUnit.Location = new System.Drawing.Point(487, 369);
            this.CmbUnit.Name = "CmbUnit";
            this.CmbUnit.Size = new System.Drawing.Size(257, 29);
            this.CmbUnit.TabIndex = 8;
            this.CmbUnit.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSale);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(484, 541);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 47);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sales Properties";
            // 
            // chkSale
            // 
            this.chkSale.AutoSize = true;
            this.chkSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkSale.ForeColor = System.Drawing.Color.White;
            this.chkSale.Location = new System.Drawing.Point(17, 20);
            this.chkSale.Name = "chkSale";
            this.chkSale.Size = new System.Drawing.Size(73, 17);
            this.chkSale.TabIndex = 12;
            this.chkSale.Text = "For Sale";
            this.chkSale.UseVisualStyleBackColor = false;
            this.chkSale.CheckedChanged += new System.EventHandler(this.chkSale_CheckedChanged);
            // 
            // MenuItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 638);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CmbUnit);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.menuname);
            this.Controls.Add(this.groupname);
            this.Controls.Add(this.CmbProductType);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.New);
            this.Controls.Add(this.menulist);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mnubut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tcost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Bcost);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.orderby);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuItems";
            this.Text = "MenuItems";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuItems_FormClosing);
            this.Load += new System.EventHandler(this.MenuItems_Load);
            this.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderby)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown orderby;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox Bcost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tcost;
        private System.Windows.Forms.TextBox colorcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mnubut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TreeView menulist;
        private System.Windows.Forms.RadioButton New;
        private System.Windows.Forms.RadioButton Update;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroComboBox CmbProductType;
        private MetroFramework.Controls.MetroComboBox groupname;
        private MetroFramework.Controls.MetroTextBox menuname;
        private MetroFramework.Controls.MetroTextBox Code;
        private MetroFramework.Controls.MetroComboBox CmbUnit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSale;
    }
}