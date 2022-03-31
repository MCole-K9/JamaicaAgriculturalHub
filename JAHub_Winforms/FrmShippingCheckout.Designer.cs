namespace JAHub_Winforms
{
    partial class FrmShippingCheckout
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fpnlOrderSummery = new System.Windows.Forms.FlowLayoutPanel();
            this.lblShippingDetails = new System.Windows.Forms.Label();
            this.lblOrderSummery = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtParish = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtParish);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtStreetAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEmailAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 383);
            this.panel1.TabIndex = 0;
            // 
            // fpnlOrderSummery
            // 
            this.fpnlOrderSummery.AutoScroll = true;
            this.fpnlOrderSummery.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fpnlOrderSummery.Location = new System.Drawing.Point(516, 55);
            this.fpnlOrderSummery.Name = "fpnlOrderSummery";
            this.fpnlOrderSummery.Size = new System.Drawing.Size(298, 383);
            this.fpnlOrderSummery.TabIndex = 1;
            // 
            // lblShippingDetails
            // 
            this.lblShippingDetails.AutoSize = true;
            this.lblShippingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingDetails.Location = new System.Drawing.Point(21, 32);
            this.lblShippingDetails.Name = "lblShippingDetails";
            this.lblShippingDetails.Size = new System.Drawing.Size(110, 17);
            this.lblShippingDetails.TabIndex = 2;
            this.lblShippingDetails.Text = "Shipping Details";
            // 
            // lblOrderSummery
            // 
            this.lblOrderSummery.AutoSize = true;
            this.lblOrderSummery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummery.Location = new System.Drawing.Point(513, 32);
            this.lblOrderSummery.Name = "lblOrderSummery";
            this.lblOrderSummery.Size = new System.Drawing.Size(108, 17);
            this.lblOrderSummery.TabIndex = 2;
            this.lblOrderSummery.Text = "Order Summery";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(7, 40);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(300, 20);
            this.txtEmailAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fisrt Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(7, 108);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(300, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(7, 170);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(300, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Street Address";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(7, 232);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(300, 20);
            this.txtStreetAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(7, 295);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(300, 20);
            this.txtCity.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Parish";
            // 
            // txtParish
            // 
            this.txtParish.Location = new System.Drawing.Point(7, 351);
            this.txtParish.Name = "txtParish";
            this.txtParish.Size = new System.Drawing.Size(300, 20);
            this.txtParish.TabIndex = 1;
            // 
            // FrmShippingCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.lblOrderSummery);
            this.Controls.Add(this.lblShippingDetails);
            this.Controls.Add(this.fpnlOrderSummery);
            this.Controls.Add(this.panel1);
            this.Name = "FrmShippingCheckout";
            this.Text = "FrmShippingCheckout";
            this.Load += new System.EventHandler(this.FrmShippingCheckout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel fpnlOrderSummery;
        private System.Windows.Forms.Label lblShippingDetails;
        private System.Windows.Forms.Label lblOrderSummery;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
    }
}