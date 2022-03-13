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
            this.flwContactBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContantInformation = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddAnotherPhoneNumber = new System.Windows.Forms.Button();
            this.contactBlockErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.usrPhoneNumberBlock1 = new JAHub_Winforms.Verification.usrPhoneNumberBlock();
            this.flwContactBlock.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBlockErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // flwContactBlock
            // 
            this.flwContactBlock.AutoSize = true;
            this.flwContactBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwContactBlock.Controls.Add(this.lblContantInformation);
            this.flwContactBlock.Controls.Add(this.tableLayoutPanel1);
            this.flwContactBlock.Controls.Add(this.usrPhoneNumberBlock1);
            this.flwContactBlock.Controls.Add(this.btnAddAnotherPhoneNumber);
            this.flwContactBlock.Controls.Add(this.btnRemoveNumber);
            this.flwContactBlock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwContactBlock.Location = new System.Drawing.Point(0, 0);
            this.flwContactBlock.Margin = new System.Windows.Forms.Padding(0);
            this.flwContactBlock.Name = "flwContactBlock";
            this.flwContactBlock.Size = new System.Drawing.Size(314, 152);
            this.flwContactBlock.TabIndex = 0;
            // 
            // lblContantInformation
            // 
            this.lblContantInformation.AutoSize = true;
            this.lblContantInformation.Location = new System.Drawing.Point(3, 0);
            this.lblContantInformation.Name = "lblContantInformation";
            this.lblContantInformation.Size = new System.Drawing.Size(120, 16);
            this.lblContantInformation.TabIndex = 0;
            this.lblContantInformation.Text = "Contact Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 32);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(138, 32);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email (If Different from Sign-Up Email)";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 3);
            this.txtEmail.MaxLength = 65;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // btnAddAnotherPhoneNumber
            // 
            this.btnAddAnotherPhoneNumber.Location = new System.Drawing.Point(3, 97);
            this.btnAddAnotherPhoneNumber.Name = "btnAddAnotherPhoneNumber";
            this.btnAddAnotherPhoneNumber.Size = new System.Drawing.Size(167, 23);
            this.btnAddAnotherPhoneNumber.TabIndex = 2;
            this.btnAddAnotherPhoneNumber.Text = "Add Another Phone Number";
            this.btnAddAnotherPhoneNumber.UseVisualStyleBackColor = true;
            this.btnAddAnotherPhoneNumber.Click += new System.EventHandler(this.btnAddAnotherPhoneNumber_Click);
            // 
            // contactBlockErrorProvider
            // 
            this.contactBlockErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.contactBlockErrorProvider.ContainerControl = this;
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Location = new System.Drawing.Point(3, 126);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(167, 23);
            this.btnRemoveNumber.TabIndex = 4;
            this.btnRemoveNumber.Text = "Remove a Number";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Visible = false;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // usrPhoneNumberBlock1
            // 
            this.usrPhoneNumberBlock1.AutoSize = true;
            this.usrPhoneNumberBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrPhoneNumberBlock1.Location = new System.Drawing.Point(3, 57);
            this.usrPhoneNumberBlock1.Name = "usrPhoneNumberBlock1";
            this.usrPhoneNumberBlock1.Size = new System.Drawing.Size(308, 34);
            this.usrPhoneNumberBlock1.TabIndex = 3;
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
            this.Size = new System.Drawing.Size(314, 152);
            this.flwContactBlock.ResumeLayout(false);
            this.flwContactBlock.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBlockErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwContactBlock;
        private System.Windows.Forms.Label lblContantInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAddAnotherPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ErrorProvider contactBlockErrorProvider;
        private usrPhoneNumberBlock usrPhoneNumberBlock1;
        private System.Windows.Forms.Button btnRemoveNumber;
    }
}
