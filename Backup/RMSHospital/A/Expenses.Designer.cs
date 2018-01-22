namespace WindowsFormsApplication1.A
{
    partial class Expenses
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
            this.Comment = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Amu = new System.Windows.Forms.TextBox();
            this.Credit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SumValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reason";
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(15, 34);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(295, 75);
            this.Comment.TabIndex = 1;
            this.Comment.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // Amu
            // 
            this.Amu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Amu.ForeColor = System.Drawing.Color.Lime;
            this.Amu.Location = new System.Drawing.Point(15, 128);
            this.Amu.Name = "Amu";
            this.Amu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Amu.Size = new System.Drawing.Size(144, 20);
            this.Amu.TabIndex = 5;
            this.Amu.Text = "0.00";
            // 
            // Credit
            // 
            this.Credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.Credit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Credit.ForeColor = System.Drawing.Color.White;
            this.Credit.Location = new System.Drawing.Point(119, 162);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(91, 23);
            this.Credit.TabIndex = 39;
            this.Credit.Text = "Submit";
            this.Credit.UseVisualStyleBackColor = false;
            this.Credit.Click += new System.EventHandler(this.Credit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(394, 302);
            this.dataGridView1.TabIndex = 40;
            // 
            // SumValue
            // 
            this.SumValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SumValue.ForeColor = System.Drawing.Color.Lime;
            this.SumValue.Location = new System.Drawing.Point(596, 326);
            this.SumValue.Name = "SumValue";
            this.SumValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SumValue.Size = new System.Drawing.Size(144, 20);
            this.SumValue.TabIndex = 42;
            this.SumValue.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Total";
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SumValue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.Amu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expences";
            this.Load += new System.EventHandler(this.Expences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Comment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Amu;
        private System.Windows.Forms.Button Credit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SumValue;
        private System.Windows.Forms.Label label3;
    }
}