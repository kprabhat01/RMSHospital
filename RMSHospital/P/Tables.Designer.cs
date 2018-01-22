namespace WindowsFormsApplication1.P
{
    partial class Tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tables));
            this.tablelist = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.addpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addnew = new System.Windows.Forms.TextBox();
            this.addpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablelist
            // 
            this.tablelist.FormattingEnabled = true;
            this.tablelist.Location = new System.Drawing.Point(3, 85);
            this.tablelist.Name = "tablelist";
            this.tablelist.Size = new System.Drawing.Size(259, 186);
            this.tablelist.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(181, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addpanel
            // 
            this.addpanel.Controls.Add(this.button1);
            this.addpanel.Controls.Add(this.Add);
            this.addpanel.Controls.Add(this.label1);
            this.addpanel.Controls.Add(this.addnew);
            this.addpanel.Location = new System.Drawing.Point(3, 2);
            this.addpanel.Name = "addpanel";
            this.addpanel.Size = new System.Drawing.Size(269, 78);
            this.addpanel.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(179, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(93, 48);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(81, 23);
            this.Add.TabIndex = 17;
            this.Add.Text = "+ Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Add New Table";
            // 
            // addnew
            // 
            this.addnew.Location = new System.Drawing.Point(1, 24);
            this.addnew.MaxLength = 30;
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(259, 21);
            this.addnew.TabIndex = 15;
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 300);
            this.Controls.Add(this.addpanel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tablelist);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.Tables_Load);
            this.addpanel.ResumeLayout(false);
            this.addpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox tablelist;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel addpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addnew;
    }
}