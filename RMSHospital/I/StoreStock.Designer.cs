namespace WindowsFormsApplication1.I
{
    partial class StoreStock
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
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.StoreGrid = new MetroFramework.Controls.MetroGrid();
            this.CmbCtegory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlStoreSide = new System.Windows.Forms.Panel();
            this.btnAddloose = new MetroFramework.Controls.MetroButton();
            this.btnWastage = new MetroFramework.Controls.MetroButton();
            this.btnTransfer = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGrid)).BeginInit();
            this.pnlStoreSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(74, 79);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(205, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Search";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(511, 118);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(89, 28);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Fetch";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // StoreGrid
            // 
            this.StoreGrid.AllowUserToResizeRows = false;
            this.StoreGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StoreGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StoreGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StoreGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoreGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StoreGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StoreGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.StoreGrid.EnableHeadersVisualStyles = false;
            this.StoreGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StoreGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StoreGrid.Location = new System.Drawing.Point(23, 152);
            this.StoreGrid.Name = "StoreGrid";
            this.StoreGrid.ReadOnly = true;
            this.StoreGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StoreGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StoreGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StoreGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StoreGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoreGrid.Size = new System.Drawing.Size(577, 315);
            this.StoreGrid.TabIndex = 5;
            this.StoreGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // CmbCtegory
            // 
            this.CmbCtegory.FormattingEnabled = true;
            this.CmbCtegory.ItemHeight = 23;
            this.CmbCtegory.Location = new System.Drawing.Point(389, 79);
            this.CmbCtegory.Name = "CmbCtegory";
            this.CmbCtegory.Size = new System.Drawing.Size(211, 29);
            this.CmbCtegory.TabIndex = 6;
            this.CmbCtegory.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(320, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Category";
            // 
            // pnlStoreSide
            // 
            this.pnlStoreSide.Controls.Add(this.btnTransfer);
            this.pnlStoreSide.Controls.Add(this.btnAddloose);
            this.pnlStoreSide.Controls.Add(this.btnWastage);
            this.pnlStoreSide.Location = new System.Drawing.Point(606, 152);
            this.pnlStoreSide.Name = "pnlStoreSide";
            this.pnlStoreSide.Size = new System.Drawing.Size(139, 315);
            this.pnlStoreSide.TabIndex = 8;
            // 
            // btnAddloose
            // 
            this.btnAddloose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddloose.Location = new System.Drawing.Point(7, 32);
            this.btnAddloose.Name = "btnAddloose";
            this.btnAddloose.Size = new System.Drawing.Size(116, 23);
            this.btnAddloose.TabIndex = 11;
            this.btnAddloose.Text = "Formula";
            this.btnAddloose.UseSelectable = true;
            this.btnAddloose.Click += new System.EventHandler(this.btnAddloose_Click_1);
            // 
            // btnWastage
            // 
            this.btnWastage.Location = new System.Drawing.Point(7, 3);
            this.btnWastage.Name = "btnWastage";
            this.btnWastage.Size = new System.Drawing.Size(116, 23);
            this.btnWastage.TabIndex = 10;
            this.btnWastage.Text = "Add to wastage";
            this.btnWastage.UseSelectable = true;
            this.btnWastage.Click += new System.EventHandler(this.btnWastage_Click_1);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTransfer.Location = new System.Drawing.Point(7, 61);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(116, 23);
            this.btnTransfer.TabIndex = 12;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseSelectable = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // StoreStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 490);
            this.Controls.Add(this.pnlStoreSide);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CmbCtegory);
            this.Controls.Add(this.StoreGrid);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StoreStock";
            this.Text = "StoreStock";
            this.Load += new System.EventHandler(this.StoreStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StoreGrid)).EndInit();
            this.pnlStoreSide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid StoreGrid;
        private MetroFramework.Controls.MetroComboBox CmbCtegory;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel pnlStoreSide;
        private MetroFramework.Controls.MetroButton btnAddloose;
        private MetroFramework.Controls.MetroButton btnWastage;
        private MetroFramework.Controls.MetroButton btnTransfer;
    }
}