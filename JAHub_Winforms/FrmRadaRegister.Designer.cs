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
            this.flpRadaRegister = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRegisterWithRada = new System.Windows.Forms.Label();
            this.tlpNewOrConnectOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnNewRegistration = new System.Windows.Forms.Button();
            this.btnConnectExistingAccount = new System.Windows.Forms.Button();
            this.lblMandatoryFields = new System.Windows.Forms.Label();
            this.flpFormEntryControls = new System.Windows.Forms.FlowLayoutPanel();
            this.usrNameBlock1 = new JAHub_Winforms.Verification.usrNameBlock();
            this.usrDateOfBirthBlock1 = new JAHub_Winforms.Verification.usrDateOfBirthBlock();
            this.usrContactBlock1 = new JAHub_Winforms.Verification.usrContactBlock();
            this.usrTrnBlock1 = new JAHub_Winforms.Verification.usrTrnBlock();
            this.usrUploadImageBlock1 = new JAHub_Winforms.Verification.usrUploadImageBlock();
            this.usrIndustryBlock1 = new JAHub_Winforms.Verification.usrIndustryBlock();
            this.usrHoldingsBlock2 = new JAHub_Winforms.Verification.usrHoldingsBlock();
            this.usrOrganizationsBlock1 = new JAHub_Winforms.Verification.usrOrganizationsBlock();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.flpRadaRegister.SuspendLayout();
            this.tlpNewOrConnectOptions.SuspendLayout();
            this.flpFormEntryControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpRadaRegister
            // 
            this.flpRadaRegister.AutoSize = true;
            this.flpRadaRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpRadaRegister.BackColor = System.Drawing.Color.Transparent;
            this.flpRadaRegister.Controls.Add(this.lblRegisterWithRada);
            this.flpRadaRegister.Controls.Add(this.tlpNewOrConnectOptions);
            this.flpRadaRegister.Controls.Add(this.lblMandatoryFields);
            this.flpRadaRegister.Controls.Add(this.flpFormEntryControls);
            this.flpRadaRegister.Controls.Add(this.btnSubmit);
            this.flpRadaRegister.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRadaRegister.Location = new System.Drawing.Point(0, 0);
            this.flpRadaRegister.Margin = new System.Windows.Forms.Padding(0);
            this.flpRadaRegister.Name = "flpRadaRegister";
            this.flpRadaRegister.Size = new System.Drawing.Size(601, 1477);
            this.flpRadaRegister.TabIndex = 0;
            this.flpRadaRegister.WrapContents = false;
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
            // tlpNewOrConnectOptions
            // 
            this.tlpNewOrConnectOptions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpNewOrConnectOptions.ColumnCount = 3;
            this.tlpNewOrConnectOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNewOrConnectOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpNewOrConnectOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNewOrConnectOptions.Controls.Add(this.lblOr, 1, 0);
            this.tlpNewOrConnectOptions.Controls.Add(this.btnNewRegistration, 0, 0);
            this.tlpNewOrConnectOptions.Controls.Add(this.btnConnectExistingAccount, 2, 0);
            this.tlpNewOrConnectOptions.Location = new System.Drawing.Point(4, 65);
            this.tlpNewOrConnectOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.tlpNewOrConnectOptions.Name = "tlpNewOrConnectOptions";
            this.tlpNewOrConnectOptions.RowCount = 1;
            this.tlpNewOrConnectOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNewOrConnectOptions.Size = new System.Drawing.Size(593, 58);
            this.tlpNewOrConnectOptions.TabIndex = 0;
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
            this.btnNewRegistration.Click += new System.EventHandler(this.btnNewRegistration_Click);
            // 
            // btnConnectExistingAccount
            // 
            this.btnConnectExistingAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConnectExistingAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectExistingAccount.Location = new System.Drawing.Point(322, 4);
            this.btnConnectExistingAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnectExistingAccount.Name = "btnConnectExistingAccount";
            this.btnConnectExistingAccount.Size = new System.Drawing.Size(172, 52);
            this.btnConnectExistingAccount.TabIndex = 1;
            this.btnConnectExistingAccount.Text = "Connect Existing Account";
            this.btnConnectExistingAccount.UseVisualStyleBackColor = true;
            this.btnConnectExistingAccount.Click += new System.EventHandler(this.btnConnectExistingAccount_Click);
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
            // flpFormEntryControls
            // 
            this.flpFormEntryControls.AutoSize = true;
            this.flpFormEntryControls.BackColor = System.Drawing.Color.Transparent;
            this.flpFormEntryControls.Controls.Add(this.usrNameBlock1);
            this.flpFormEntryControls.Controls.Add(this.usrDateOfBirthBlock1);
            this.flpFormEntryControls.Controls.Add(this.usrContactBlock1);
            this.flpFormEntryControls.Controls.Add(this.usrTrnBlock1);
            this.flpFormEntryControls.Controls.Add(this.usrUploadImageBlock1);
            this.flpFormEntryControls.Controls.Add(this.usrIndustryBlock1);
            this.flpFormEntryControls.Controls.Add(this.usrHoldingsBlock2);
            this.flpFormEntryControls.Controls.Add(this.usrOrganizationsBlock1);
            this.flpFormEntryControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFormEntryControls.Location = new System.Drawing.Point(4, 174);
            this.flpFormEntryControls.Margin = new System.Windows.Forms.Padding(4);
            this.flpFormEntryControls.Name = "flpFormEntryControls";
            this.flpFormEntryControls.Size = new System.Drawing.Size(572, 1242);
            this.flpFormEntryControls.TabIndex = 2;
            this.flpFormEntryControls.WrapContents = false;
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
            this.usrNameBlock1.Size = new System.Drawing.Size(313, 124);
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
            this.usrDateOfBirthBlock1.Size = new System.Drawing.Size(378, 105);
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
            this.usrContactBlock1.Size = new System.Drawing.Size(445, 172);
            this.usrContactBlock1.TabIndex = 2;
            // 
            // usrTrnBlock1
            // 
            this.usrTrnBlock1.AutoSize = true;
            this.usrTrnBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrTrnBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrTrnBlock1.Location = new System.Drawing.Point(4, 409);
            this.usrTrnBlock1.Margin = new System.Windows.Forms.Padding(4);
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
            this.usrUploadImageBlock1.Margin = new System.Windows.Forms.Padding(4);
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
            this.usrIndustryBlock1.Margin = new System.Windows.Forms.Padding(5);
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
            this.usrHoldingsBlock2.Location = new System.Drawing.Point(3, 701);
            this.usrHoldingsBlock2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.usrHoldingsBlock2.Name = "usrHoldingsBlock2";
            this.usrHoldingsBlock2.Size = new System.Drawing.Size(534, 356);
            this.usrHoldingsBlock2.TabIndex = 6;
            // 
            // usrOrganizationsBlock1
            // 
            this.usrOrganizationsBlock1.AutoSize = true;
            this.usrOrganizationsBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrOrganizationsBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrOrganizationsBlock1.Location = new System.Drawing.Point(4, 1066);
            this.usrOrganizationsBlock1.Margin = new System.Windows.Forms.Padding(4);
            this.usrOrganizationsBlock1.Name = "usrOrganizationsBlock1";
            this.usrOrganizationsBlock1.Size = new System.Drawing.Size(506, 172);
            this.usrOrganizationsBlock1.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(251, 1424);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 49);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmRadaRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 753);
            this.Controls.Add(this.flpRadaRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRadaRegister";
            this.Text = "Register With RADA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRadaRegister_Load);
            this.flpRadaRegister.ResumeLayout(false);
            this.flpRadaRegister.PerformLayout();
            this.tlpNewOrConnectOptions.ResumeLayout(false);
            this.tlpNewOrConnectOptions.PerformLayout();
            this.flpFormEntryControls.ResumeLayout(false);
            this.flpFormEntryControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRadaRegister;
        private System.Windows.Forms.TableLayoutPanel tlpNewOrConnectOptions;
        private System.Windows.Forms.Label lblRegisterWithRada;
        private System.Windows.Forms.Button btnConnectExistingAccount;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.FlowLayoutPanel flpFormEntryControls;
        private Verification.usrNameBlock usrNameBlock1;
        private Verification.usrDateOfBirthBlock usrDateOfBirthBlock1;
        private Verification.usrContactBlock usrContactBlock1;
        private Verification.usrTrnBlock usrTrnBlock1;
        private Verification.usrIndustryBlock usrIndustryBlock1;
        private Verification.usrUploadImageBlock usrUploadImageBlock1;
        private Verification.usrOrganizationsBlock usrOrganizationsBlock1;
        private System.Windows.Forms.Button btnSubmit;
        private Verification.usrHoldingsBlock usrHoldingsBlock2;
        private System.Windows.Forms.Label lblMandatoryFields;
        private System.Windows.Forms.Button btnNewRegistration;
    }
}