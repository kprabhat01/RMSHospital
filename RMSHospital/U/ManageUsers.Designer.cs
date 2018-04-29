namespace WindowsFormsApplication1.U
{
    partial class ManageUsers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.UsrTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnChangePassword = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.PnlObject = new System.Windows.Forms.TabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsrTree
            // 
            this.UsrTree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrTree.Location = new System.Drawing.Point(8, 63);
            this.UsrTree.Name = "UsrTree";
            this.UsrTree.Size = new System.Drawing.Size(274, 402);
            this.UsrTree.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "User-Group-icon.png");
            this.imageList1.Images.SetKeyName(1, "icons8-user-16.png");
            this.imageList1.Images.SetKeyName(2, "icons8-checked-user-male-16.png");
            this.imageList1.Images.SetKeyName(3, "icons8-user-account-16.png");
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(8, 471);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(118, 23);
            this.btnChangePassword.TabIndex = 13;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.PnlObject);
            this.metroTabControl1.Location = new System.Drawing.Point(288, 30);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(530, 435);
            this.metroTabControl1.TabIndex = 14;
            this.metroTabControl1.UseSelectable = true;
            // 
            // PnlObject
            // 
            this.PnlObject.BackColor = System.Drawing.Color.White;
            this.PnlObject.Location = new System.Drawing.Point(4, 38);
            this.PnlObject.Name = "PnlObject";
            this.PnlObject.Size = new System.Drawing.Size(522, 393);
            this.PnlObject.TabIndex = 0;
            this.PnlObject.Text = "Change Password";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(132, 471);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 23);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Manage Permission";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(256, 471);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(105, 23);
            this.metroButton2.TabIndex = 16;
            this.metroButton2.Text = "Options";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 498);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.UsrTree);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView UsrTree;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroButton btnChangePassword;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage PnlObject;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}