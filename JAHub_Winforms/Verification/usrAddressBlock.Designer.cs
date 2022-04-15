namespace JAHub_Winforms.Verification
{
    partial class usrAddressBlock
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
            this.tblAddressBlock = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddressTown = new System.Windows.Forms.Label();
            this.lblAddressPostOffice = new System.Windows.Forms.Label();
            this.lblAddressParish = new System.Windows.Forms.Label();
            this.txtAddressTown = new System.Windows.Forms.TextBox();
            this.txtAddressPostOffice = new System.Windows.Forms.TextBox();
            this.txtAddressParish = new System.Windows.Forms.TextBox();
            this.errAddressBlock = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblAddressBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAddressBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAddressBlock
            // 
            this.tblAddressBlock.AutoSize = true;
            this.tblAddressBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblAddressBlock.BackColor = System.Drawing.Color.Transparent;
            this.tblAddressBlock.ColumnCount = 2;
            this.tblAddressBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblAddressBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblAddressBlock.Controls.Add(this.lblAddressTown, 0, 0);
            this.tblAddressBlock.Controls.Add(this.lblAddressPostOffice, 0, 1);
            this.tblAddressBlock.Controls.Add(this.lblAddressParish, 0, 2);
            this.tblAddressBlock.Controls.Add(this.txtAddressTown, 1, 0);
            this.tblAddressBlock.Controls.Add(this.txtAddressPostOffice, 1, 1);
            this.tblAddressBlock.Controls.Add(this.txtAddressParish, 1, 2);
            this.tblAddressBlock.Location = new System.Drawing.Point(0, 0);
            this.tblAddressBlock.Margin = new System.Windows.Forms.Padding(0);
            this.tblAddressBlock.Name = "tblAddressBlock";
            this.tblAddressBlock.RowCount = 3;
            this.tblAddressBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblAddressBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblAddressBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblAddressBlock.Size = new System.Drawing.Size(214, 120);
            this.tblAddressBlock.TabIndex = 0;
            // 
            // lblAddressTown
            // 
            this.lblAddressTown.AutoSize = true;
            this.lblAddressTown.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressTown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddressTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressTown.Location = new System.Drawing.Point(3, 0);
            this.lblAddressTown.Name = "lblAddressTown";
            this.lblAddressTown.Size = new System.Drawing.Size(58, 40);
            this.lblAddressTown.TabIndex = 0;
            this.lblAddressTown.Text = "Town";
            this.lblAddressTown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddressPostOffice
            // 
            this.lblAddressPostOffice.AutoSize = true;
            this.lblAddressPostOffice.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressPostOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddressPostOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressPostOffice.Location = new System.Drawing.Point(3, 40);
            this.lblAddressPostOffice.Name = "lblAddressPostOffice";
            this.lblAddressPostOffice.Size = new System.Drawing.Size(58, 40);
            this.lblAddressPostOffice.TabIndex = 1;
            this.lblAddressPostOffice.Text = "Post Office";
            this.lblAddressPostOffice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddressParish
            // 
            this.lblAddressParish.AutoSize = true;
            this.lblAddressParish.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressParish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddressParish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressParish.Location = new System.Drawing.Point(3, 80);
            this.lblAddressParish.Name = "lblAddressParish";
            this.lblAddressParish.Size = new System.Drawing.Size(58, 40);
            this.lblAddressParish.TabIndex = 2;
            this.lblAddressParish.Text = "Parish";
            this.lblAddressParish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddressTown
            // 
            this.txtAddressTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressTown.Location = new System.Drawing.Point(67, 3);
            this.txtAddressTown.Name = "txtAddressTown";
            this.txtAddressTown.Size = new System.Drawing.Size(125, 27);
            this.txtAddressTown.TabIndex = 3;
            this.txtAddressTown.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddressTown_Validating);
            // 
            // txtAddressPostOffice
            // 
            this.txtAddressPostOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressPostOffice.Location = new System.Drawing.Point(67, 43);
            this.txtAddressPostOffice.Name = "txtAddressPostOffice";
            this.txtAddressPostOffice.Size = new System.Drawing.Size(125, 27);
            this.txtAddressPostOffice.TabIndex = 4;
            this.txtAddressPostOffice.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddressPostOffice_Validating);
            // 
            // txtAddressParish
            // 
            this.txtAddressParish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressParish.Location = new System.Drawing.Point(67, 83);
            this.txtAddressParish.Name = "txtAddressParish";
            this.txtAddressParish.Size = new System.Drawing.Size(125, 27);
            this.txtAddressParish.TabIndex = 5;
            this.txtAddressParish.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddressParish_Validating);
            // 
            // errAddressBlock
            // 
            this.errAddressBlock.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errAddressBlock.ContainerControl = this;
            // 
            // usrAddressBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tblAddressBlock);
            this.Name = "usrAddressBlock";
            this.Size = new System.Drawing.Size(214, 120);
            this.tblAddressBlock.ResumeLayout(false);
            this.tblAddressBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAddressBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitializeFilledComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblAddressBlock = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddressTown = new System.Windows.Forms.Label();
            this.lblAddressPostOffice = new System.Windows.Forms.Label();
            this.lblAddressParish = new System.Windows.Forms.Label();
            this.txtAddressTown = new System.Windows.Forms.TextBox();
            this.txtAddressPostOffice = new System.Windows.Forms.TextBox();
            this.txtAddressParish = new System.Windows.Forms.TextBox();
            this.errAddressBlock = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblAddressBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAddressBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAddressBlock
            // 
            this.tblAddressBlock.AutoSize = true;
            this.tblAddressBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblAddressBlock.BackColor = System.Drawing.Color.Transparent;
            this.tblAddressBlock.ColumnCount = 2;
            this.tblAddressBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblAddressBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblAddressBlock.Controls.Add(this.lblAddressTown, 0, 0);
            this.tblAddressBlock.Controls.Add(this.lblAddressPostOffice, 0, 1);
            this.tblAddressBlock.Controls.Add(this.lblAddressParish, 0, 2);
            this.tblAddressBlock.Controls.Add(this.txtAddressTown, 1, 0);
            this.tblAddressBlock.Controls.Add(this.txtAddressPostOffice, 1, 1);
            this.tblAddressBlock.Controls.Add(this.txtAddressParish, 1, 2);
            this.tblAddressBlock.Location = new System.Drawing.Point(0, 0);
            this.tblAddressBlock.Margin = new System.Windows.Forms.Padding(0);
            this.tblAddressBlock.Name = "tblAddressBlock";
            this.tblAddressBlock.RowCount = 3;
            this.tblAddressBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblAddressBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblAddressBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblAddressBlock.Size = new System.Drawing.Size(214, 120);
            this.tblAddressBlock.TabIndex = 0;
            // 
            // lblAddressTown
            // 
            this.lblAddressTown.AutoSize = true;
            this.lblAddressTown.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressTown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddressTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressTown.Location = new System.Drawing.Point(3, 0);
            this.lblAddressTown.Name = "lblAddressTown";
            this.lblAddressTown.Size = new System.Drawing.Size(58, 40);
            this.lblAddressTown.TabIndex = 0;
            this.lblAddressTown.Text = "Town";
            this.lblAddressTown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddressPostOffice
            // 
            this.lblAddressPostOffice.AutoSize = true;
            this.lblAddressPostOffice.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressPostOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddressPostOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressPostOffice.Location = new System.Drawing.Point(3, 40);
            this.lblAddressPostOffice.Name = "lblAddressPostOffice";
            this.lblAddressPostOffice.Size = new System.Drawing.Size(58, 40);
            this.lblAddressPostOffice.TabIndex = 1;
            this.lblAddressPostOffice.Text = "Post Office";
            this.lblAddressPostOffice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddressParish
            // 
            this.lblAddressParish.AutoSize = true;
            this.lblAddressParish.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressParish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddressParish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressParish.Location = new System.Drawing.Point(3, 80);
            this.lblAddressParish.Name = "lblAddressParish";
            this.lblAddressParish.Size = new System.Drawing.Size(58, 40);
            this.lblAddressParish.TabIndex = 2;
            this.lblAddressParish.Text = "Parish";
            this.lblAddressParish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddressTown
            // 
            this.txtAddressTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressTown.Location = new System.Drawing.Point(67, 3);
            this.txtAddressTown.Name = "txtAddressTown";
            this.txtAddressTown.Size = new System.Drawing.Size(125, 27);
            this.txtAddressTown.TabIndex = 3;
            this.txtAddressTown.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddressTown_Validating);
            // 
            // txtAddressPostOffice
            // 
            this.txtAddressPostOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressPostOffice.Location = new System.Drawing.Point(67, 43);
            this.txtAddressPostOffice.Name = "txtAddressPostOffice";
            this.txtAddressPostOffice.Size = new System.Drawing.Size(125, 27);
            this.txtAddressPostOffice.TabIndex = 4;
            this.txtAddressPostOffice.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddressPostOffice_Validating);
            // 
            // txtAddressParish
            // 
            this.txtAddressParish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressParish.Location = new System.Drawing.Point(67, 83);
            this.txtAddressParish.Name = "txtAddressParish";
            this.txtAddressParish.Size = new System.Drawing.Size(125, 27);
            this.txtAddressParish.TabIndex = 5;
            this.txtAddressParish.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddressParish_Validating);
            // 
            // errAddressBlock
            // 
            this.errAddressBlock.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errAddressBlock.ContainerControl = this;
            // 
            // usrAddressBlock
            // 
            this.Enabled = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tblAddressBlock);
            this.Name = "usrAddressBlock";
            this.Size = new System.Drawing.Size(214, 120);
            this.tblAddressBlock.ResumeLayout(false);
            this.tblAddressBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAddressBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TableLayoutPanel tblAddressBlock;
        private System.Windows.Forms.Label lblAddressTown;
        private System.Windows.Forms.Label lblAddressPostOffice;
        private System.Windows.Forms.Label lblAddressParish;
        private System.Windows.Forms.TextBox txtAddressTown;
        private System.Windows.Forms.TextBox txtAddressPostOffice;
        private System.Windows.Forms.TextBox txtAddressParish;
        private System.Windows.Forms.ErrorProvider errAddressBlock;
    }
}
