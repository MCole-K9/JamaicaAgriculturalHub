namespace JAHub_Winforms.Verification
{
    partial class usrPhoneNumberBlock
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
            this.tblPhoneNumber = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.numberErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.tblPhoneNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPhoneNumber
            // 
            this.tblPhoneNumber.AutoSize = true;
            this.tblPhoneNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblPhoneNumber.ColumnCount = 2;
            this.tblPhoneNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblPhoneNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tblPhoneNumber.Controls.Add(this.lblPhoneNumber, 0, 0);
            this.tblPhoneNumber.Controls.Add(this.mskPhoneNumber, 1, 0);
            this.tblPhoneNumber.Location = new System.Drawing.Point(3, 3);
            this.tblPhoneNumber.Name = "tblPhoneNumber";
            this.tblPhoneNumber.RowCount = 1;
            this.tblPhoneNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPhoneNumber.Size = new System.Drawing.Size(302, 28);
            this.tblPhoneNumber.TabIndex = 0;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(144, 28);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberErrorProvider
            // 
            this.numberErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.numberErrorProvider.ContainerControl = this;
            // 
            // mskPhoneNumber
            // 
            this.mskPhoneNumber.Location = new System.Drawing.Point(153, 3);
            this.mskPhoneNumber.Mask = "1(999) 000-0000";
            this.mskPhoneNumber.Name = "mskPhoneNumber";
            this.mskPhoneNumber.Size = new System.Drawing.Size(125, 22);
            this.mskPhoneNumber.TabIndex = 1;
            this.mskPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.mskPhoneNumber_Validating);
            // 
            // usrPhoneNumberBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tblPhoneNumber);
            this.Name = "usrPhoneNumberBlock";
            this.Size = new System.Drawing.Size(308, 34);
            this.tblPhoneNumber.ResumeLayout(false);
            this.tblPhoneNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.ErrorProvider numberErrorProvider;
        private System.Windows.Forms.MaskedTextBox mskPhoneNumber;
    }
}
