namespace WindowsFormsApplication1.I
{
    partial class SendRequisition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ProductList = new MetroFramework.Controls.MetroGrid();
            this.Save = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Qty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.storename = new MetroFramework.Controls.MetroComboBox();
            this.CmbItemName = new System.Windows.Forms.ComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "To Store";
            // 
            // ProductList
            // 
            this.ProductList.AllowUserToResizeRows = false;
            this.ProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductList.DefaultCellStyle = dataGridViewCellStyle11;
            this.ProductList.EnableHeadersVisualStyles = false;
            this.ProductList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductList.Location = new System.Drawing.Point(7, 190);
            this.ProductList.Name = "ProductList";
            this.ProductList.ReadOnly = true;
            this.ProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.ProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductList.Size = new System.Drawing.Size(601, 306);
            this.ProductList.TabIndex = 2;
            this.ProductList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductList_KeyDown);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(527, 502);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(81, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseSelectable = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Item name";
            // 
            // Qty
            // 
            // 
            // 
            // 
            this.Qty.CustomButton.Image = null;
            this.Qty.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.Qty.CustomButton.Name = "";
            this.Qty.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.Qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Qty.CustomButton.TabIndex = 1;
            this.Qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Qty.CustomButton.UseSelectable = true;
            this.Qty.CustomButton.Visible = false;
            this.Qty.Lines = new string[0];
            this.Qty.Location = new System.Drawing.Point(306, 154);
            this.Qty.MaxLength = 5;
            this.Qty.Name = "Qty";
            this.Qty.PasswordChar = '\0';
            this.Qty.PromptText = "Qty";
            this.Qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Qty.SelectedText = "";
            this.Qty.SelectionLength = 0;
            this.Qty.SelectionStart = 0;
            this.Qty.ShortcutsEnabled = false;
            this.Qty.Size = new System.Drawing.Size(91, 21);
            this.Qty.TabIndex = 1;
            this.Qty.UseSelectable = true;
            this.Qty.WaterMark = "Qty";
            this.Qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Red;
            this.metroLabel3.Location = new System.Drawing.Point(23, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(410, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "This option will trasfer the amount of Stock Quanity to selected store.";
            // 
            // storename
            // 
            this.storename.FormattingEnabled = true;
            this.storename.ItemHeight = 23;
            this.storename.Location = new System.Drawing.Point(72, 103);
            this.storename.Name = "storename";
            this.storename.Size = new System.Drawing.Size(293, 29);
            this.storename.TabIndex = 1;
            this.storename.UseSelectable = true;
            this.storename.SelectedIndexChanged += new System.EventHandler(this.storename_SelectedIndexChanged);
            // 
            // CmbItemName
            // 
            this.CmbItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbItemName.FormattingEnabled = true;
            this.CmbItemName.Location = new System.Drawing.Point(7, 154);
            this.CmbItemName.Name = "CmbItemName";
            this.CmbItemName.Size = new System.Drawing.Size(293, 21);
            this.CmbItemName.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(403, 152);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "+ Add";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // SendRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 539);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.CmbItemName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.storename);
            this.Controls.Add(this.metroLabel1);
            this.Name = "SendRequisition";
            this.Text = "SendRequisition";
            this.Load += new System.EventHandler(this.SendRequisition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid ProductList;
        private MetroFramework.Controls.MetroButton Save;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox Qty;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox storename;
        private System.Windows.Forms.ComboBox CmbItemName;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}