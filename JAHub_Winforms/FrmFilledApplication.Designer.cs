namespace JAHub_Winforms
{
    partial class FrmFilledApplication
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
            this.btnUpdateGrant = new FontAwesome.Sharp.IconButton();
            this.btnDeleteGrant = new FontAwesome.Sharp.IconButton();
            this.btngrantcreate = new FontAwesome.Sharp.IconButton();
            this.btngrantHome = new FontAwesome.Sharp.IconButton();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnViewall = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlGrantSubmission = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlNav.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateGrant
            // 
            this.btnUpdateGrant.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateGrant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateGrant.FlatAppearance.BorderSize = 0;
            this.btnUpdateGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGrant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // btnDeleteGrant
            // 
            this.btnDeleteGrant.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteGrant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteGrant.FlatAppearance.BorderSize = 0;
            this.btnDeleteGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGrant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // btngrantcreate
            // 
            this.btngrantcreate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btngrantcreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngrantcreate.FlatAppearance.BorderSize = 0;
            this.btngrantcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrantcreate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // btngrantHome
            // 
            this.btngrantHome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btngrantHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngrantHome.FlatAppearance.BorderSize = 0;
            this.btngrantHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrantHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btngrantHome.Click += new System.EventHandler(this.btngrantHome_Click);
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
            this.pnlNav.Size = new System.Drawing.Size(188, 856);
            this.pnlNav.TabIndex = 78;
            // 
            // btnViewall
            // 
            this.btnViewall.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewall.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewall.FlatAppearance.BorderSize = 0;
            this.btnViewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlGrantSubmission
            // 
            this.pnlGrantSubmission.Location = new System.Drawing.Point(269, 136);
            this.pnlGrantSubmission.Name = "pnlGrantSubmission";
            this.pnlGrantSubmission.Size = new System.Drawing.Size(800, 686);
            this.pnlGrantSubmission.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 39);
            this.label2.TabIndex = 81;
            this.label2.Text = "Grant Submissions";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Navy;
            this.richTextBox1.Location = new System.Drawing.Point(269, 54);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(549, 53);
            this.richTextBox1.TabIndex = 80;
            this.richTextBox1.Text = "Download grants to view ";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FrmFilledApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 856);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pnlGrantSubmission);
            this.Controls.Add(this.pnlNav);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFilledApplication";
            this.Text = "Grant Submissions";
            this.Load += new System.EventHandler(this.FrmFilledApplication_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnUpdateGrant;
        private FontAwesome.Sharp.IconButton btnDeleteGrant;
        private FontAwesome.Sharp.IconButton btngrantcreate;
        private FontAwesome.Sharp.IconButton btngrantHome;
        private System.Windows.Forms.Panel pnlNav;
        private FontAwesome.Sharp.IconButton btnViewall;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlGrantSubmission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}