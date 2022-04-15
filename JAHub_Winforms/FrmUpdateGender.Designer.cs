namespace JAHub_Winforms
{
    partial class FrmUpdateGender
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
            this.panelGenderTitle = new System.Windows.Forms.Panel();
            this.lblJAHAccontlabel = new System.Windows.Forms.Label();
            this.lblGenderlabel = new System.Windows.Forms.Label();
            this.lblUpdateGenderinfolabel = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.panelUpdateGender = new System.Windows.Forms.Panel();
            this.rbtnratherNotSay = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.lblSelectToUpdateGenderlabel = new System.Windows.Forms.Label();
            this.lblGenderNotelabel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelGenderTitle.SuspendLayout();
            this.panelUpdateGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGenderTitle
            // 
            this.panelGenderTitle.Controls.Add(this.lblJAHAccontlabel);
            this.panelGenderTitle.Controls.Add(this.btnBack);
            this.panelGenderTitle.Controls.Add(this.lblGenderlabel);
            this.panelGenderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGenderTitle.Location = new System.Drawing.Point(0, 0);
            this.panelGenderTitle.Name = "panelGenderTitle";
            this.panelGenderTitle.Size = new System.Drawing.Size(716, 82);
            this.panelGenderTitle.TabIndex = 0;
            // 
            // lblJAHAccontlabel
            // 
            this.lblJAHAccontlabel.AutoSize = true;
            this.lblJAHAccontlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJAHAccontlabel.Location = new System.Drawing.Point(4, 3);
            this.lblJAHAccontlabel.Name = "lblJAHAccontlabel";
            this.lblJAHAccontlabel.Size = new System.Drawing.Size(118, 25);
            this.lblJAHAccontlabel.TabIndex = 6;
            this.lblJAHAccontlabel.Text = "JAH Account";
            // 
            // lblGenderlabel
            // 
            this.lblGenderlabel.AutoSize = true;
            this.lblGenderlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderlabel.Location = new System.Drawing.Point(120, 44);
            this.lblGenderlabel.Name = "lblGenderlabel";
            this.lblGenderlabel.Size = new System.Drawing.Size(74, 25);
            this.lblGenderlabel.TabIndex = 4;
            this.lblGenderlabel.Text = "Gender";
            // 
            // lblUpdateGenderinfolabel
            // 
            this.lblUpdateGenderinfolabel.AutoSize = true;
            this.lblUpdateGenderinfolabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateGenderinfolabel.Location = new System.Drawing.Point(74, 102);
            this.lblUpdateGenderinfolabel.Name = "lblUpdateGenderinfolabel";
            this.lblUpdateGenderinfolabel.Size = new System.Drawing.Size(576, 21);
            this.lblUpdateGenderinfolabel.TabIndex = 1;
            this.lblUpdateGenderinfolabel.Text = "Your gender may be used to customise JAH services, such as how we address you.";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 30;
            this.btnBack.Location = new System.Drawing.Point(64, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelUpdateGender
            // 
            this.panelUpdateGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdateGender.Controls.Add(this.btnSave);
            this.panelUpdateGender.Controls.Add(this.btnCancel);
            this.panelUpdateGender.Controls.Add(this.lblGenderNotelabel);
            this.panelUpdateGender.Controls.Add(this.lblSelectToUpdateGenderlabel);
            this.panelUpdateGender.Controls.Add(this.rbtnratherNotSay);
            this.panelUpdateGender.Controls.Add(this.rbtnFemale);
            this.panelUpdateGender.Controls.Add(this.rbtnMale);
            this.panelUpdateGender.Location = new System.Drawing.Point(78, 154);
            this.panelUpdateGender.Name = "panelUpdateGender";
            this.panelUpdateGender.Size = new System.Drawing.Size(572, 284);
            this.panelUpdateGender.TabIndex = 2;
            // 
            // rbtnratherNotSay
            // 
            this.rbtnratherNotSay.AutoSize = true;
            this.rbtnratherNotSay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnratherNotSay.Location = new System.Drawing.Point(37, 146);
            this.rbtnratherNotSay.Name = "rbtnratherNotSay";
            this.rbtnratherNotSay.Size = new System.Drawing.Size(145, 25);
            this.rbtnratherNotSay.TabIndex = 5;
            this.rbtnratherNotSay.Text = "I\'d rather not say";
            this.rbtnratherNotSay.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(37, 104);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(78, 25);
            this.rbtnFemale.TabIndex = 4;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(37, 58);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(62, 25);
            this.rbtnMale.TabIndex = 3;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // lblSelectToUpdateGenderlabel
            // 
            this.lblSelectToUpdateGenderlabel.AutoSize = true;
            this.lblSelectToUpdateGenderlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectToUpdateGenderlabel.Location = new System.Drawing.Point(18, 18);
            this.lblSelectToUpdateGenderlabel.Name = "lblSelectToUpdateGenderlabel";
            this.lblSelectToUpdateGenderlabel.Size = new System.Drawing.Size(205, 17);
            this.lblSelectToUpdateGenderlabel.TabIndex = 6;
            this.lblSelectToUpdateGenderlabel.Text = "SELECT ONE TO UPDATE GENDER";
            // 
            // lblGenderNotelabel
            // 
            this.lblGenderNotelabel.AutoSize = true;
            this.lblGenderNotelabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderNotelabel.Location = new System.Drawing.Point(18, 211);
            this.lblGenderNotelabel.Name = "lblGenderNotelabel";
            this.lblGenderNotelabel.Size = new System.Drawing.Size(308, 17);
            this.lblGenderNotelabel.TabIndex = 7;
            this.lblGenderNotelabel.Text = "This information is kept private. Only you can see it.";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(464, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 25);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(377, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 25);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmUpdateGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.panelUpdateGender);
            this.Controls.Add(this.lblUpdateGenderinfolabel);
            this.Controls.Add(this.panelGenderTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpdateGender";
            this.Text = "FrmUpdateGender";
            this.Load += new System.EventHandler(this.FrmUpdateGender_Load);
            this.panelGenderTitle.ResumeLayout(false);
            this.panelGenderTitle.PerformLayout();
            this.panelUpdateGender.ResumeLayout(false);
            this.panelUpdateGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGenderTitle;
        private System.Windows.Forms.Label lblJAHAccontlabel;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lblGenderlabel;
        private System.Windows.Forms.Label lblUpdateGenderinfolabel;
        private System.Windows.Forms.Panel panelUpdateGender;
        private System.Windows.Forms.Label lblSelectToUpdateGenderlabel;
        private System.Windows.Forms.RadioButton rbtnratherNotSay;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label lblGenderNotelabel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}