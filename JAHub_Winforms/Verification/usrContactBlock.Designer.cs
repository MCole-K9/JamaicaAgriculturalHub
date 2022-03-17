﻿namespace JAHub_Winforms.Verification
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
            this.flwContactBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContantInformation = new System.Windows.Forms.Label();
            this.tblEmailSection = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.usrPhoneNumberBlock1 = new JAHub_Winforms.Verification.usrPhoneNumberBlock();
            this.btnAddAnotherPhoneNumber = new System.Windows.Forms.Button();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.contactBlockErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.flwContactBlock.SuspendLayout();
            this.tblEmailSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBlockErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // flwContactBlock
            // 
            this.flwContactBlock.AutoSize = true;
            this.flwContactBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwContactBlock.Controls.Add(this.lblContantInformation);
            this.flwContactBlock.Controls.Add(this.tblEmailSection);
            this.flwContactBlock.Controls.Add(this.usrPhoneNumberBlock1);
            this.flwContactBlock.Controls.Add(this.btnAddAnotherPhoneNumber);
            this.flwContactBlock.Controls.Add(this.btnRemoveNumber);
            this.flwContactBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwContactBlock.Location = new System.Drawing.Point(0, 0);
            this.flwContactBlock.Margin = new System.Windows.Forms.Padding(0);
            this.flwContactBlock.Name = "flwContactBlock";
            this.flwContactBlock.Size = new System.Drawing.Size(392, 202);
            this.flwContactBlock.TabIndex = 0;
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
            this.tblEmailSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
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
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // usrPhoneNumberBlock1
            // 
            this.usrPhoneNumberBlock1.AutoSize = true;
            this.usrPhoneNumberBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrPhoneNumberBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrPhoneNumberBlock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrPhoneNumberBlock1.Location = new System.Drawing.Point(3, 80);
            this.usrPhoneNumberBlock1.Name = "usrPhoneNumberBlock1";
            this.usrPhoneNumberBlock1.Size = new System.Drawing.Size(386, 43);
            this.usrPhoneNumberBlock1.TabIndex = 3;
            // 
            // btnAddAnotherPhoneNumber
            // 
            this.btnAddAnotherPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAnotherPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnotherPhoneNumber.Location = new System.Drawing.Point(3, 129);
            this.btnAddAnotherPhoneNumber.Name = "btnAddAnotherPhoneNumber";
            this.btnAddAnotherPhoneNumber.Size = new System.Drawing.Size(386, 32);
            this.btnAddAnotherPhoneNumber.TabIndex = 2;
            this.btnAddAnotherPhoneNumber.Text = "Add Another Phone Number";
            this.btnAddAnotherPhoneNumber.UseVisualStyleBackColor = true;
            this.btnAddAnotherPhoneNumber.Click += new System.EventHandler(this.btnAddAnotherPhoneNumber_Click);
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNumber.Location = new System.Drawing.Point(3, 167);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(386, 32);
            this.btnRemoveNumber.TabIndex = 4;
            this.btnRemoveNumber.Text = "Remove a Number";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Visible = false;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // contactBlockErrorProvider
            // 
            this.contactBlockErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.contactBlockErrorProvider.ContainerControl = this;
            // 
            // usrContactBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flwContactBlock);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "usrContactBlock";
            this.Size = new System.Drawing.Size(392, 202);
            this.flwContactBlock.ResumeLayout(false);
            this.flwContactBlock.PerformLayout();
            this.tblEmailSection.ResumeLayout(false);
            this.tblEmailSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBlockErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwContactBlock;
        private System.Windows.Forms.Label lblContantInformation;
        private System.Windows.Forms.TableLayoutPanel tblEmailSection;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAddAnotherPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ErrorProvider contactBlockErrorProvider;
        private usrPhoneNumberBlock usrPhoneNumberBlock1;
        private System.Windows.Forms.Button btnRemoveNumber;
    }
}
