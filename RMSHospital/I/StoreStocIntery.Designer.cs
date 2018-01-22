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
            this.Storename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stk = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.vendors = new System.Windows.Forms.TextBox();
            this.SumAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Storename
            // 
            this.Storename.Location = new System.Drawing.Point(12, 21);
            this.Storename.Name = "Storename";
            this.Storename.ReadOnly = true;
            this.Storename.Size = new System.Drawing.Size(216, 20);
            this.Storename.TabIndex = 0;
            this.Storename.TextChanged += new System.EventHandler(this.Storename_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Store";
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(234, 19);
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
            this.panel1.Location = new System.Drawing.Point(12, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 334);
            this.panel1.TabIndex = 3;
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
            this.button4.Location = new System.Drawing.Point(342, 307);
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
            this.button1.Location = new System.Drawing.Point(429, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(507, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Date.Location = new System.Drawing.Point(386, 33);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(11, 13);
            this.Date.TabIndex = 4;
            this.Date.Text = ".";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(409, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "New Item";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 47);
            this.panel2.TabIndex = 8;
            // 
            // ItemListDetail
            // 
            this.ItemListDetail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemListDetail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemListDetail.FormattingEnabled = true;
            this.ItemListDetail.Location = new System.Drawing.Point(6, 18);
            this.ItemListDetail.Name = "ItemListDetail";
            this.ItemListDetail.Size = new System.Drawing.Size(207, 21);
            this.ItemListDetail.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(397, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "+ Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rate";
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(287, 21);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(104, 20);
            this.rate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Qty";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(222, 21);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(51, 20);
            this.qty.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Name";
            // 
            // proname
            // 
            this.proname.Location = new System.Drawing.Point(277, 61);
            this.proname.Name = "proname";
            this.proname.Size = new System.Drawing.Size(49, 20);
            this.proname.TabIndex = 13;
            this.proname.TextChanged += new System.EventHandler(this.proname_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(234, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "..";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vendor";
            // 
            // vendors
            // 
            this.vendors.Location = new System.Drawing.Point(12, 60);
            this.vendors.Name = "vendors";
            this.vendors.ReadOnly = true;
            this.vendors.Size = new System.Drawing.Size(216, 20);
            this.vendors.TabIndex = 9;
            this.vendors.TextChanged += new System.EventHandler(this.vendors_TextChanged);
            // 
            // SumAmount
            // 
            this.SumAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumAmount.Location = new System.Drawing.Point(410, 273);
            this.SumAmount.Name = "SumAmount";
            this.SumAmount.ReadOnly = true;
            this.SumAmount.Size = new System.Drawing.Size(100, 20);
            this.SumAmount.TabIndex = 9;
            this.SumAmount.Text = "0.00";
            this.SumAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total ";
            // 
            // StoreStocIntery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 496);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vendors);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.proname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Storename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StoreStocIntery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreStocIntery";
            this.Load += new System.EventHandler(this.StoreStocIntery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Storename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.TextBox vendors;
        private System.Windows.Forms.ComboBox ItemListDetail;
        private System.Windows.Forms.TextBox SumAmount;
        private System.Windows.Forms.Label label6;
    }
}