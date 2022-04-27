namespace JAHub_Winforms
{
    partial class FrmGeneralGrantInfo
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnApplyforGrant = new FontAwesome.Sharp.IconButton();
            this.btngrantHome = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbgeneralgrantinfonav = new System.Windows.Forms.PictureBox();
            this.btnDeleteGrant = new FontAwesome.Sharp.IconButton();
            this.pnlNav.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbgeneralgrantinfonav)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Navy;
            this.richTextBox1.Location = new System.Drawing.Point(269, 63);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(549, 53);
            this.richTextBox1.TabIndex = 42;
            this.richTextBox1.Text = "Please click \'View more\' on available grants to see further information about gra" +
    "nts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 61;
            this.label1.Text = "Available Grants";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.AutoSize = true;
            this.pnlContainer.Location = new System.Drawing.Point(272, 140);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.pnlContainer.Size = new System.Drawing.Size(765, 628);
            this.pnlContainer.TabIndex = 62;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlNav.Controls.Add(this.btnApplyforGrant);
            this.pnlNav.Controls.Add(this.btngrantHome);
            this.pnlNav.Controls.Add(this.pnlLogo);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(194, 822);
            this.pnlNav.TabIndex = 63;
            // 
            // btnApplyforGrant
            // 
            this.btnApplyforGrant.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnApplyforGrant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApplyforGrant.FlatAppearance.BorderSize = 0;
            this.btnApplyforGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyforGrant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyforGrant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApplyforGrant.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnApplyforGrant.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApplyforGrant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApplyforGrant.IconSize = 30;
            this.btnApplyforGrant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyforGrant.Location = new System.Drawing.Point(0, 209);
            this.btnApplyforGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyforGrant.Name = "btnApplyforGrant";
            this.btnApplyforGrant.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnApplyforGrant.Size = new System.Drawing.Size(194, 58);
            this.btnApplyforGrant.TabIndex = 3;
            this.btnApplyforGrant.Text = "Apply";
            this.btnApplyforGrant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyforGrant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplyforGrant.UseVisualStyleBackColor = false;
            this.btnApplyforGrant.Click += new System.EventHandler(this.btnApplyforGrant_Click);
            // 
            // btngrantHome
            // 
            this.btngrantHome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btngrantHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngrantHome.FlatAppearance.BorderSize = 0;
            this.btngrantHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrantHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btngrantHome.Size = new System.Drawing.Size(194, 58);
            this.btngrantHome.TabIndex = 1;
            this.btngrantHome.Text = "Home";
            this.btngrantHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrantHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngrantHome.UseVisualStyleBackColor = false;
            this.btngrantHome.Click += new System.EventHandler(this.btnGrantHome_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbgeneralgrantinfonav);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(194, 151);
            this.pnlLogo.TabIndex = 0;
            // 
            // pbgeneralgrantinfonav
            // 
            this.pbgeneralgrantinfonav.Image = global::JAHub_Winforms.Properties.Resources.farmer_icon;
            this.pbgeneralgrantinfonav.Location = new System.Drawing.Point(0, 0);
            this.pbgeneralgrantinfonav.Name = "pbgeneralgrantinfonav";
            this.pbgeneralgrantinfonav.Size = new System.Drawing.Size(185, 151);
            this.pbgeneralgrantinfonav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbgeneralgrantinfonav.TabIndex = 0;
            this.pbgeneralgrantinfonav.TabStop = false;
            // 
            // btnDeleteGrant
            // 
            this.btnDeleteGrant.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteGrant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteGrant.FlatAppearance.BorderSize = 0;
            this.btnDeleteGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGrant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGrant.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnDeleteGrant.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGrant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteGrant.IconSize = 30;
            this.btnDeleteGrant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGrant.Location = new System.Drawing.Point(0, 441);
            this.btnDeleteGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGrant.Name = "btnDeleteGrant";
            this.btnDeleteGrant.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnDeleteGrant.Size = new System.Drawing.Size(188, 58);
            this.btnDeleteGrant.TabIndex = 7;
            this.btnDeleteGrant.Text = "Delete Grant";
            this.btnDeleteGrant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGrant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteGrant.UseVisualStyleBackColor = false;
            // 
            // FrmGeneralGrantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1083, 822);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGeneralGrantInfo";
            this.Text = "FrmGeneralGrantInfo";
            this.Load += new System.EventHandler(this.FrmGeneralGrantInfo_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbgeneralgrantinfonav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlNav;
        private FontAwesome.Sharp.IconButton btnApplyforGrant;
        private FontAwesome.Sharp.IconButton btngrantHome;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnDeleteGrant;
        private System.Windows.Forms.PictureBox pbgeneralgrantinfonav;
    }
}