namespace JAHub_Winforms.Moderation
{
    partial class usrInfractionAdder
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInfractionReason = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblTimeStamp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInfractionReason, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(609, 38);
            this.tableLayoutPanel1.TabIndex = 2;
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
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSubmit.Location = new System.Drawing.Point(505, 4);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 29);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtInfractionReason
            // 
            this.txtInfractionReason.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInfractionReason.Location = new System.Drawing.Point(120, 5);
            this.txtInfractionReason.Name = "txtInfractionReason";
            this.txtInfractionReason.Size = new System.Drawing.Size(378, 27);
            this.txtInfractionReason.TabIndex = 3;
            // 
            // usrInfractionAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usrInfractionAdder";
            this.Size = new System.Drawing.Size(609, 38);
            this.Load += new System.EventHandler(this.usrInfractionEntry_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTimeStamp;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtInfractionReason;
    }
}
