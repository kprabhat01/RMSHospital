namespace WindowsFormsApplication1.P
{
    partial class Transaction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Credit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BilledAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.RichTextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Returned = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.receivedAmu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tamount = new System.Windows.Forms.TextBox();
            this.paymentMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Credit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BilledAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.discount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comment);
            this.groupBox1.Controls.Add(this.Submit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Returned);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.receivedAmu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tamount);
            this.groupBox1.Location = new System.Drawing.Point(3, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Mode";
            // 
            // Credit
            // 
            this.Credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.Credit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Credit.ForeColor = System.Drawing.Color.White;
            this.Credit.Location = new System.Drawing.Point(298, 235);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(91, 23);
            this.Credit.TabIndex = 38;
            this.Credit.Text = "Credit (Ctrl+C)";
            this.Credit.UseVisualStyleBackColor = false;
            this.Credit.Click += new System.EventHandler(this.Credit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Billed Amount";
            // 
            // BilledAmount
            // 
            this.BilledAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BilledAmount.ForeColor = System.Drawing.Color.Lime;
            this.BilledAmount.Location = new System.Drawing.Point(298, 78);
            this.BilledAmount.Name = "BilledAmount";
            this.BilledAmount.ReadOnly = true;
            this.BilledAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BilledAmount.Size = new System.Drawing.Size(183, 20);
            this.BilledAmount.TabIndex = 2;
            this.BilledAmount.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Discount Amount";
            // 
            // discount
            // 
            this.discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.discount.ForeColor = System.Drawing.Color.Lime;
            this.discount.Location = new System.Drawing.Point(298, 49);
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discount.Size = new System.Drawing.Size(183, 20);
            this.discount.TabIndex = 1;
            this.discount.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Comment";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(298, 168);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(183, 54);
            this.comment.TabIndex = 5;
            this.comment.Text = "";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(200, 235);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(91, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit (F1)";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Refund Amount";
            // 
            // Returned
            // 
            this.Returned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Returned.ForeColor = System.Drawing.Color.Lime;
            this.Returned.Location = new System.Drawing.Point(298, 135);
            this.Returned.Name = "Returned";
            this.Returned.ReadOnly = true;
            this.Returned.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Returned.Size = new System.Drawing.Size(183, 20);
            this.Returned.TabIndex = 4;
            this.Returned.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cash Received";
            // 
            // receivedAmu
            // 
            this.receivedAmu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.receivedAmu.ForeColor = System.Drawing.Color.Lime;
            this.receivedAmu.Location = new System.Drawing.Point(298, 107);
            this.receivedAmu.Name = "receivedAmu";
            this.receivedAmu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.receivedAmu.Size = new System.Drawing.Size(183, 20);
            this.receivedAmu.TabIndex = 3;
            this.receivedAmu.Text = "0.00";
            this.receivedAmu.TextChanged += new System.EventHandler(this.receivedAmu_TextChanged);
            this.receivedAmu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.receivedAmu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Amount";
            // 
            // Tamount
            // 
            this.Tamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tamount.ForeColor = System.Drawing.Color.Lime;
            this.Tamount.Location = new System.Drawing.Point(298, 18);
            this.Tamount.Name = "Tamount";
            this.Tamount.ReadOnly = true;
            this.Tamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tamount.Size = new System.Drawing.Size(183, 20);
            this.Tamount.TabIndex = 0;
            this.Tamount.Text = "0.00";
            // 
            // paymentMode
            // 
            this.paymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMode.FormattingEnabled = true;
            this.paymentMode.Location = new System.Drawing.Point(363, 10);
            this.paymentMode.Name = "paymentMode";
            this.paymentMode.Size = new System.Drawing.Size(121, 21);
            this.paymentMode.TabIndex = 1;
            this.paymentMode.SelectedIndexChanged += new System.EventHandler(this.paymentMode_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Payment Mode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(329, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "F2";
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 315);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.paymentMode);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Transaction_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Tamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Returned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox receivedAmu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox comment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BilledAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.ComboBox paymentMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Credit;
    }
}