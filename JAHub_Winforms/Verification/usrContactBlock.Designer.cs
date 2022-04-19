using JAHubLib;

namespace JAHub_Winforms.Verification
{
    partial class usrContactBlock
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
            this.flpContactBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContantInformation = new System.Windows.Forms.Label();
            this.tblEmailSection = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.flpPhoneNumbers = new System.Windows.Forms.FlowLayoutPanel();
            this.usrPhoneNumberBlock1 = new JAHub_Winforms.Verification.usrPhoneNumberBlock();
            this.btnAddAnotherPhoneNumber = new System.Windows.Forms.Button();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.errContactBlock = new System.Windows.Forms.ErrorProvider(this.components);
            this.flpContactBlock.SuspendLayout();
            this.tblEmailSection.SuspendLayout();
            this.flpPhoneNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errContactBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // flpContactBlock
            // 
            this.flpContactBlock.AutoSize = true;
            this.flpContactBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpContactBlock.BackColor = System.Drawing.Color.Transparent;
            this.flpContactBlock.Controls.Add(this.lblContantInformation);
            this.flpContactBlock.Controls.Add(this.tblEmailSection);
            this.flpContactBlock.Controls.Add(this.flpPhoneNumbers);
            this.flpContactBlock.Controls.Add(this.btnAddAnotherPhoneNumber);
            this.flpContactBlock.Controls.Add(this.btnRemoveNumber);
            this.flpContactBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContactBlock.Location = new System.Drawing.Point(0, 0);
            this.flpContactBlock.Margin = new System.Windows.Forms.Padding(0);
            this.flpContactBlock.Name = "flpContactBlock";
            this.flpContactBlock.Size = new System.Drawing.Size(445, 210);
            this.flpContactBlock.TabIndex = 0;
            // 
            // lblContantInformation
            // 
            this.lblContantInformation.AutoSize = true;
            this.lblContantInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContantInformation.Location = new System.Drawing.Point(3, 0);
            this.lblContantInformation.Name = "lblContantInformation";
            this.lblContantInformation.Size = new System.Drawing.Size(181, 25);
            this.lblContantInformation.TabIndex = 0;
            this.lblContantInformation.Text = "Contact Information";
            // 
            // tblEmailSection
            // 
            this.tblEmailSection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblEmailSection.ColumnCount = 2;
            this.tblEmailSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tblEmailSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tblEmailSection.Controls.Add(this.lblEmail, 0, 0);
            this.tblEmailSection.Controls.Add(this.txtEmail, 1, 0);
            this.tblEmailSection.Location = new System.Drawing.Point(3, 28);
            this.tblEmailSection.Name = "tblEmailSection";
            this.tblEmailSection.RowCount = 1;
            this.tblEmailSection.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEmailSection.Size = new System.Drawing.Size(439, 46);
            this.tblEmailSection.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(180, 40);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email (If Different from Sign-Up Email)";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(193, 9);
            this.txtEmail.MaxLength = 75;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 27);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // flpPhoneNumbers
            // 
            this.flpPhoneNumbers.AutoSize = true;
            this.flpPhoneNumbers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpPhoneNumbers.Controls.Add(this.usrPhoneNumberBlock1);
            this.flpPhoneNumbers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPhoneNumbers.Location = new System.Drawing.Point(3, 80);
            this.flpPhoneNumbers.Name = "flpPhoneNumbers";
            this.flpPhoneNumbers.Size = new System.Drawing.Size(394, 51);
            this.flpPhoneNumbers.TabIndex = 5;
            // 
            // usrPhoneNumberBlock1
            // 
            this.usrPhoneNumberBlock1.AutoSize = true;
            this.usrPhoneNumberBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrPhoneNumberBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrPhoneNumberBlock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrPhoneNumberBlock1.Location = new System.Drawing.Point(4, 4);
            this.usrPhoneNumberBlock1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usrPhoneNumberBlock1.Name = "usrPhoneNumberBlock1";
            this.usrPhoneNumberBlock1.Size = new System.Drawing.Size(386, 43);
            this.usrPhoneNumberBlock1.TabIndex = 3;
            // 
            // btnAddAnotherPhoneNumber
            // 
            this.btnAddAnotherPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAnotherPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnotherPhoneNumber.Location = new System.Drawing.Point(3, 137);
            this.btnAddAnotherPhoneNumber.Name = "btnAddAnotherPhoneNumber";
            this.btnAddAnotherPhoneNumber.Size = new System.Drawing.Size(439, 32);
            this.btnAddAnotherPhoneNumber.TabIndex = 2;
            this.btnAddAnotherPhoneNumber.Text = "Add Another Phone Number";
            this.btnAddAnotherPhoneNumber.UseVisualStyleBackColor = true;
            this.btnAddAnotherPhoneNumber.Click += new System.EventHandler(this.btnAddAnotherPhoneNumber_Click);
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNumber.Location = new System.Drawing.Point(3, 175);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(439, 32);
            this.btnRemoveNumber.TabIndex = 4;
            this.btnRemoveNumber.Text = "Remove a Number";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Visible = false;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // errContactBlock
            // 
            this.errContactBlock.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errContactBlock.ContainerControl = this;
            // 
            // usrContactBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flpContactBlock);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "usrContactBlock";
            this.Size = new System.Drawing.Size(445, 210);
            this.flpContactBlock.ResumeLayout(false);
            this.flpContactBlock.PerformLayout();
            this.tblEmailSection.ResumeLayout(false);
            this.tblEmailSection.PerformLayout();
            this.flpPhoneNumbers.ResumeLayout(false);
            this.flpPhoneNumbers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errContactBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // This does the same thing as InitializeComponent, but allows the 
        // Controls to be prefilled with data
        private void InitializeFilledComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flpContactBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContantInformation = new System.Windows.Forms.Label();
            this.tblEmailSection = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.flpPhoneNumbers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddAnotherPhoneNumber = new System.Windows.Forms.Button();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.errContactBlock = new System.Windows.Forms.ErrorProvider(this.components);
            this.flpContactBlock.SuspendLayout();
            this.tblEmailSection.SuspendLayout();
            this.flpPhoneNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errContactBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // flwContactBlock
            // 
            this.flpContactBlock.AutoSize = true;
            this.flpContactBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpContactBlock.BackColor = System.Drawing.Color.Transparent;
            this.flpContactBlock.Controls.Add(this.lblContantInformation);
            this.flpContactBlock.Controls.Add(this.tblEmailSection);
            this.flpContactBlock.Controls.Add(this.flpPhoneNumbers);
            this.flpContactBlock.Controls.Add(this.btnAddAnotherPhoneNumber);
            this.flpContactBlock.Controls.Add(this.btnRemoveNumber);
            this.flpContactBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContactBlock.Location = new System.Drawing.Point(0, 0);
            this.flpContactBlock.Margin = new System.Windows.Forms.Padding(0);
            this.flpContactBlock.Name = "flwContactBlock";
            this.flpContactBlock.Size = new System.Drawing.Size(400, 210);
            this.flpContactBlock.TabIndex = 0;
            // 
            // lblContantInformation
            // 
            this.lblContantInformation.AutoSize = true;
            this.lblContantInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContantInformation.Location = new System.Drawing.Point(3, 0);
            this.lblContantInformation.Name = "lblContantInformation";
            this.lblContantInformation.Size = new System.Drawing.Size(181, 25);
            this.lblContantInformation.TabIndex = 0;
            this.lblContantInformation.Text = "Contact Information";
            // 
            // tblEmailSection
            // 
            this.tblEmailSection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblEmailSection.ColumnCount = 2;
            this.tblEmailSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tblEmailSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tblEmailSection.Controls.Add(this.lblEmail, 0, 0);
            this.tblEmailSection.Controls.Add(this.txtEmail, 1, 0);
            this.tblEmailSection.Location = new System.Drawing.Point(3, 28);
            this.tblEmailSection.Name = "tblEmailSection";
            this.tblEmailSection.RowCount = 1;
            this.tblEmailSection.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEmailSection.Size = new System.Drawing.Size(386, 46);
            this.tblEmailSection.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(180, 40);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email (If Different from Sign-Up Email)";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(193, 9);
            this.txtEmail.MaxLength = 65;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 27);
            this.txtEmail.TabIndex = 1;;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // flwPhoneNumbers
            // 
            this.flpPhoneNumbers.AutoSize = true;
            this.flpPhoneNumbers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpPhoneNumbers.Controls.Add(this.usrPhoneNumberBlock1);
            this.flpPhoneNumbers.Location = new System.Drawing.Point(3, 80);
            this.flpPhoneNumbers.Name = "flwPhoneNumbers";
            this.flpPhoneNumbers.Size = new System.Drawing.Size(394, 51);
            this.flpPhoneNumbers.TabIndex = 5;
            // 
            // btnAddAnotherPhoneNumber
            // 
            this.btnAddAnotherPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAnotherPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnotherPhoneNumber.Location = new System.Drawing.Point(3, 137);
            this.btnAddAnotherPhoneNumber.Name = "btnAddAnotherPhoneNumber";
            this.btnAddAnotherPhoneNumber.Size = new System.Drawing.Size(394, 32);
            this.btnAddAnotherPhoneNumber.TabIndex = 2;
            this.btnAddAnotherPhoneNumber.Text = "Add Another Phone Number";
            this.btnAddAnotherPhoneNumber.UseVisualStyleBackColor = true;
            this.btnAddAnotherPhoneNumber.Click += new System.EventHandler(this.btnAddAnotherPhoneNumber_Click);
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNumber.Location = new System.Drawing.Point(3, 175);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(394, 32);
            this.btnRemoveNumber.TabIndex = 4;
            this.btnRemoveNumber.Text = "Remove a Number";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Visible = false;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // errContactBlock
            // 
            this.errContactBlock.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errContactBlock.ContainerControl = this;
            // 
            // usrContactBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flpContactBlock);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "usrContactBlock";
            this.Size = new System.Drawing.Size(400, 210);
            this.flpContactBlock.ResumeLayout(false);
            this.flpContactBlock.PerformLayout();
            this.tblEmailSection.ResumeLayout(false);
            this.tblEmailSection.PerformLayout();
            this.flpPhoneNumbers.ResumeLayout(false);
            this.flpPhoneNumbers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errContactBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.FlowLayoutPanel flpContactBlock;
        private System.Windows.Forms.Label lblContantInformation;
        private System.Windows.Forms.TableLayoutPanel tblEmailSection;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAddAnotherPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ErrorProvider errContactBlock;
        private usrPhoneNumberBlock usrPhoneNumberBlock1;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.FlowLayoutPanel flpPhoneNumbers;
    }
}
