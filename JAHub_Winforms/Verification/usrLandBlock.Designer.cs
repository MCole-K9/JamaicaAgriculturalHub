namespace JAHubLib.Verification
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLandMeasurement = new System.Windows.Forms.Label();
            this.landBlockErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.usrAddressBlock1 = new JAHubLib.Verification.usrAddressBlock();
            this.nudLandMeasurement = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.landBlockErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandMeasurement)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLandMeasurement, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.usrAddressBlock1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudLandMeasurement, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 160);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(3, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(94, 100);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address (if Different from Mailing Address)";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLandMeasurement
            // 
            this.lblLandMeasurement.AutoSize = true;
            this.lblLandMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLandMeasurement.Location = new System.Drawing.Point(3, 100);
            this.lblLandMeasurement.Name = "lblLandMeasurement";
            this.lblLandMeasurement.Size = new System.Drawing.Size(94, 60);
            this.lblLandMeasurement.TabIndex = 1;
            this.lblLandMeasurement.Text = "Land Measurement (In Hectares)";
            this.lblLandMeasurement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // landBlockErrorProvider
            // 
            this.landBlockErrorProvider.ContainerControl = this;
            // 
            // usrAddressBlock1
            // 
            this.usrAddressBlock1.AutoSize = true;
            this.usrAddressBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrAddressBlock1.Location = new System.Drawing.Point(103, 3);
            this.usrAddressBlock1.Name = "usrAddressBlock1";
            this.usrAddressBlock1.Size = new System.Drawing.Size(214, 94);
            this.usrAddressBlock1.TabIndex = 3;
            // 
            // nudLandMeasurement
            // 
            this.nudLandMeasurement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudLandMeasurement.Location = new System.Drawing.Point(103, 119);
            this.nudLandMeasurement.Name = "nudLandMeasurement";
            this.nudLandMeasurement.Size = new System.Drawing.Size(120, 22);
            this.nudLandMeasurement.TabIndex = 4;
            this.nudLandMeasurement.Validating += new System.ComponentModel.CancelEventHandler(this.nudLandMeasurement_Validating);
            // 
            // usrLandBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "usrLandBlock";
            this.Size = new System.Drawing.Size(326, 166);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.landBlockErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandMeasurement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLandMeasurement;
        private System.Windows.Forms.ErrorProvider landBlockErrorProvider;
        private usrAddressBlock usrAddressBlock1;
        private System.Windows.Forms.NumericUpDown nudLandMeasurement;
    }
}
