namespace WindowsFormsApplication1.U
{
    partial class UChangePasscode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UChangePasscode));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.passcode = new MetroFramework.Controls.MetroTextBox();
            this.repasscode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnChangePasscode = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Change Password";
            // 
            // passcode
            // 
            // 
            // 
            // 
            this.passcode.CustomButton.Image = null;
            this.passcode.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.passcode.CustomButton.Name = "";
            this.passcode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passcode.CustomButton.TabIndex = 1;
            this.passcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passcode.CustomButton.UseSelectable = true;
            this.passcode.CustomButton.Visible = false;
            this.passcode.Lines = new string[0];
            this.passcode.Location = new System.Drawing.Point(23, 94);
            this.passcode.MaxLength = 32767;
            this.passcode.Name = "passcode";
            this.passcode.PasswordChar = '●';
            this.passcode.PromptText = "Password";
            this.passcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passcode.SelectedText = "";
            this.passcode.SelectionLength = 0;
            this.passcode.SelectionStart = 0;
            this.passcode.ShortcutsEnabled = true;
            this.passcode.Size = new System.Drawing.Size(264, 23);
            this.passcode.TabIndex = 1;
            this.passcode.UseSelectable = true;
            this.passcode.UseSystemPasswordChar = true;
            this.passcode.WaterMark = "Password";
            this.passcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // repasscode
            // 
            // 
            // 
            // 
            this.repasscode.CustomButton.Image = null;
            this.repasscode.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.repasscode.CustomButton.Name = "";
            this.repasscode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.repasscode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.repasscode.CustomButton.TabIndex = 1;
            this.repasscode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.repasscode.CustomButton.UseSelectable = true;
            this.repasscode.CustomButton.Visible = false;
            this.repasscode.Lines = new string[0];
            this.repasscode.Location = new System.Drawing.Point(23, 142);
            this.repasscode.MaxLength = 32767;
            this.repasscode.Name = "repasscode";
            this.repasscode.PasswordChar = '●';
            this.repasscode.PromptText = "Confirm Password";
            this.repasscode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.repasscode.SelectedText = "";
            this.repasscode.SelectionLength = 0;
            this.repasscode.SelectionStart = 0;
            this.repasscode.ShortcutsEnabled = true;
            this.repasscode.Size = new System.Drawing.Size(264, 23);
            this.repasscode.TabIndex = 3;
            this.repasscode.UseSelectable = true;
            this.repasscode.UseSystemPasswordChar = true;
            this.repasscode.WaterMark = "Confirm Password";
            this.repasscode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.repasscode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Confirm Password";
            // 
            // btnChangePasscode
            // 
            this.btnChangePasscode.Location = new System.Drawing.Point(191, 180);
            this.btnChangePasscode.Name = "btnChangePasscode";
            this.btnChangePasscode.Size = new System.Drawing.Size(96, 23);
            this.btnChangePasscode.TabIndex = 4;
            this.btnChangePasscode.Text = "Update";
            this.btnChangePasscode.UseSelectable = true;
            this.btnChangePasscode.Click += new System.EventHandler(this.btnChangePasscode_Click);
            // 
            // UChangePasscode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 240);
            this.Controls.Add(this.btnChangePasscode);
            this.Controls.Add(this.repasscode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.passcode);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UChangePasscode";
            this.Text = "UChangePasscode";
            this.Load += new System.EventHandler(this.UChangePasscode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox passcode;
        private MetroFramework.Controls.MetroTextBox repasscode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnChangePasscode;
    }
}