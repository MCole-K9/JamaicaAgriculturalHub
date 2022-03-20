namespace JAHub_Winforms.Verifcation
{
    partial class usrIndustryBlock
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
            this.tblIndustryBlock = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumberOfEmployees = new System.Windows.Forms.Label();
            this.lblHeavyMachinery = new System.Windows.Forms.Label();
            this.rdoIndustryYes = new System.Windows.Forms.RadioButton();
            this.rdoIndustryNo = new System.Windows.Forms.RadioButton();
            this.nudNumberOfEmployees = new System.Windows.Forms.NumericUpDown();
            this.errIndustryBlock = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblIndustryBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIndustryBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // tblIndustryBlock
            // 
            this.tblIndustryBlock.AutoSize = true;
            this.tblIndustryBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblIndustryBlock.BackColor = System.Drawing.Color.Transparent;
            this.tblIndustryBlock.ColumnCount = 2;
            this.tblIndustryBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblIndustryBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblIndustryBlock.Controls.Add(this.lblNumberOfEmployees, 0, 0);
            this.tblIndustryBlock.Controls.Add(this.lblHeavyMachinery, 0, 1);
            this.tblIndustryBlock.Controls.Add(this.rdoIndustryYes, 0, 2);
            this.tblIndustryBlock.Controls.Add(this.rdoIndustryNo, 1, 2);
            this.tblIndustryBlock.Controls.Add(this.nudNumberOfEmployees, 1, 0);
            this.tblIndustryBlock.Location = new System.Drawing.Point(0, 0);
            this.tblIndustryBlock.Margin = new System.Windows.Forms.Padding(0);
            this.tblIndustryBlock.MaximumSize = new System.Drawing.Size(562, 0);
            this.tblIndustryBlock.Name = "tblIndustryBlock";
            this.tblIndustryBlock.RowCount = 3;
            this.tblIndustryBlock.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIndustryBlock.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIndustryBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblIndustryBlock.Size = new System.Drawing.Size(562, 125);
            this.tblIndustryBlock.TabIndex = 0;
            // 
            // lblNumberOfEmployees
            // 
            this.lblNumberOfEmployees.AutoSize = true;
            this.lblNumberOfEmployees.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfEmployees.Location = new System.Drawing.Point(4, 0);
            this.lblNumberOfEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfEmployees.Name = "lblNumberOfEmployees";
            this.lblNumberOfEmployees.Size = new System.Drawing.Size(180, 20);
            this.lblNumberOfEmployees.TabIndex = 0;
            this.lblNumberOfEmployees.Text = "Number of Employees*";
            // 
            // lblHeavyMachinery
            // 
            this.lblHeavyMachinery.BackColor = System.Drawing.Color.Transparent;
            this.tblIndustryBlock.SetColumnSpan(this.lblHeavyMachinery, 2);
            this.lblHeavyMachinery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeavyMachinery.Location = new System.Drawing.Point(4, 35);
            this.lblHeavyMachinery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeavyMachinery.Name = "lblHeavyMachinery";
            this.lblHeavyMachinery.Size = new System.Drawing.Size(554, 50);
            this.lblHeavyMachinery.TabIndex = 1;
            this.lblHeavyMachinery.Text = "Do you use heavy machinery such as tractors, processors, or other forms of powere" +
    "d equipment?*\r\n";
            // 
            // rdoIndustryYes
            // 
            this.rdoIndustryYes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoIndustryYes.AutoSize = true;
            this.rdoIndustryYes.BackColor = System.Drawing.Color.Transparent;
            this.rdoIndustryYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIndustryYes.Location = new System.Drawing.Point(4, 89);
            this.rdoIndustryYes.Margin = new System.Windows.Forms.Padding(4);
            this.rdoIndustryYes.Name = "rdoIndustryYes";
            this.rdoIndustryYes.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rdoIndustryYes.Size = new System.Drawing.Size(180, 32);
            this.rdoIndustryYes.TabIndex = 2;
            this.rdoIndustryYes.TabStop = true;
            this.rdoIndustryYes.Text = "Yes";
            this.rdoIndustryYes.UseVisualStyleBackColor = false;
            this.rdoIndustryYes.Validating += new System.ComponentModel.CancelEventHandler(this.rdoIndustryYes_Validating);
            // 
            // rdoIndustryNo
            // 
            this.rdoIndustryNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoIndustryNo.AutoSize = true;
            this.rdoIndustryNo.BackColor = System.Drawing.Color.Transparent;
            this.rdoIndustryNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIndustryNo.Location = new System.Drawing.Point(192, 89);
            this.rdoIndustryNo.Margin = new System.Windows.Forms.Padding(4);
            this.rdoIndustryNo.Name = "rdoIndustryNo";
            this.rdoIndustryNo.Size = new System.Drawing.Size(366, 32);
            this.rdoIndustryNo.TabIndex = 3;
            this.rdoIndustryNo.TabStop = true;
            this.rdoIndustryNo.Text = "No";
            this.rdoIndustryNo.UseVisualStyleBackColor = false;
            this.rdoIndustryNo.Validating += new System.ComponentModel.CancelEventHandler(this.rdoIndustryNo_Validating);
            // 
            // nudNumberOfEmployees
            // 
            this.nudNumberOfEmployees.Location = new System.Drawing.Point(192, 4);
            this.nudNumberOfEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.nudNumberOfEmployees.Name = "nudNumberOfEmployees";
            this.nudNumberOfEmployees.Size = new System.Drawing.Size(118, 27);
            this.nudNumberOfEmployees.TabIndex = 4;
            // 
            // errIndustryBlock
            // 
            this.errIndustryBlock.ContainerControl = this;
            // 
            // usrIndustryBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tblIndustryBlock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(562, 0);
            this.Name = "usrIndustryBlock";
            this.Size = new System.Drawing.Size(562, 125);
            this.tblIndustryBlock.ResumeLayout(false);
            this.tblIndustryBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIndustryBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblIndustryBlock;
        private System.Windows.Forms.Label lblNumberOfEmployees;
        private System.Windows.Forms.Label lblHeavyMachinery;
        private System.Windows.Forms.RadioButton rdoIndustryYes;
        private System.Windows.Forms.RadioButton rdoIndustryNo;
        private System.Windows.Forms.NumericUpDown nudNumberOfEmployees;
        private System.Windows.Forms.ErrorProvider errIndustryBlock;
    }
}
