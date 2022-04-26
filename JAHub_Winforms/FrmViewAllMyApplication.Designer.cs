namespace JAHub_Winforms
{
    partial class FrmViewAllMyApplication
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
            this.pnlContainerAdminViewGrants = new System.Windows.Forms.Panel();
            this.lblAgency = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnUpdateGrant = new FontAwesome.Sharp.IconButton();
            this.btnDeleteGrant = new FontAwesome.Sharp.IconButton();
            this.btnViewall = new FontAwesome.Sharp.IconButton();
            this.btngrantcreate = new FontAwesome.Sharp.IconButton();
            this.btngrantHome = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbviewallmyapplicationnav = new System.Windows.Forms.PictureBox();
            this.pnlNav.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbviewallmyapplicationnav)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainerAdminViewGrants
            // 
            this.pnlContainerAdminViewGrants.AutoScroll = true;
            this.pnlContainerAdminViewGrants.AutoSize = true;
            this.pnlContainerAdminViewGrants.Location = new System.Drawing.Point(295, 140);
            this.pnlContainerAdminViewGrants.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainerAdminViewGrants.Name = "pnlContainerAdminViewGrants";
            this.pnlContainerAdminViewGrants.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.pnlContainerAdminViewGrants.Size = new System.Drawing.Size(765, 628);
            this.pnlContainerAdminViewGrants.TabIndex = 66;
            // 
            // lblAgency
            // 
            this.lblAgency.AutoSize = true;
            this.lblAgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgency.Location = new System.Drawing.Point(287, 26);
            this.lblAgency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.Size = new System.Drawing.Size(189, 31);
            this.lblAgency.TabIndex = 65;
            this.lblAgency.Text = "All My Grants";
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlNav.Controls.Add(this.btnUpdateGrant);
            this.pnlNav.Controls.Add(this.btnDeleteGrant);
            this.pnlNav.Controls.Add(this.btnViewall);
            this.pnlNav.Controls.Add(this.btngrantcreate);
            this.pnlNav.Controls.Add(this.btngrantHome);
            this.pnlNav.Controls.Add(this.pnlLogo);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(188, 822);
            this.pnlNav.TabIndex = 78;
            // 
            // btnUpdateGrant
            // 
            this.btnUpdateGrant.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateGrant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateGrant.FlatAppearance.BorderSize = 0;
            this.btnUpdateGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGrant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateGrant.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.btnUpdateGrant.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateGrant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateGrant.IconSize = 30;
            this.btnUpdateGrant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateGrant.Location = new System.Drawing.Point(0, 383);
            this.btnUpdateGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateGrant.Name = "btnUpdateGrant";
            this.btnUpdateGrant.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnUpdateGrant.Size = new System.Drawing.Size(188, 58);
            this.btnUpdateGrant.TabIndex = 8;
            this.btnUpdateGrant.Text = "Update Grant";
            this.btnUpdateGrant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateGrant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateGrant.UseVisualStyleBackColor = false;
            this.btnUpdateGrant.Click += new System.EventHandler(this.btnUpdateGrant_Click);
            // 
            // btnDeleteGrant
            // 
            this.btnDeleteGrant.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteGrant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteGrant.FlatAppearance.BorderSize = 0;
            this.btnDeleteGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGrant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGrant.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteGrant.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGrant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteGrant.IconSize = 30;
            this.btnDeleteGrant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGrant.Location = new System.Drawing.Point(0, 325);
            this.btnDeleteGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGrant.Name = "btnDeleteGrant";
            this.btnDeleteGrant.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnDeleteGrant.Size = new System.Drawing.Size(188, 58);
            this.btnDeleteGrant.TabIndex = 7;
            this.btnDeleteGrant.Text = "Delete Grant";
            this.btnDeleteGrant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGrant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteGrant.UseVisualStyleBackColor = false;
            this.btnDeleteGrant.Click += new System.EventHandler(this.btnDeleteGrant_Click);
            // 
            // btnViewall
            // 
            this.btnViewall.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewall.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewall.FlatAppearance.BorderSize = 0;
            this.btnViewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewall.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewall.IconChar = FontAwesome.Sharp.IconChar.BorderAll;
            this.btnViewall.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewall.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewall.IconSize = 30;
            this.btnViewall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewall.Location = new System.Drawing.Point(0, 267);
            this.btnViewall.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewall.Name = "btnViewall";
            this.btnViewall.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnViewall.Size = new System.Drawing.Size(188, 58);
            this.btnViewall.TabIndex = 6;
            this.btnViewall.Text = "View All Grants";
            this.btnViewall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewall.UseVisualStyleBackColor = false;
            // 
            // btngrantcreate
            // 
            this.btngrantcreate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btngrantcreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngrantcreate.FlatAppearance.BorderSize = 0;
            this.btngrantcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrantcreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngrantcreate.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btngrantcreate.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btngrantcreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngrantcreate.IconSize = 30;
            this.btngrantcreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrantcreate.Location = new System.Drawing.Point(0, 209);
            this.btngrantcreate.Margin = new System.Windows.Forms.Padding(4);
            this.btngrantcreate.Name = "btngrantcreate";
            this.btngrantcreate.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btngrantcreate.Size = new System.Drawing.Size(188, 58);
            this.btngrantcreate.TabIndex = 5;
            this.btngrantcreate.Text = "Create Grants";
            this.btngrantcreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrantcreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngrantcreate.UseVisualStyleBackColor = false;
            this.btngrantcreate.Click += new System.EventHandler(this.btngrantcreate_Click);
            // 
            // btngrantHome
            // 
            this.btngrantHome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btngrantHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngrantHome.FlatAppearance.BorderSize = 0;
            this.btngrantHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrantHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngrantHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btngrantHome.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btngrantHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngrantHome.IconSize = 30;
            this.btngrantHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrantHome.Location = new System.Drawing.Point(0, 151);
            this.btngrantHome.Margin = new System.Windows.Forms.Padding(4);
            this.btngrantHome.Name = "btngrantHome";
            this.btngrantHome.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btngrantHome.Size = new System.Drawing.Size(188, 58);
            this.btngrantHome.TabIndex = 1;
            this.btngrantHome.Text = "Home";
            this.btngrantHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrantHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngrantHome.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbviewallmyapplicationnav);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(188, 151);
            this.pnlLogo.TabIndex = 0;
            // 
            // pbviewallmyapplicationnav
            // 
            this.pbviewallmyapplicationnav.Image = global::JAHub_Winforms.Properties.Resources.farmer_icon;
            this.pbviewallmyapplicationnav.Location = new System.Drawing.Point(0, 3);
            this.pbviewallmyapplicationnav.Name = "pbviewallmyapplicationnav";
            this.pbviewallmyapplicationnav.Size = new System.Drawing.Size(185, 148);
            this.pbviewallmyapplicationnav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbviewallmyapplicationnav.TabIndex = 0;
            this.pbviewallmyapplicationnav.TabStop = false;
            // 
            // FrmViewAllMyApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1083, 822);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlContainerAdminViewGrants);
            this.Controls.Add(this.lblAgency);
            this.Name = "FrmViewAllMyApplication";
            this.Text = "FrmViewAllMyApplication";
            this.Load += new System.EventHandler(this.FrmViewAllMyApplication_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbviewallmyapplicationnav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainerAdminViewGrants;
        private System.Windows.Forms.Label lblAgency;
        private System.Windows.Forms.Panel pnlNav;
        private FontAwesome.Sharp.IconButton btnUpdateGrant;
        private FontAwesome.Sharp.IconButton btnDeleteGrant;
        private FontAwesome.Sharp.IconButton btnViewall;
        private FontAwesome.Sharp.IconButton btngrantcreate;
        private FontAwesome.Sharp.IconButton btngrantHome;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pbviewallmyapplicationnav;
    }
}