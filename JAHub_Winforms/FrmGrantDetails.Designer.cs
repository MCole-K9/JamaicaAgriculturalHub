namespace JAHub_Winforms
{
    partial class FrmGrantDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrantDetails));
            this.txtapplicationnumber = new System.Windows.Forms.TextBox();
            this.txtcreategranttitle = new System.Windows.Forms.TextBox();
            this.lblrequirements = new System.Windows.Forms.Label();
            this.rtbrequirement = new System.Windows.Forms.RichTextBox();
            this.lbldecription = new System.Windows.Forms.Label();
            this.rtbdescription = new System.Windows.Forms.RichTextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.btnuploadfile = new System.Windows.Forms.Button();
            this.pbfile = new System.Windows.Forms.PictureBox();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.lblexpirydategrantdetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbfile)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtapplicationnumber
            // 
            this.txtapplicationnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapplicationnumber.Location = new System.Drawing.Point(967, 27);
            this.txtapplicationnumber.Name = "txtapplicationnumber";
            this.txtapplicationnumber.ReadOnly = true;
            this.txtapplicationnumber.Size = new System.Drawing.Size(118, 15);
            this.txtapplicationnumber.TabIndex = 71;
            this.txtapplicationnumber.Text = "Application _Form";
            // 
            // txtcreategranttitle
            // 
            this.txtcreategranttitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcreategranttitle.Location = new System.Drawing.Point(245, 27);
            this.txtcreategranttitle.Name = "txtcreategranttitle";
            this.txtcreategranttitle.ReadOnly = true;
            this.txtcreategranttitle.Size = new System.Drawing.Size(266, 15);
            this.txtcreategranttitle.TabIndex = 70;
            this.txtcreategranttitle.Text = "Title";
            // 
            // lblrequirements
            // 
            this.lblrequirements.AutoSize = true;
            this.lblrequirements.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequirements.Location = new System.Drawing.Point(241, 382);
            this.lblrequirements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrequirements.Name = "lblrequirements";
            this.lblrequirements.Size = new System.Drawing.Size(165, 27);
            this.lblrequirements.TabIndex = 69;
            this.lblrequirements.Text = "Requirements";
            // 
            // rtbrequirement
            // 
            this.rtbrequirement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbrequirement.Location = new System.Drawing.Point(243, 411);
            this.rtbrequirement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbrequirement.Name = "rtbrequirement";
            this.rtbrequirement.ReadOnly = true;
            this.rtbrequirement.Size = new System.Drawing.Size(706, 151);
            this.rtbrequirement.TabIndex = 68;
            this.rtbrequirement.Text = "";
            // 
            // lbldecription
            // 
            this.lbldecription.AutoSize = true;
            this.lbldecription.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldecription.Location = new System.Drawing.Point(240, 102);
            this.lbldecription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldecription.Name = "lbldecription";
            this.lbldecription.Size = new System.Drawing.Size(206, 27);
            this.lbldecription.TabIndex = 67;
            this.lbldecription.Text = "Grant Description";
            // 
            // rtbdescription
            // 
            this.rtbdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbdescription.Location = new System.Drawing.Point(244, 138);
            this.rtbdescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbdescription.Name = "rtbdescription";
            this.rtbdescription.ReadOnly = true;
            this.rtbdescription.Size = new System.Drawing.Size(705, 181);
            this.rtbdescription.TabIndex = 66;
            this.rtbdescription.Text = "";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(240, 639);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(126, 27);
            this.lblExpirationDate.TabIndex = 72;
            this.lblExpirationDate.Text = "Deadline :";
            // 
            // btnuploadfile
            // 
            this.btnuploadfile.Location = new System.Drawing.Point(542, 940);
            this.btnuploadfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnuploadfile.Name = "btnuploadfile";
            this.btnuploadfile.Size = new System.Drawing.Size(88, 38);
            this.btnuploadfile.TabIndex = 73;
            this.btnuploadfile.Text = "Upload File";
            this.btnuploadfile.UseVisualStyleBackColor = true;
            this.btnuploadfile.Click += new System.EventHandler(this.btnuploadfile_Click);
            // 
            // pbfile
            // 
            this.pbfile.Image = ((System.Drawing.Image)(resources.GetObject("pbfile.Image")));
            this.pbfile.Location = new System.Drawing.Point(433, 720);
            this.pbfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbfile.Name = "pbfile";
            this.pbfile.Size = new System.Drawing.Size(315, 194);
            this.pbfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbfile.TabIndex = 74;
            this.pbfile.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 151);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(27, 0, 40, 0);
            this.btnHome.Size = new System.Drawing.Size(188, 58);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(188, 151);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JAHub_Winforms.Properties.Resources.farmer_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlNav.Controls.Add(this.btnHome);
            this.pnlNav.Controls.Add(this.pnlLogo);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(188, 1055);
            this.pnlNav.TabIndex = 75;
            // 
            // lblexpirydategrantdetails
            // 
            this.lblexpirydategrantdetails.AutoSize = true;
            this.lblexpirydategrantdetails.Location = new System.Drawing.Point(430, 648);
            this.lblexpirydategrantdetails.Name = "lblexpirydategrantdetails";
            this.lblexpirydategrantdetails.Size = new System.Drawing.Size(60, 16);
            this.lblexpirydategrantdetails.TabIndex = 76;
            this.lblexpirydategrantdetails.Text = "deadline";
            // 
            // FrmGrantDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.lblexpirydategrantdetails);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.btnuploadfile);
            this.Controls.Add(this.pbfile);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.txtapplicationnumber);
            this.Controls.Add(this.txtcreategranttitle);
            this.Controls.Add(this.lblrequirements);
            this.Controls.Add(this.rtbrequirement);
            this.Controls.Add(this.lbldecription);
            this.Controls.Add(this.rtbdescription);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGrantDetails";
            this.Text = "Grant Details";
            ((System.ComponentModel.ISupportInitialize)(this.pbfile)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtapplicationnumber;
        private System.Windows.Forms.TextBox txtcreategranttitle;
        private System.Windows.Forms.Label lblrequirements;
        private System.Windows.Forms.RichTextBox rtbrequirement;
        private System.Windows.Forms.Label lbldecription;
        private System.Windows.Forms.RichTextBox rtbdescription;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Button btnuploadfile;
        private System.Windows.Forms.PictureBox pbfile;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblexpirydategrantdetails;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}