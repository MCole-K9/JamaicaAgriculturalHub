namespace JAHub_Winforms
{
    partial class FrmPayment
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
            this.lblOrderSummery = new System.Windows.Forms.Label();
            this.fpnlOrderSummery = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPaymentMethods = new System.Windows.Forms.GroupBox();
            this.rdbPaypal = new System.Windows.Forms.RadioButton();
            this.rdCreditDebitCard = new System.Windows.Forms.RadioButton();
            this.lblCartSubtotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlShippingAddress = new System.Windows.Forms.Panel();
            this.lblParish = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.chkBillingIsShipping = new System.Windows.Forms.CheckBox();
            this.pnlBillingAddress = new System.Windows.Forms.Panel();
            this.txtParish = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlCardMethod = new System.Windows.Forms.Panel();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCardHolderName = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.gbPaymentMethods.SuspendLayout();
            this.pnlShippingAddress.SuspendLayout();
            this.pnlBillingAddress.SuspendLayout();
            this.pnlCardMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderSummery
            // 
            this.lblOrderSummery.AutoSize = true;
            this.lblOrderSummery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummery.Location = new System.Drawing.Point(533, 44);
            this.lblOrderSummery.Name = "lblOrderSummery";
            this.lblOrderSummery.Size = new System.Drawing.Size(108, 17);
            this.lblOrderSummery.TabIndex = 4;
            this.lblOrderSummery.Text = "Order Summery";
            // 
            // fpnlOrderSummery
            // 
            this.fpnlOrderSummery.AutoScroll = true;
            this.fpnlOrderSummery.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fpnlOrderSummery.Location = new System.Drawing.Point(536, 87);
            this.fpnlOrderSummery.Name = "fpnlOrderSummery";
            this.fpnlOrderSummery.Size = new System.Drawing.Size(298, 218);
            this.fpnlOrderSummery.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Payment Methods";
            // 
            // gbPaymentMethods
            // 
            this.gbPaymentMethods.Controls.Add(this.rdbPaypal);
            this.gbPaymentMethods.Controls.Add(this.rdCreditDebitCard);
            this.gbPaymentMethods.Location = new System.Drawing.Point(15, 67);
            this.gbPaymentMethods.Name = "gbPaymentMethods";
            this.gbPaymentMethods.Size = new System.Drawing.Size(246, 83);
            this.gbPaymentMethods.TabIndex = 5;
            this.gbPaymentMethods.TabStop = false;
            // 
            // rdbPaypal
            // 
            this.rdbPaypal.AutoSize = true;
            this.rdbPaypal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPaypal.Location = new System.Drawing.Point(7, 55);
            this.rdbPaypal.Name = "rdbPaypal";
            this.rdbPaypal.Size = new System.Drawing.Size(69, 21);
            this.rdbPaypal.TabIndex = 0;
            this.rdbPaypal.Text = "Paypal";
            this.rdbPaypal.UseVisualStyleBackColor = true;
            this.rdbPaypal.CheckedChanged += new System.EventHandler(this.rdbPaypal_CheckedChanged);
            // 
            // rdCreditDebitCard
            // 
            this.rdCreditDebitCard.AutoSize = true;
            this.rdCreditDebitCard.Checked = true;
            this.rdCreditDebitCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCreditDebitCard.Location = new System.Drawing.Point(7, 20);
            this.rdCreditDebitCard.Name = "rdCreditDebitCard";
            this.rdCreditDebitCard.Size = new System.Drawing.Size(134, 21);
            this.rdCreditDebitCard.TabIndex = 0;
            this.rdCreditDebitCard.TabStop = true;
            this.rdCreditDebitCard.Text = "Credit/Debit Card";
            this.rdCreditDebitCard.UseVisualStyleBackColor = true;
            this.rdCreditDebitCard.CheckedChanged += new System.EventHandler(this.rdCreditDebitCard_CheckedChanged);
            // 
            // lblCartSubtotal
            // 
            this.lblCartSubtotal.AutoSize = true;
            this.lblCartSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartSubtotal.Location = new System.Drawing.Point(533, 67);
            this.lblCartSubtotal.Name = "lblCartSubtotal";
            this.lblCartSubtotal.Size = new System.Drawing.Size(90, 17);
            this.lblCartSubtotal.TabIndex = 4;
            this.lblCartSubtotal.Text = "Cart Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shipping To:";
            // 
            // pnlShippingAddress
            // 
            this.pnlShippingAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlShippingAddress.Controls.Add(this.lblParish);
            this.pnlShippingAddress.Controls.Add(this.lblTown);
            this.pnlShippingAddress.Controls.Add(this.lblStreetAddress);
            this.pnlShippingAddress.Controls.Add(this.lblEmail);
            this.pnlShippingAddress.Controls.Add(this.lblName);
            this.pnlShippingAddress.Location = new System.Drawing.Point(536, 345);
            this.pnlShippingAddress.Name = "pnlShippingAddress";
            this.pnlShippingAddress.Size = new System.Drawing.Size(298, 263);
            this.pnlShippingAddress.TabIndex = 6;
            // 
            // lblParish
            // 
            this.lblParish.AutoSize = true;
            this.lblParish.Location = new System.Drawing.Point(15, 155);
            this.lblParish.Name = "lblParish";
            this.lblParish.Size = new System.Drawing.Size(36, 13);
            this.lblParish.TabIndex = 0;
            this.lblParish.Text = "Parish";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(15, 119);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(34, 13);
            this.lblTown.TabIndex = 0;
            this.lblTown.Text = "Town";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(15, 84);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(82, 13);
            this.lblStreetAddress.TabIndex = 0;
            this.lblStreetAddress.Text = "Street Adddress";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // chkBillingIsShipping
            // 
            this.chkBillingIsShipping.AutoSize = true;
            this.chkBillingIsShipping.Checked = true;
            this.chkBillingIsShipping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBillingIsShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBillingIsShipping.Location = new System.Drawing.Point(15, 362);
            this.chkBillingIsShipping.Name = "chkBillingIsShipping";
            this.chkBillingIsShipping.Size = new System.Drawing.Size(330, 21);
            this.chkBillingIsShipping.TabIndex = 7;
            this.chkBillingIsShipping.Text = "Billing Address Is the same as Shipping Address";
            this.chkBillingIsShipping.UseVisualStyleBackColor = true;
            this.chkBillingIsShipping.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pnlBillingAddress
            // 
            this.pnlBillingAddress.Controls.Add(this.txtParish);
            this.pnlBillingAddress.Controls.Add(this.label6);
            this.pnlBillingAddress.Controls.Add(this.txtCity);
            this.pnlBillingAddress.Controls.Add(this.label5);
            this.pnlBillingAddress.Controls.Add(this.txtStreetAddress);
            this.pnlBillingAddress.Controls.Add(this.label4);
            this.pnlBillingAddress.Controls.Add(this.txtLastName);
            this.pnlBillingAddress.Controls.Add(this.label3);
            this.pnlBillingAddress.Controls.Add(this.txtFirstName);
            this.pnlBillingAddress.Controls.Add(this.label7);
            this.pnlBillingAddress.Location = new System.Drawing.Point(15, 398);
            this.pnlBillingAddress.Name = "pnlBillingAddress";
            this.pnlBillingAddress.Size = new System.Drawing.Size(332, 325);
            this.pnlBillingAddress.TabIndex = 8;
            this.pnlBillingAddress.Visible = false;
            // 
            // txtParish
            // 
            this.txtParish.Location = new System.Drawing.Point(7, 278);
            this.txtParish.Name = "txtParish";
            this.txtParish.Size = new System.Drawing.Size(300, 20);
            this.txtParish.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Parish";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(7, 222);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(300, 20);
            this.txtCity.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "City";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(7, 159);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(300, 20);
            this.txtStreetAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Street Address";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(7, 97);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(300, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(7, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(300, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fisrt Name";
            // 
            // pnlCardMethod
            // 
            this.pnlCardMethod.Controls.Add(this.txtCVV);
            this.pnlCardMethod.Controls.Add(this.txtExpirationDate);
            this.pnlCardMethod.Controls.Add(this.label9);
            this.pnlCardMethod.Controls.Add(this.label8);
            this.pnlCardMethod.Controls.Add(this.txtCardHolderName);
            this.pnlCardMethod.Controls.Add(this.txtCardNumber);
            this.pnlCardMethod.Controls.Add(this.label10);
            this.pnlCardMethod.Controls.Add(this.lblCardNumber);
            this.pnlCardMethod.Location = new System.Drawing.Point(15, 161);
            this.pnlCardMethod.Name = "pnlCardMethod";
            this.pnlCardMethod.Size = new System.Drawing.Size(332, 177);
            this.pnlCardMethod.TabIndex = 8;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(149, 90);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(110, 20);
            this.txtCVV.TabIndex = 1;
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.Location = new System.Drawing.Point(8, 90);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(110, 20);
            this.txtExpirationDate.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "CVV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Expiration Date (MM/YY)";
            // 
            // txtCardHolderName
            // 
            this.txtCardHolderName.Location = new System.Drawing.Point(8, 147);
            this.txtCardHolderName.Name = "txtCardHolderName";
            this.txtCardHolderName.Size = new System.Drawing.Size(263, 20);
            this.txtCardHolderName.TabIndex = 1;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(8, 36);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(263, 20);
            this.txtCardNumber.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Card Holder Name";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(5, 11);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(113, 13);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Payment Card Number";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(700, 614);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(134, 46);
            this.btnPlaceOrder.TabIndex = 9;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // FrmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(859, 517);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.pnlCardMethod);
            this.Controls.Add(this.pnlBillingAddress);
            this.Controls.Add(this.chkBillingIsShipping);
            this.Controls.Add(this.pnlShippingAddress);
            this.Controls.Add(this.gbPaymentMethods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCartSubtotal);
            this.Controls.Add(this.lblOrderSummery);
            this.Controls.Add(this.fpnlOrderSummery);
            this.Name = "FrmPayment";
            this.Text = "FrmPayment";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            this.gbPaymentMethods.ResumeLayout(false);
            this.gbPaymentMethods.PerformLayout();
            this.pnlShippingAddress.ResumeLayout(false);
            this.pnlShippingAddress.PerformLayout();
            this.pnlBillingAddress.ResumeLayout(false);
            this.pnlBillingAddress.PerformLayout();
            this.pnlCardMethod.ResumeLayout(false);
            this.pnlCardMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderSummery;
        private System.Windows.Forms.FlowLayoutPanel fpnlOrderSummery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPaymentMethods;
        private System.Windows.Forms.RadioButton rdbPaypal;
        private System.Windows.Forms.RadioButton rdCreditDebitCard;
        private System.Windows.Forms.Label lblCartSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlShippingAddress;
        private System.Windows.Forms.CheckBox chkBillingIsShipping;
        private System.Windows.Forms.Panel pnlBillingAddress;
        private System.Windows.Forms.TextBox txtParish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlCardMethod;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtExpirationDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCardHolderName;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblParish;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
    }
}