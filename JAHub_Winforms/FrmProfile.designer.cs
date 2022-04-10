namespace JAHub_Winforms
{
    partial class FrmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfile));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnRadaStatus = new System.Windows.Forms.Button();
            this.btnGrant = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.btnProfileHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelHomeContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelMenu.Controls.Add(this.btnRadaStatus);
            this.panelMenu.Controls.Add(this.btnGrant);
            this.panelMenu.Controls.Add(this.btnManageProducts);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnSecurity);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.btnMyAccount);
            this.panelMenu.Controls.Add(this.btnProfileHome);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(291, 738);
            this.panelMenu.TabIndex = 0;
            // 
            // btnRadaStatus
            // 
            this.btnRadaStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRadaStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRadaStatus.FlatAppearance.BorderSize = 0;
            this.btnRadaStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadaStatus.ForeColor = System.Drawing.Color.White;
            this.btnRadaStatus.Image = global::JAHub_Winforms.Properties.Resources.user_0_;
            this.btnRadaStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRadaStatus.Location = new System.Drawing.Point(0, 399);
            this.btnRadaStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnRadaStatus.Name = "btnRadaStatus";
            this.btnRadaStatus.Size = new System.Drawing.Size(291, 48);
            this.btnRadaStatus.TabIndex = 7;
            this.btnRadaStatus.Text = "Rada Status";
            this.btnRadaStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRadaStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRadaStatus.UseVisualStyleBackColor = true;
            this.btnRadaStatus.Click += new System.EventHandler(this.btnRadaStatus_Click);
            // 
            // btnGrant
            // 
            this.btnGrant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrant.FlatAppearance.BorderSize = 0;
            this.btnGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrant.ForeColor = System.Drawing.Color.White;
            this.btnGrant.Image = ((System.Drawing.Image)(resources.GetObject("btnGrant.Image")));
            this.btnGrant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrant.Location = new System.Drawing.Point(0, 351);
            this.btnGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(291, 48);
            this.btnGrant.TabIndex = 7;
            this.btnGrant.Text = "Grant";
            this.btnGrant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrant.UseVisualStyleBackColor = true;
            this.btnGrant.Click += new System.EventHandler(this.btnGrant_Click);
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageProducts.FlatAppearance.BorderSize = 0;
            this.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProducts.ForeColor = System.Drawing.Color.White;
            this.btnManageProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnManageProducts.Image")));
            this.btnManageProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProducts.Location = new System.Drawing.Point(0, 303);
            this.btnManageProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(291, 48);
            this.btnManageProducts.TabIndex = 6;
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageProducts.UseVisualStyleBackColor = true;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(0, 437);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(291, 48);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = " Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSecurity
            // 
            this.btnSecurity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecurity.FlatAppearance.BorderSize = 0;
            this.btnSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurity.ForeColor = System.Drawing.Color.White;
            this.btnSecurity.Image = ((System.Drawing.Image)(resources.GetObject("btnSecurity.Image")));
            this.btnSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.Location = new System.Drawing.Point(0, 255);
            this.btnSecurity.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(291, 48);
            this.btnSecurity.TabIndex = 4;
            this.btnSecurity.Text = "  Security";
            this.btnSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecurity.UseVisualStyleBackColor = true;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 207);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(291, 48);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyAccount.FlatAppearance.BorderSize = 0;
            this.btnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAccount.ForeColor = System.Drawing.Color.White;
            this.btnMyAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnMyAccount.Image")));
            this.btnMyAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyAccount.Location = new System.Drawing.Point(0, 159);
            this.btnMyAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(291, 48);
            this.btnMyAccount.TabIndex = 2;
            this.btnMyAccount.Text = "  My Account";
            this.btnMyAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyAccount.UseVisualStyleBackColor = true;
            this.btnMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // btnProfileHome
            // 
            this.btnProfileHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfileHome.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnProfileHome.FlatAppearance.BorderSize = 0;
            this.btnProfileHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileHome.ForeColor = System.Drawing.Color.White;
            this.btnProfileHome.Image = ((System.Drawing.Image)(resources.GetObject("btnProfileHome.Image")));
            this.btnProfileHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfileHome.Location = new System.Drawing.Point(0, 111);
            this.btnProfileHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfileHome.Name = "btnProfileHome";
            this.btnProfileHome.Size = new System.Drawing.Size(291, 48);
            this.btnProfileHome.TabIndex = 1;
            this.btnProfileHome.Text = "  Home";
            this.btnProfileHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfileHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfileHome.UseVisualStyleBackColor = true;
            this.btnProfileHome.Click += new System.EventHandler(this.btnProfileHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 111);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "All Local Products in One Place";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jamaica Agricultural Hub";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JAHub_Winforms.Properties.Resources.farmer_icon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 111);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelHomeContainer
            // 
            this.panelHomeContainer.AutoScroll = true;
            this.panelHomeContainer.AutoSize = true;
            this.panelHomeContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelHomeContainer.BackColor = System.Drawing.Color.White;
            this.panelHomeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHomeContainer.Location = new System.Drawing.Point(291, 0);
            this.panelHomeContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelHomeContainer.Name = "panelHomeContainer";
            this.panelHomeContainer.Size = new System.Drawing.Size(1277, 738);
            this.panelHomeContainer.TabIndex = 1;
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1568, 738);
            this.Controls.Add(this.panelHomeContainer);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProfile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.FrmProfile_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnProfileHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMyAccount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelHomeContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnGrant;
        private System.Windows.Forms.Button btnRadaStatus;
    }
}

