namespace WindowsFormsApplication1.Cus
{
    partial class Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ph1 = new System.Windows.Forms.MaskedTextBox();
            this.ph2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.RichTextBox();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name*";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(12, 38);
            this.fname.MaxLength = 50;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(196, 20);
            this.fname.TabIndex = 1;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(12, 77);
            this.lname.MaxLength = 50;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(196, 20);
            this.lname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone#*";
            // 
            // ph1
            // 
            this.ph1.Location = new System.Drawing.Point(15, 116);
            this.ph1.Mask = "000-000-0000";
            this.ph1.Name = "ph1";
            this.ph1.Size = new System.Drawing.Size(193, 20);
            this.ph1.TabIndex = 5;
            // 
            // ph2
            // 
            this.ph2.Location = new System.Drawing.Point(15, 155);
            this.ph2.Mask = "000-000-0000";
            this.ph2.Name = "ph2";
            this.ph2.Size = new System.Drawing.Size(193, 20);
            this.ph2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alternet Phone#";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(12, 194);
            this.line1.MaxLength = 75;
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(196, 20);
            this.line1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address Line 1";
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(12, 233);
            this.line2.MaxLength = 75;
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(196, 20);
            this.line2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address Line 2";
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(12, 272);
            this.line3.MaxLength = 75;
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(196, 20);
            this.line3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address Line 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comment";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(12, 311);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(196, 55);
            this.comment.TabIndex = 15;
            this.comment.Text = "";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(66, 377);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(81, 23);
            this.Update.TabIndex = 22;
            this.Update.Text = "Save";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 412);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ph2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ph1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ph1;
        private System.Windows.Forms.MaskedTextBox ph2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox line1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox line2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox line3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox comment;
        private System.Windows.Forms.Button Update;
    }
}