namespace WindowsFormsApplication1.Cus
{
    partial class CustomerAccount
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
            this.Update = new System.Windows.Forms.Button();
            this.amu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Debit = new System.Windows.Forms.TextBox();
            this.credit = new System.Windows.Forms.TextBox();
            this.Due = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paycate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.paycate);
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.amu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Comment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debit Account";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(151, 204);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(81, 23);
            this.Update.TabIndex = 23;
            this.Update.Text = "Submit";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // amu
            // 
            this.amu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amu.Location = new System.Drawing.Point(9, 180);
            this.amu.Name = "amu";
            this.amu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amu.Size = new System.Drawing.Size(109, 20);
            this.amu.TabIndex = 3;
            this.amu.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(9, 42);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(223, 74);
            this.Comment.TabIndex = 1;
            this.Comment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(557, 365);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Debit
            // 
            this.Debit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debit.ForeColor = System.Drawing.Color.Green;
            this.Debit.Location = new System.Drawing.Point(598, 395);
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            this.Debit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Debit.Size = new System.Drawing.Size(109, 20);
            this.Debit.TabIndex = 4;
            this.Debit.Text = "0.00";
            // 
            // credit
            // 
            this.credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.Color.Red;
            this.credit.Location = new System.Drawing.Point(710, 395);
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            this.credit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.credit.Size = new System.Drawing.Size(109, 20);
            this.credit.TabIndex = 5;
            this.credit.Text = "0.00";
            // 
            // Due
            // 
            this.Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Due.ForeColor = System.Drawing.Color.Red;
            this.Due.Location = new System.Drawing.Point(650, 421);
            this.Due.Name = "Due";
            this.Due.ReadOnly = true;
            this.Due.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Due.Size = new System.Drawing.Size(169, 20);
            this.Due.TabIndex = 6;
            this.Due.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Balance";
            // 
            // paycate
            // 
            this.paycate.FormattingEnabled = true;
            this.paycate.Items.AddRange(new object[] {
            "Deposit",
            "Balance"});
            this.paycate.Location = new System.Drawing.Point(9, 140);
            this.paycate.Name = "paycate";
            this.paycate.Size = new System.Drawing.Size(109, 21);
            this.paycate.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Category";
            // 
            // CustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 451);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Due);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.Debit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerAccount";
            this.Load += new System.EventHandler(this.CustomerAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox amu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Debit;
        private System.Windows.Forms.TextBox credit;
        private System.Windows.Forms.TextBox Due;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox paycate;
    }
}