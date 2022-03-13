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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumberOfEmployees = new System.Windows.Forms.Label();
            this.lblHeavyMachinery = new System.Windows.Forms.Label();
            this.rdoIndustryYes = new System.Windows.Forms.RadioButton();
            this.rdoIndustryNo = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.errIndustryBlock = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIndustryBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblNumberOfEmployees, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHeavyMachinery, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdoIndustryYes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rdoIndustryNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 95);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNumberOfEmployees
            // 
            this.lblNumberOfEmployees.AutoSize = true;
            this.lblNumberOfEmployees.Location = new System.Drawing.Point(3, 0);
            this.lblNumberOfEmployees.Name = "lblNumberOfEmployees";
            this.lblNumberOfEmployees.Size = new System.Drawing.Size(141, 16);
            this.lblNumberOfEmployees.TabIndex = 0;
            this.lblNumberOfEmployees.Text = "Number of Employees";
            // 
            // lblHeavyMachinery
            // 
            this.lblHeavyMachinery.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblHeavyMachinery, 2);
            this.lblHeavyMachinery.Location = new System.Drawing.Point(3, 28);
            this.lblHeavyMachinery.Name = "lblHeavyMachinery";
            this.lblHeavyMachinery.Size = new System.Drawing.Size(305, 32);
            this.lblHeavyMachinery.TabIndex = 1;
            this.lblHeavyMachinery.Text = "Do you use heavy machinery such as tractors, processors, or other forms of powere" +
    "d equipment?";
            // 
            // rdoIndustryYes
            // 
            this.rdoIndustryYes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoIndustryYes.AutoSize = true;
            this.rdoIndustryYes.Location = new System.Drawing.Point(3, 63);
            this.rdoIndustryYes.Name = "rdoIndustryYes";
            this.rdoIndustryYes.Size = new System.Drawing.Size(170, 29);
            this.rdoIndustryYes.TabIndex = 2;
            this.rdoIndustryYes.TabStop = true;
            this.rdoIndustryYes.Text = "Yes";
            this.rdoIndustryYes.UseVisualStyleBackColor = true;
            this.rdoIndustryYes.Validating += new System.ComponentModel.CancelEventHandler(this.rdoIndustryYes_Validating);
            // 
            // rdoIndustryNo
            // 
            this.rdoIndustryNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoIndustryNo.AutoSize = true;
            this.rdoIndustryNo.Location = new System.Drawing.Point(179, 63);
            this.rdoIndustryNo.Name = "rdoIndustryNo";
            this.rdoIndustryNo.Size = new System.Drawing.Size(171, 29);
            this.rdoIndustryNo.TabIndex = 3;
            this.rdoIndustryNo.TabStop = true;
            this.rdoIndustryNo.Text = "No";
            this.rdoIndustryNo.UseVisualStyleBackColor = true;
            this.rdoIndustryNo.Validating += new System.ComponentModel.CancelEventHandler(this.rdoIndustryNo_Validating);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(179, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(94, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // errIndustryBlock
            // 
            this.errIndustryBlock.ContainerControl = this;
            // 
            // usrIndustryBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "usrIndustryBlock";
            this.Size = new System.Drawing.Size(353, 98);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIndustryBlock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNumberOfEmployees;
        private System.Windows.Forms.Label lblHeavyMachinery;
        private System.Windows.Forms.RadioButton rdoIndustryYes;
        private System.Windows.Forms.RadioButton rdoIndustryNo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ErrorProvider errIndustryBlock;
    }
}
