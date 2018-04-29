namespace WindowsFormsApplication1.A
{
    partial class AcEntry
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
            this.rdDebit = new MetroFramework.Controls.MetroRadioButton();
            this.rdCredit = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtComment = new MetroFramework.Controls.MetroTextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbPayment = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // rdDebit
            // 
            this.rdDebit.AutoSize = true;
            this.rdDebit.Location = new System.Drawing.Point(55, 112);
            this.rdDebit.Name = "rdDebit";
            this.rdDebit.Size = new System.Drawing.Size(51, 15);
            this.rdDebit.TabIndex = 0;
            this.rdDebit.Text = "Debit";
            this.rdDebit.UseSelectable = true;
            // 
            // rdCredit
            // 
            this.rdCredit.AutoSize = true;
            this.rdCredit.Location = new System.Drawing.Point(125, 112);
            this.rdCredit.Name = "rdCredit";
            this.rdCredit.Size = new System.Drawing.Size(55, 15);
            this.rdCredit.TabIndex = 1;
            this.rdCredit.Text = "Credit";
            this.rdCredit.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Transaction Type";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 193);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Amount";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(55, 215);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PromptText = "0.00";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(125, 23);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMark = "0.00";
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.Click += new System.EventHandler(this.txtAmount_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 251);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Comment";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // txtComment
            // 
            // 
            // 
            // 
            this.txtComment.CustomButton.Image = null;
            this.txtComment.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.txtComment.CustomButton.Name = "";
            this.txtComment.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.txtComment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComment.CustomButton.TabIndex = 1;
            this.txtComment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComment.CustomButton.UseSelectable = true;
            this.txtComment.CustomButton.Visible = false;
            this.txtComment.Lines = new string[0];
            this.txtComment.Location = new System.Drawing.Point(55, 273);
            this.txtComment.MaxLength = 32767;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PromptText = "Please enter comment";
            this.txtComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComment.SelectedText = "";
            this.txtComment.SelectionLength = 0;
            this.txtComment.SelectionStart = 0;
            this.txtComment.ShortcutsEnabled = true;
            this.txtComment.Size = new System.Drawing.Size(356, 73);
            this.txtComment.TabIndex = 6;
            this.txtComment.UseSelectable = true;
            this.txtComment.WaterMark = "Please enter comment";
            this.txtComment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtComment.Click += new System.EventHandler(this.txtComment_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(330, 361);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(81, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(23, 130);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Payment Mode";
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.ItemHeight = 23;
            this.cmbPayment.Location = new System.Drawing.Point(55, 152);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(125, 29);
            this.cmbPayment.TabIndex = 9;
            this.cmbPayment.UseSelectable = true;
            // 
            // AcEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 435);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.rdCredit);
            this.Controls.Add(this.rdDebit);
            this.Name = "AcEntry";
            this.Text = "AcEntry";
            this.Load += new System.EventHandler(this.AcEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton rdDebit;
        private MetroFramework.Controls.MetroRadioButton rdCredit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtComment;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbPayment;
    }
}