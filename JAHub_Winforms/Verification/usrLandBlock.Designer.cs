namespace JAHub_Winforms.Verification
{
    partial class usrLandBlock
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
            this.tblLandBlock = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLandMeasurement = new System.Windows.Forms.Label();
            this.usrAddressBlock1 = new JAHub_Winforms.Verification.usrAddressBlock();
            this.nudLandMeasurement = new System.Windows.Forms.NumericUpDown();
            this.errLandBlock = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblLandBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandMeasurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLandBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLandBlock
            // 
            this.tblLandBlock.AutoSize = true;
            this.tblLandBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLandBlock.BackColor = System.Drawing.Color.Transparent;
            this.tblLandBlock.ColumnCount = 2;
            this.tblLandBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblLandBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLandBlock.Controls.Add(this.lblAddress, 0, 0);
            this.tblLandBlock.Controls.Add(this.lblLandMeasurement, 0, 1);
            this.tblLandBlock.Controls.Add(this.usrAddressBlock1, 1, 0);
            this.tblLandBlock.Controls.Add(this.nudLandMeasurement, 1, 1);
            this.tblLandBlock.Location = new System.Drawing.Point(3, 3);
            this.tblLandBlock.Name = "tblLandBlock";
            this.tblLandBlock.RowCount = 2;
            this.tblLandBlock.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLandBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLandBlock.Size = new System.Drawing.Size(360, 186);
            this.tblLandBlock.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(3, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(134, 126);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address (if Different from Mailing Address)";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLandMeasurement
            // 
            this.lblLandMeasurement.AutoSize = true;
            this.lblLandMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLandMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandMeasurement.Location = new System.Drawing.Point(3, 126);
            this.lblLandMeasurement.Name = "lblLandMeasurement";
            this.lblLandMeasurement.Size = new System.Drawing.Size(134, 60);
            this.lblLandMeasurement.TabIndex = 1;
            this.lblLandMeasurement.Text = "Land Measurement (In Hectares)*";
            this.lblLandMeasurement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usrAddressBlock1
            // 
            this.usrAddressBlock1.AutoSize = true;
            this.usrAddressBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrAddressBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrAddressBlock1.Location = new System.Drawing.Point(143, 3);
            this.usrAddressBlock1.Name = "usrAddressBlock1";
            this.usrAddressBlock1.Size = new System.Drawing.Size(214, 120);
            this.usrAddressBlock1.TabIndex = 3;
            // 
            // nudLandMeasurement
            // 
            this.nudLandMeasurement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudLandMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLandMeasurement.Location = new System.Drawing.Point(143, 142);
            this.nudLandMeasurement.Name = "nudLandMeasurement";
            this.nudLandMeasurement.Size = new System.Drawing.Size(120, 27);
            this.nudLandMeasurement.TabIndex = 4;
            this.nudLandMeasurement.ValueChanged += new System.EventHandler(this.nudLandMeasurement_ValueChanged);
            this.nudLandMeasurement.Validating += new System.ComponentModel.CancelEventHandler(this.nudLandMeasurement_Validating);
            // 
            // errLandBlock
            // 
            this.errLandBlock.ContainerControl = this;
            // 
            // usrLandBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tblLandBlock);
            this.Name = "usrLandBlock";
            this.Size = new System.Drawing.Size(366, 192);
            this.tblLandBlock.ResumeLayout(false);
            this.tblLandBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandMeasurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLandBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitializeFilledComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblLandBlock = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLandMeasurement = new System.Windows.Forms.Label();
            this.nudLandMeasurement = new System.Windows.Forms.NumericUpDown();
            this.errLandBlock = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblLandBlock.SuspendLayout();
            this.usrAddressBlock1 = new usrAddressBlock();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandMeasurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLandBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLandBlock
            // 
            this.tblLandBlock.AutoSize = true;
            this.tblLandBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLandBlock.BackColor = System.Drawing.Color.Transparent;
            this.tblLandBlock.ColumnCount = 2;
            this.tblLandBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblLandBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLandBlock.Controls.Add(this.lblAddress, 0, 0);
            this.tblLandBlock.Controls.Add(this.lblLandMeasurement, 0, 1);
            
            this.tblLandBlock.Controls.Add(this.nudLandMeasurement, 1, 1);
            this.tblLandBlock.Location = new System.Drawing.Point(3, 3);
            this.tblLandBlock.Name = "tblLandBlock";
            this.tblLandBlock.RowCount = 2;
            this.tblLandBlock.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLandBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLandBlock.Size = new System.Drawing.Size(360, 186);
            this.tblLandBlock.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(3, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(134, 126);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address (if Different from Mailing Address)";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLandMeasurement
            // 
            this.lblLandMeasurement.AutoSize = true;
            this.lblLandMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLandMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandMeasurement.Location = new System.Drawing.Point(3, 126);
            this.lblLandMeasurement.Name = "lblLandMeasurement";
            this.lblLandMeasurement.Size = new System.Drawing.Size(134, 60);
            this.lblLandMeasurement.TabIndex = 1;
            this.lblLandMeasurement.Text = "Land Measurement (In Hectares)*";
            this.lblLandMeasurement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usrAddressBlock1
            // 
            this.usrAddressBlock1.AutoSize = true;
            this.usrAddressBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrAddressBlock1.BackColor = System.Drawing.Color.Transparent;
            this.usrAddressBlock1.Location = new System.Drawing.Point(143, 3);
            this.usrAddressBlock1.Name = "usrAddressBlock1";
            this.usrAddressBlock1.Size = new System.Drawing.Size(214, 120);
            this.usrAddressBlock1.TabIndex = 3;
            // 
            // nudLandMeasurement
            // 
            this.nudLandMeasurement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudLandMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLandMeasurement.Location = new System.Drawing.Point(143, 142);
            this.nudLandMeasurement.Name = "nudLandMeasurement";
            this.nudLandMeasurement.Size = new System.Drawing.Size(120, 27);
            this.nudLandMeasurement.TabIndex = 4;
            this.nudLandMeasurement.Validating += new System.ComponentModel.CancelEventHandler(this.nudLandMeasurement_Validating);
            // 
            // errLandBlock
            // 
            this.errLandBlock.ContainerControl = this;
            // 
            // usrLandBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tblLandBlock);
            this.Name = "usrLandBlock";
            this.Size = new System.Drawing.Size(366, 192);
            this.tblLandBlock.ResumeLayout(false);
            this.tblLandBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandMeasurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLandBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TableLayoutPanel tblLandBlock;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLandMeasurement;
        private System.Windows.Forms.ErrorProvider errLandBlock;
        private usrAddressBlock usrAddressBlock1;
        private System.Windows.Forms.NumericUpDown nudLandMeasurement;
    }
}
