namespace JAHub_Winforms.Grant_Controls
{
    partial class UserControlDisplayGrant
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
            this.pnlgrantcontainer = new System.Windows.Forms.Panel();
            this.CbSelected = new System.Windows.Forms.CheckBox();
            this.btnUpdategrant = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rtbgrantdescription = new System.Windows.Forms.RichTextBox();
            this.txtviewgranttitle = new System.Windows.Forms.TextBox();
            this.pnlgrantcontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlgrantcontainer
            // 
            this.pnlgrantcontainer.Controls.Add(this.CbSelected);
            this.pnlgrantcontainer.Controls.Add(this.btnUpdategrant);
            this.pnlgrantcontainer.Controls.Add(this.btnDelete);
            this.pnlgrantcontainer.Controls.Add(this.rtbgrantdescription);
            this.pnlgrantcontainer.Controls.Add(this.txtviewgranttitle);
            this.pnlgrantcontainer.Location = new System.Drawing.Point(0, 16);
            this.pnlgrantcontainer.Name = "pnlgrantcontainer";
            this.pnlgrantcontainer.Size = new System.Drawing.Size(782, 309);
            this.pnlgrantcontainer.TabIndex = 0;
            // 
            // CbSelected
            // 
            this.CbSelected.AutoSize = true;
            this.CbSelected.Location = new System.Drawing.Point(660, 207);
            this.CbSelected.Name = "CbSelected";
            this.CbSelected.Size = new System.Drawing.Size(18, 17);
            this.CbSelected.TabIndex = 5;
            this.CbSelected.UseVisualStyleBackColor = true;
            // 
            // btnUpdategrant
            // 
            this.btnUpdategrant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdategrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdategrant.Location = new System.Drawing.Point(197, 203);
            this.btnUpdategrant.Name = "btnUpdategrant";
            this.btnUpdategrant.Size = new System.Drawing.Size(80, 32);
            this.btnUpdategrant.TabIndex = 4;
            this.btnUpdategrant.Text = "Update";
            this.btnUpdategrant.UseVisualStyleBackColor = true;
            this.btnUpdategrant.Click += new System.EventHandler(this.btnUpdategrant_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(62, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rtbgrantdescription
            // 
            this.rtbgrantdescription.BackColor = System.Drawing.Color.White;
            this.rtbgrantdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbgrantdescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbgrantdescription.Location = new System.Drawing.Point(10, 89);
            this.rtbgrantdescription.Name = "rtbgrantdescription";
            this.rtbgrantdescription.Size = new System.Drawing.Size(718, 96);
            this.rtbgrantdescription.TabIndex = 2;
            this.rtbgrantdescription.Text = "";
            this.rtbgrantdescription.TextChanged += new System.EventHandler(this.rtbgrantdescription_TextChanged);
            // 
            // txtviewgranttitle
            // 
            this.txtviewgranttitle.BackColor = System.Drawing.Color.White;
            this.txtviewgranttitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtviewgranttitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtviewgranttitle.Location = new System.Drawing.Point(8, 35);
            this.txtviewgranttitle.Name = "txtviewgranttitle";
            this.txtviewgranttitle.Size = new System.Drawing.Size(152, 30);
            this.txtviewgranttitle.TabIndex = 1;
            // 
            // UserControlDisplayGrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlgrantcontainer);
            this.Name = "UserControlDisplayGrant";
            this.Size = new System.Drawing.Size(786, 343);
            this.pnlgrantcontainer.ResumeLayout(false);
            this.pnlgrantcontainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlgrantcontainer;
        private System.Windows.Forms.RichTextBox rtbgrantdescription;
        private System.Windows.Forms.TextBox txtviewgranttitle;
        private System.Windows.Forms.CheckBox CbSelected;
        private System.Windows.Forms.Button btnUpdategrant;
        private System.Windows.Forms.Button btnDelete;
    }
}
