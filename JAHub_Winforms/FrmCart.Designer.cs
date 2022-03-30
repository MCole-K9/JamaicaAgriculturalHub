namespace JAHub_Winforms
{
    partial class FrmCart
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fpnlCart = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fpnlCart
            // 
            this.fpnlCart.AutoScroll = true;
            this.fpnlCart.Location = new System.Drawing.Point(1, 38);
            this.fpnlCart.Name = "fpnlCart";
            this.fpnlCart.Size = new System.Drawing.Size(723, 351);
            this.fpnlCart.TabIndex = 0;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(505, 392);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(193, 20);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "Subtotal (Items: 1): $0000";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(542, 415);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(132, 23);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Proceed to Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // FrmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.fpnlCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCart";
            this.Text = "FrmCart";
            this.Load += new System.EventHandler(this.FrmCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlCart;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnCheckOut;
    }
}