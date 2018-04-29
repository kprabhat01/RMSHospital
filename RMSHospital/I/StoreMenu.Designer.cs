namespace WindowsFormsApplication1.I
{
    partial class StoreMenu
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
            this.ToCmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.FrmCmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ToCmb
            // 
            this.ToCmb.FormattingEnabled = true;
            this.ToCmb.ItemHeight = 23;
            this.ToCmb.Location = new System.Drawing.Point(39, 150);
            this.ToCmb.Name = "ToCmb";
            this.ToCmb.Size = new System.Drawing.Size(309, 29);
            this.ToCmb.TabIndex = 0;
            this.ToCmb.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "From";
            // 
            // FrmCmb
            // 
            this.FrmCmb.FormattingEnabled = true;
            this.FrmCmb.ItemHeight = 23;
            this.FrmCmb.Location = new System.Drawing.Point(39, 82);
            this.FrmCmb.Name = "FrmCmb";
            this.FrmCmb.Size = new System.Drawing.Size(309, 29);
            this.FrmCmb.TabIndex = 2;
            this.FrmCmb.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "To";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(273, 194);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Copy";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(24, 256);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(324, 71);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "This option will remove all the available menu from selected store and Copy new m" +
    "enu item from mentioned one.";
            // 
            // StoreMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 343);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.FrmCmb);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ToCmb);
            this.Name = "StoreMenu";
            this.Text = "StoreMenu";
            this.Load += new System.EventHandler(this.StoreMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ToCmb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox FrmCmb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}