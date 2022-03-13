namespace JAHubLib.Verification
{
    partial class usrNameBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblNameBlock = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblNameSectionTitle = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.nameBlockErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblNameBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameBlockErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tblNameBlock
            // 
            this.tblNameBlock.AutoSize = true;
            this.tblNameBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblNameBlock.ColumnCount = 2;
            this.tblNameBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNameBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblNameBlock.Controls.Add(this.lblFirstName, 0, 1);
            this.tblNameBlock.Controls.Add(this.lblNameSectionTitle, 0, 0);
            this.tblNameBlock.Controls.Add(this.lblMiddleName, 0, 2);
            this.tblNameBlock.Controls.Add(this.lblLastName, 0, 3);
            this.tblNameBlock.Controls.Add(this.txtFirstName, 1, 1);
            this.tblNameBlock.Controls.Add(this.txtMiddleName, 1, 2);
            this.tblNameBlock.Controls.Add(this.txtLastName, 1, 3);
            this.tblNameBlock.Location = new System.Drawing.Point(0, 0);
            this.tblNameBlock.Margin = new System.Windows.Forms.Padding(0);
            this.tblNameBlock.Name = "tblNameBlock";
            this.tblNameBlock.RowCount = 4;
            this.tblNameBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblNameBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblNameBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblNameBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblNameBlock.Size = new System.Drawing.Size(244, 104);
            this.tblNameBlock.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFirstName.Location = new System.Drawing.Point(19, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 26);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNameSectionTitle
            // 
            this.lblNameSectionTitle.AutoSize = true;
            this.tblNameBlock.SetColumnSpan(this.lblNameSectionTitle, 2);
            this.lblNameSectionTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameSectionTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNameSectionTitle.Location = new System.Drawing.Point(3, 0);
            this.lblNameSectionTitle.Name = "lblNameSectionTitle";
            this.lblNameSectionTitle.Size = new System.Drawing.Size(238, 26);
            this.lblNameSectionTitle.TabIndex = 0;
            this.lblNameSectionTitle.Text = "Name";
            this.lblNameSectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMiddleName.Location = new System.Drawing.Point(3, 52);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(88, 26);
            this.lblMiddleName.TabIndex = 1;
            this.lblMiddleName.Text = "Middle Name";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLastName.Location = new System.Drawing.Point(19, 78);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 26);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(97, 28);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.MaxLength = 200;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(125, 22);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(97, 54);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMiddleName.MaxLength = 200;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(125, 22);
            this.txtMiddleName.TabIndex = 3;
            this.txtMiddleName.Validating += new System.ComponentModel.CancelEventHandler(this.txtMiddleName_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(97, 80);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.MaxLength = 200;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(125, 22);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // nameBlockErrorProvider
            // 
            this.nameBlockErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.nameBlockErrorProvider.ContainerControl = this;
            // 
            // usrNameBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tblNameBlock);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "usrNameBlock";
            this.Size = new System.Drawing.Size(244, 104);
            this.tblNameBlock.ResumeLayout(false);
            this.tblNameBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameBlockErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.SuspendLayout();
            // 
            // usrNameBlock
            // 
            this.Name = "usrNameBlock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblNameBlock;
        private System.Windows.Forms.Label lblNameSectionTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ErrorProvider nameBlockErrorProvider;
    }
}
