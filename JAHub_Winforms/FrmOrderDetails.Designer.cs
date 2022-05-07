namespace JAHub_Winforms
{
    partial class FrmOrderDetails
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
            this.fpnlOrderItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBilllingParish = new System.Windows.Forms.Label();
            this.lblBillingTown = new System.Windows.Forms.Label();
            this.lblBillingStreetAddress = new System.Windows.Forms.Label();
            this.lblBillingEmail = new System.Windows.Forms.Label();
            this.lblBillingName = new System.Windows.Forms.Label();
            this.lblShipParish = new System.Windows.Forms.Label();
            this.lblShipTown = new System.Windows.Forms.Label();
            this.lblShipStreetAddress = new System.Windows.Forms.Label();
            this.lblShipEmail = new System.Windows.Forms.Label();
            this.lblShipName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlOrderItems
            // 
            this.fpnlOrderItems.AutoScroll = true;
            this.fpnlOrderItems.Location = new System.Drawing.Point(12, 121);
            this.fpnlOrderItems.Name = "fpnlOrderItems";
            this.fpnlOrderItems.Size = new System.Drawing.Size(380, 229);
            this.fpnlOrderItems.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.Location = new System.Drawing.Point(12, 26);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(102, 20);
            this.lblOrderDetails.TabIndex = 2;
            this.lblOrderDetails.Text = "Order Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBilllingParish);
            this.panel1.Controls.Add(this.lblBillingTown);
            this.panel1.Controls.Add(this.lblBillingStreetAddress);
            this.panel1.Controls.Add(this.lblBillingEmail);
            this.panel1.Controls.Add(this.lblBillingName);
            this.panel1.Controls.Add(this.lblShipParish);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblShipTown);
            this.panel1.Controls.Add(this.lblShipStreetAddress);
            this.panel1.Controls.Add(this.lblShipEmail);
            this.panel1.Controls.Add(this.lblShipName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(398, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 248);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblBilllingParish
            // 
            this.lblBilllingParish.AutoSize = true;
            this.lblBilllingParish.Location = new System.Drawing.Point(223, 181);
            this.lblBilllingParish.Name = "lblBilllingParish";
            this.lblBilllingParish.Size = new System.Drawing.Size(36, 13);
            this.lblBilllingParish.TabIndex = 8;
            this.lblBilllingParish.Text = "Parish";
            // 
            // lblBillingTown
            // 
            this.lblBillingTown.AutoSize = true;
            this.lblBillingTown.Location = new System.Drawing.Point(223, 145);
            this.lblBillingTown.Name = "lblBillingTown";
            this.lblBillingTown.Size = new System.Drawing.Size(34, 13);
            this.lblBillingTown.TabIndex = 9;
            this.lblBillingTown.Text = "Town";
            // 
            // lblBillingStreetAddress
            // 
            this.lblBillingStreetAddress.AutoSize = true;
            this.lblBillingStreetAddress.Location = new System.Drawing.Point(223, 110);
            this.lblBillingStreetAddress.Name = "lblBillingStreetAddress";
            this.lblBillingStreetAddress.Size = new System.Drawing.Size(82, 13);
            this.lblBillingStreetAddress.TabIndex = 10;
            this.lblBillingStreetAddress.Text = "Street Adddress";
            // 
            // lblBillingEmail
            // 
            this.lblBillingEmail.AutoSize = true;
            this.lblBillingEmail.Location = new System.Drawing.Point(223, 79);
            this.lblBillingEmail.Name = "lblBillingEmail";
            this.lblBillingEmail.Size = new System.Drawing.Size(32, 13);
            this.lblBillingEmail.TabIndex = 11;
            this.lblBillingEmail.Text = "Email";
            // 
            // lblBillingName
            // 
            this.lblBillingName.AutoSize = true;
            this.lblBillingName.Location = new System.Drawing.Point(223, 51);
            this.lblBillingName.Name = "lblBillingName";
            this.lblBillingName.Size = new System.Drawing.Size(35, 13);
            this.lblBillingName.TabIndex = 12;
            this.lblBillingName.Text = "Name";
            // 
            // lblShipParish
            // 
            this.lblShipParish.AutoSize = true;
            this.lblShipParish.Location = new System.Drawing.Point(11, 181);
            this.lblShipParish.Name = "lblShipParish";
            this.lblShipParish.Size = new System.Drawing.Size(36, 13);
            this.lblShipParish.TabIndex = 3;
            this.lblShipParish.Text = "Parish";
            // 
            // lblShipTown
            // 
            this.lblShipTown.AutoSize = true;
            this.lblShipTown.Location = new System.Drawing.Point(11, 145);
            this.lblShipTown.Name = "lblShipTown";
            this.lblShipTown.Size = new System.Drawing.Size(34, 13);
            this.lblShipTown.TabIndex = 4;
            this.lblShipTown.Text = "Town";
            // 
            // lblShipStreetAddress
            // 
            this.lblShipStreetAddress.AutoSize = true;
            this.lblShipStreetAddress.Location = new System.Drawing.Point(11, 110);
            this.lblShipStreetAddress.Name = "lblShipStreetAddress";
            this.lblShipStreetAddress.Size = new System.Drawing.Size(82, 13);
            this.lblShipStreetAddress.TabIndex = 5;
            this.lblShipStreetAddress.Text = "Street Adddress";
            // 
            // lblShipEmail
            // 
            this.lblShipEmail.AutoSize = true;
            this.lblShipEmail.Location = new System.Drawing.Point(11, 79);
            this.lblShipEmail.Name = "lblShipEmail";
            this.lblShipEmail.Size = new System.Drawing.Size(32, 13);
            this.lblShipEmail.TabIndex = 6;
            this.lblShipEmail.Text = "Email";
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Location = new System.Drawing.Point(11, 51);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(35, 13);
            this.lblShipName.TabIndex = 7;
            this.lblShipName.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Payment Details";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(9, 364);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(58, 15);
            this.l.TabIndex = 1;
            this.l.Text = "Subtotal: ";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(216, 248);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Shipping Details";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(354, 364);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(38, 15);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "$00.0";
            // 
            // FrmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.fpnlOrderItems);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.l);
            this.Name = "FrmOrderDetails";
            this.Text = "OrderDetails";
            this.Load += new System.EventHandler(this.FrmOrderDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlOrderItems;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShipParish;
        private System.Windows.Forms.Label lblShipTown;
        private System.Windows.Forms.Label lblShipStreetAddress;
        private System.Windows.Forms.Label lblShipEmail;
        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.Label lblBilllingParish;
        private System.Windows.Forms.Label lblBillingTown;
        private System.Windows.Forms.Label lblBillingStreetAddress;
        private System.Windows.Forms.Label lblBillingEmail;
        private System.Windows.Forms.Label lblBillingName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSubtotal;
    }
}