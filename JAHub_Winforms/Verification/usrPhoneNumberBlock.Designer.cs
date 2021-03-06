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
            this.tlpPhoneNumber = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.mskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.errPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpPhoneNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPhoneNumber
            // 
            this.tlpPhoneNumber.AutoSize = true;
            this.tlpPhoneNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.tlpPhoneNumber.ColumnCount = 2;
            this.tlpPhoneNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpPhoneNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tlpPhoneNumber.Controls.Add(this.lblPhoneNumber, 0, 0);
            this.tlpPhoneNumber.Controls.Add(this.mskPhoneNumber, 1, 0);
            this.tlpPhoneNumber.Location = new System.Drawing.Point(3, 3);
            this.tlpPhoneNumber.Name = "tlpPhoneNumber";
            this.tlpPhoneNumber.RowCount = 1;
            this.tlpPhoneNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhoneNumber.Size = new System.Drawing.Size(302, 33);
            this.tlpPhoneNumber.TabIndex = 0;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(144, 33);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number*";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mskPhoneNumber
            // 
            this.mskPhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPhoneNumber.Location = new System.Drawing.Point(153, 3);
            this.mskPhoneNumber.Mask = "1(999) 000-0000";
            this.mskPhoneNumber.Name = "mskPhoneNumber";
            this.mskPhoneNumber.Size = new System.Drawing.Size(125, 27);
            this.mskPhoneNumber.TabIndex = 1;
            this.mskPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.mskPhoneNumber_Validating);
            // 
            // errPhoneNumber
            // 
            this.errPhoneNumber.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errPhoneNumber.ContainerControl = this;
            // 
            // usrPhoneNumberBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpPhoneNumber);
            this.Name = "usrPhoneNumberBlock";
            this.Size = new System.Drawing.Size(308, 39);
            this.tlpPhoneNumber.ResumeLayout(false);
            this.tlpPhoneNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPhoneNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.ErrorProvider errPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mskPhoneNumber;
    }
}
