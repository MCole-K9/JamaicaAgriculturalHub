namespace JAHub_Winforms.Moderation
{
    partial class usrInfractionItem
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
            this.tblInfractionAdder = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.lblInfractionReason = new System.Windows.Forms.Label();
            this.btnRemoveInfraction = new System.Windows.Forms.Button();
            this.lblAddedById = new System.Windows.Forms.Label();
            this.tblInfractionAdder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblInfractionAdder
            // 
            this.tblInfractionAdder.ColumnCount = 4;
            this.tblInfractionAdder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblInfractionAdder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 384F));
            this.tblInfractionAdder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblInfractionAdder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblInfractionAdder.Controls.Add(this.lblTimeStamp, 0, 0);
            this.tblInfractionAdder.Controls.Add(this.lblInfractionReason, 1, 0);
            this.tblInfractionAdder.Controls.Add(this.btnRemoveInfraction, 3, 0);
            this.tblInfractionAdder.Controls.Add(this.lblAddedById, 2, 0);
            this.tblInfractionAdder.Location = new System.Drawing.Point(0, 0);
            this.tblInfractionAdder.Margin = new System.Windows.Forms.Padding(0);
            this.tblInfractionAdder.Name = "tblInfractionAdder";
            this.tblInfractionAdder.RowCount = 1;
            this.tblInfractionAdder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInfractionAdder.Size = new System.Drawing.Size(809, 38);
            this.tblInfractionAdder.TabIndex = 1;
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTimeStamp.AutoSize = true;
            this.lblTimeStamp.Location = new System.Drawing.Point(4, 9);
            this.lblTimeStamp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(109, 20);
            this.lblTimeStamp.TabIndex = 0;
            this.lblTimeStamp.Text = "XXXX-XX-XX";
            // 
            // lblInfractionReason
            // 
            this.lblInfractionReason.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInfractionReason.AutoSize = true;
            this.lblInfractionReason.Location = new System.Drawing.Point(121, 9);
            this.lblInfractionReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfractionReason.Name = "lblInfractionReason";
            this.lblInfractionReason.Size = new System.Drawing.Size(200, 20);
            this.lblInfractionReason.TabIndex = 1;
            this.lblInfractionReason.Text = "Text Reason for whatever";
            // 
            // btnRemoveInfraction
            // 
            this.btnRemoveInfraction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemoveInfraction.Location = new System.Drawing.Point(605, 4);
            this.btnRemoveInfraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveInfraction.Name = "btnRemoveInfraction";
            this.btnRemoveInfraction.Size = new System.Drawing.Size(33, 29);
            this.btnRemoveInfraction.TabIndex = 2;
            this.btnRemoveInfraction.Text = "X";
            this.btnRemoveInfraction.UseVisualStyleBackColor = true;
            // 
            // lblAddedById
            // 
            this.lblAddedById.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddedById.AutoSize = true;
            this.lblAddedById.Location = new System.Drawing.Point(504, 9);
            this.lblAddedById.Name = "lblAddedById";
            this.lblAddedById.Size = new System.Drawing.Size(53, 20);
            this.lblAddedById.TabIndex = 3;
            this.lblAddedById.Text = "label1";
            // 
            // usrInfractionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tblInfractionAdder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "usrInfractionItem";
            this.Size = new System.Drawing.Size(809, 38);
            this.tblInfractionAdder.ResumeLayout(false);
            this.tblInfractionAdder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblInfractionAdder;
        private System.Windows.Forms.Label lblTimeStamp;
        private System.Windows.Forms.Label lblInfractionReason;
        private System.Windows.Forms.Button btnRemoveInfraction;
        private System.Windows.Forms.Label lblAddedById;
    }
}
