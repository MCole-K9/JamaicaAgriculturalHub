namespace JAHub_Winforms
{
    partial class FrmRadaRegister
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
            this.flwRadaRegister = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRegisterWithRada = new System.Windows.Forms.Label();
            this.tblNewOrConnectOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnConnectExistingAccount = new System.Windows.Forms.Button();
            this.lblOr = new System.Windows.Forms.Label();
            this.lblMandatoryFields = new System.Windows.Forms.Label();
            this.flwFormEntryControls = new System.Windows.Forms.FlowLayoutPanel();
            this.usrNameBlock1 = new JAHub_Winforms.Verification.usrNameBlock();
            this.usrDateOfBirthBlock1 = new JAHub_Winforms.Verification.usrDateOfBirthBlock();
            this.usrContactBlock1 = new JAHub_Winforms.Verification.usrContactBlock();
            this.usrTrnBlock1 = new JAHub_Winforms.Verification.usrTrnBlock();
            this.usrUploadImageBlock1 = new JAHub_Winforms.Verification.usrUploadImageBlock();
            this.usrIndustryBlock1 = new JAHub_Winforms.Verifcation.usrIndustryBlock();
            this.usrHoldingsBlock2 = new JAHub_Winforms.Verification.usrHoldingsBlock();
            this.usrOrganizationsBlock1 = new JAHub_Winforms.Verification.usrOrganizationsBlock();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNewRegistration = new System.Windows.Forms.Button();
            this.flwRadaRegister.SuspendLayout();
            this.tblNewOrConnectOptions.SuspendLayout();
            this.flwFormEntryControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwRadaRegister
            // 
            this.flwRadaRegister.AutoScroll = true;
            this.flwRadaRegister.AutoSize = true;
            this.flwRadaRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwRadaRegister.BackColor = System.Drawing.Color.Transparent;
            this.flwRadaRegister.Controls.Add(this.lblRegisterWithRada);
            this.flwRadaRegister.Controls.Add(this.tblNewOrConnectOptions);
            this.flwRadaRegister.Controls.Add(this.lblMandatoryFields);
            this.flwRadaRegister.Controls.Add(this.flwFormEntryControls);
            this.flwRadaRegister.Controls.Add(this.btnSubmit);
            this.flwRadaRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwRadaRegister.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwRadaRegister.Location = new System.Drawing.Point(0, 0);
            this.flwRadaRegister.Margin = new System.Windows.Forms.Padding(0);
            this.flwRadaRegister.Name = "flwRadaRegister";
            this.flwRadaRegister.Size = new System.Drawing.Size(624, 554);
            this.flwRadaRegister.TabIndex = 0;
            this.flwRadaRegister.WrapContents = false;
            // 
            // lblRegisterWithRada
            // 
            this.lblRegisterWithRada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegisterWithRada.AutoSize = true;
            this.lblRegisterWithRada.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterWithRada.Location = new System.Drawing.Point(109, 0);
            this.lblRegisterWithRada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 15);
            this.lblRegisterWithRada.Name = "lblRegisterWithRada";
            this.lblRegisterWithRada.Size = new System.Drawing.Size(382, 46);
            this.lblRegisterWithRada.TabIndex = 1;
            this.lblRegisterWithRada.Text = "Register With RADA";
            // 
            // tblNewOrConnectOptions
            // 
            this.tblNewOrConnectOptions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblNewOrConnectOptions.ColumnCount = 3;
            this.tblNewOrConnectOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNewOrConnectOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblNewOrConnectOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNewOrConnectOptions.Controls.Add(this.lblOr, 1, 0);
            this.tblNewOrConnectOptions.Controls.Add(this.btnNewRegistration, 0, 0);
            this.tblNewOrConnectOptions.Controls.Add(this.btnConnectExistingAccount, 2, 0);
            this.tblNewOrConnectOptions.Location = new System.Drawing.Point(4, 65);
            this.tblNewOrConnectOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.tblNewOrConnectOptions.Name = "tblNewOrConnectOptions";
            this.tblNewOrConnectOptions.RowCount = 1;
            this.tblNewOrConnectOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNewOrConnectOptions.Size = new System.Drawing.Size(593, 58);
            this.tblNewOrConnectOptions.TabIndex = 0;
            // 
            // btnConnectExistingAccount
            // 
            this.btnConnectExistingAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConnectExistingAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectExistingAccount.Location = new System.Drawing.Point(322, 4);
            this.btnConnectExistingAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnectExistingAccount.Name = "btnConnectExistingAccount";
            this.btnConnectExistingAccount.Size = new System.Drawing.Size(172, 52);
            this.btnConnectExistingAccount.TabIndex = 1;
            this.btnConnectExistingAccount.Text = "Connect Existing Account";
            this.btnConnectExistingAccount.UseVisualStyleBackColor = true;
            this.btnConnectExistingAccount.Click += new System.EventHandler(this.btnConnectExistingAccount_Click);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.Location = new System.Drawing.Point(279, 0);
            this.lblOr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(35, 60);
            this.lblOr.TabIndex = 2;
            this.lblOr.Text = "or";
            this.lblOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMandatoryFields
            // 
            this.lblMandatoryFields.AutoSize = true;
            this.lblMandatoryFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMandatoryFields.Location = new System.Drawing.Point(4, 138);
            this.lblMandatoryFields.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.lblMandatoryFields.Name = "lblMandatoryFields";
            this.lblMandatoryFields.Size = new System.Drawing.Size(299, 22);
            this.lblMandatoryFields.TabIndex = 3;
            this.lblMandatoryFields.Text = "Fields marked with \'*\' are mandatory";
            // 
            // flwFormEntryControls
            // 
            this.flwFormEntryControls.AutoSize = true;
            this.flwFormEntryControls.BackColor = System.Drawing.Color.Transparent;
            this.flwFormEntryControls.Controls.Add(this.usrNameBlock1);
            this.flwFormEntryControls.Controls.Add(this.usrDateOfBirthBlock1);
            this.flwFormEntryControls.Controls.Add(this.usrContactBlock1);
            this.flwFormEntryControls.Controls.Add(this.usrTrnBlock1);
            this.flwFormEntryControls.Controls.Add(this.usrUploadImageBlock1);
            this.flwFormEntryControls.Controls.Add(this.usrIndustryBlock1);
            this.flwFormEntryControls.Controls.Add(this.usrHoldingsBlock2);
            this.flwFormEntryControls.Controls.Add(this.usrOrganizationsBlock1);
            this.flwFormEntryControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwFormEntryControls.Location = new System.Drawing.Point(4, 174);
            this.flwFormEntryControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flwFormEntryControls.Name = "flwFormEntryControls";
            this.flwFormEntryControls.Size = new System.Drawing.Size(572, 1205);
            this.flwFormEntryControls.TabIndex = 2;
            this.flwFormEntryControls.WrapContents = false;
            // 
            // usrNameBlock1
            // 
            this.usrNameBlock1.AutoSize = true;
            this.usrNameBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrNameBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrNameBlock1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usrNameBlock1.Location = new System.Drawing.Point(3, 2);
            this.usrNameBlock1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usrNameBlock1.Name = "usrNameBlock1";
            this.usrNameBlock1.Size = new System.Drawing.Size(263, 124);
            this.usrNameBlock1.TabIndex = 0;
            // 
            // usrDateOfBirthBlock1
            // 
            this.usrDateOfBirthBlock1.AutoSize = true;
            this.usrDateOfBirthBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrDateOfBirthBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrDateOfBirthBlock1.Location = new System.Drawing.Point(0, 128);
            this.usrDateOfBirthBlock1.Margin = new System.Windows.Forms.Padding(0);
            this.usrDateOfBirthBlock1.Name = "usrDateOfBirthBlock1";
            this.usrDateOfBirthBlock1.Size = new System.Drawing.Size(301, 105);
            this.usrDateOfBirthBlock1.TabIndex = 1;
            // 
            // usrContactBlock1
            // 
            this.usrContactBlock1.AutoSize = true;
            this.usrContactBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrContactBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrContactBlock1.Location = new System.Drawing.Point(0, 233);
            this.usrContactBlock1.Margin = new System.Windows.Forms.Padding(0);
            this.usrContactBlock1.Name = "usrContactBlock1";
            this.usrContactBlock1.Size = new System.Drawing.Size(400, 172);
            this.usrContactBlock1.TabIndex = 2;
            // 
            // usrTrnBlock1
            // 
            this.usrTrnBlock1.AutoSize = true;
            this.usrTrnBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrTrnBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrTrnBlock1.Location = new System.Drawing.Point(4, 409);
            this.usrTrnBlock1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usrTrnBlock1.Name = "usrTrnBlock1";
            this.usrTrnBlock1.Size = new System.Drawing.Size(222, 33);
            this.usrTrnBlock1.TabIndex = 3;
            // 
            // usrUploadImageBlock1
            // 
            this.usrUploadImageBlock1.AutoSize = true;
            this.usrUploadImageBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrUploadImageBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrUploadImageBlock1.Location = new System.Drawing.Point(4, 450);
            this.usrUploadImageBlock1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usrUploadImageBlock1.Name = "usrUploadImageBlock1";
            this.usrUploadImageBlock1.Size = new System.Drawing.Size(337, 112);
            this.usrUploadImageBlock1.TabIndex = 5;
            // 
            // usrIndustryBlock1
            // 
            this.usrIndustryBlock1.AutoSize = true;
            this.usrIndustryBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrIndustryBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrIndustryBlock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrIndustryBlock1.Location = new System.Drawing.Point(5, 571);
            this.usrIndustryBlock1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.usrIndustryBlock1.MaximumSize = new System.Drawing.Size(749, 0);
            this.usrIndustryBlock1.Name = "usrIndustryBlock1";
            this.usrIndustryBlock1.Size = new System.Drawing.Size(562, 125);
            this.usrIndustryBlock1.TabIndex = 4;
            // 
            // usrHoldingsBlock2
            // 
            this.usrHoldingsBlock2.AutoSize = true;
            this.usrHoldingsBlock2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrHoldingsBlock2.BackColor = System.Drawing.Color.Transparent;
            this.usrHoldingsBlock2.Location = new System.Drawing.Point(3, 704);
            this.usrHoldingsBlock2.Name = "usrHoldingsBlock2";
            this.usrHoldingsBlock2.Size = new System.Drawing.Size(378, 312);
            this.usrHoldingsBlock2.TabIndex = 6;
            // 
            // usrOrganizationsBlock1
            // 
            this.usrOrganizationsBlock1.AutoSize = true;
            this.usrOrganizationsBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrOrganizationsBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrOrganizationsBlock1.Location = new System.Drawing.Point(4, 1023);
            this.usrOrganizationsBlock1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usrOrganizationsBlock1.Name = "usrOrganizationsBlock1";
            this.usrOrganizationsBlock1.Size = new System.Drawing.Size(506, 178);
            this.usrOrganizationsBlock1.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(251, 1387);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 49);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNewRegistration
            // 
            this.btnNewRegistration.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRegistration.Location = new System.Drawing.Point(100, 4);
            this.btnNewRegistration.Name = "btnNewRegistration";
            this.btnNewRegistration.Size = new System.Drawing.Size(172, 52);
            this.btnNewRegistration.TabIndex = 3;
            this.btnNewRegistration.Text = "New Registration";
            this.btnNewRegistration.UseVisualStyleBackColor = true;
            // 
            // FrmRadaRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 554);
            this.Controls.Add(this.flwRadaRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRadaRegister";
            this.Text = "Register With RADA";
            this.flwRadaRegister.ResumeLayout(false);
            this.flwRadaRegister.PerformLayout();
            this.tblNewOrConnectOptions.ResumeLayout(false);
            this.tblNewOrConnectOptions.PerformLayout();
            this.flwFormEntryControls.ResumeLayout(false);
            this.flwFormEntryControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwRadaRegister;
        private System.Windows.Forms.TableLayoutPanel tblNewOrConnectOptions;
        private System.Windows.Forms.Label lblRegisterWithRada;
        private System.Windows.Forms.Button btnConnectExistingAccount;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.FlowLayoutPanel flwFormEntryControls;
        private Verification.usrNameBlock usrNameBlock1;
        private Verification.usrDateOfBirthBlock usrDateOfBirthBlock1;
        private Verification.usrContactBlock usrContactBlock1;
        private Verification.usrTrnBlock usrTrnBlock1;
        private Verifcation.usrIndustryBlock usrIndustryBlock1;
        private Verification.usrUploadImageBlock usrUploadImageBlock1;
        private Verification.usrOrganizationsBlock usrOrganizationsBlock1;
        private System.Windows.Forms.Button btnSubmit;
        private Verification.usrHoldingsBlock usrHoldingsBlock2;
        private System.Windows.Forms.Label lblMandatoryFields;
        private System.Windows.Forms.Button btnNewRegistration;
    }
}