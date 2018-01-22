namespace WindowsFormsApplication1.P
{
    partial class NewStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStore));
            this.label1 = new System.Windows.Forms.Label();
            this.storename = new System.Windows.Forms.TextBox();
            this.printname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ppno = new System.Windows.Forms.MaskedTextBox();
            this.spno = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Name*";
            // 
            // storename
            // 
            this.storename.Location = new System.Drawing.Point(6, 29);
            this.storename.MaxLength = 50;
            this.storename.Name = "storename";
            this.storename.Size = new System.Drawing.Size(251, 21);
            this.storename.TabIndex = 1;
            // 
            // printname
            // 
            this.printname.Location = new System.Drawing.Point(6, 69);
            this.printname.MaxLength = 30;
            this.printname.Name = "printname";
            this.printname.Size = new System.Drawing.Size(251, 21);
            this.printname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Print Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone No#";
            // 
            // ppno
            // 
            this.ppno.Location = new System.Drawing.Point(6, 109);
            this.ppno.Mask = "000-000-0000";
            this.ppno.Name = "ppno";
            this.ppno.Size = new System.Drawing.Size(251, 21);
            this.ppno.TabIndex = 5;
            // 
            // spno
            // 
            this.spno.Location = new System.Drawing.Point(6, 147);
            this.spno.Mask = "000-000-0000";
            this.spno.Name = "spno";
            this.spno.Size = new System.Drawing.Size(251, 21);
            this.spno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Secondry Phone No#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(6, 187);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(251, 64);
            this.address.TabIndex = 9;
            this.address.Text = "";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(88, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 301);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ppno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.printname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.storename);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewStore";
            this.Load += new System.EventHandler(this.NewStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox storename;
        private System.Windows.Forms.TextBox printname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ppno;
        private System.Windows.Forms.MaskedTextBox spno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.Button button2;
    }
}