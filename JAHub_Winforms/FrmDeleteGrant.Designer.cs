namespace JAHub_Winforms
{
    partial class FrmDeleteGrant
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
            this.pansidebarcwj = new System.Windows.Forms.Panel();
            this.lbldeleteinfo = new System.Windows.Forms.Label();
            this.txtDeletetitleinfo = new System.Windows.Forms.TextBox();
            this.btnDeletetitleSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pansidebarcwj
            // 
            this.pansidebarcwj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pansidebarcwj.Dock = System.Windows.Forms.DockStyle.Left;
            this.pansidebarcwj.Location = new System.Drawing.Point(0, 0);
            this.pansidebarcwj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pansidebarcwj.Name = "pansidebarcwj";
            this.pansidebarcwj.Size = new System.Drawing.Size(191, 450);
            this.pansidebarcwj.TabIndex = 13;
            // 
            // lbldeleteinfo
            // 
            this.lbldeleteinfo.AutoSize = true;
            this.lbldeleteinfo.Location = new System.Drawing.Point(366, 58);
            this.lbldeleteinfo.Name = "lbldeleteinfo";
            this.lbldeleteinfo.Size = new System.Drawing.Size(228, 16);
            this.lbldeleteinfo.TabIndex = 14;
            this.lbldeleteinfo.Text = "Enter name of title, you want to delete.";
            // 
            // txtDeletetitleinfo
            // 
            this.txtDeletetitleinfo.Location = new System.Drawing.Point(369, 120);
            this.txtDeletetitleinfo.Name = "txtDeletetitleinfo";
            this.txtDeletetitleinfo.Size = new System.Drawing.Size(225, 22);
            this.txtDeletetitleinfo.TabIndex = 15;
            // 
            // btnDeletetitleSubmit
            // 
            this.btnDeletetitleSubmit.Location = new System.Drawing.Point(441, 264);
            this.btnDeletetitleSubmit.Name = "btnDeletetitleSubmit";
            this.btnDeletetitleSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnDeletetitleSubmit.TabIndex = 16;
            this.btnDeletetitleSubmit.Text = "Submit";
            this.btnDeletetitleSubmit.UseVisualStyleBackColor = true;
            this.btnDeletetitleSubmit.Click += new System.EventHandler(this.btnDeletetitleSubmit_Click);
            // 
            // FrmDeleteGrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletetitleSubmit);
            this.Controls.Add(this.txtDeletetitleinfo);
            this.Controls.Add(this.lbldeleteinfo);
            this.Controls.Add(this.pansidebarcwj);
            this.Name = "FrmDeleteGrant";
            this.Text = "FrmDeleteGrant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pansidebarcwj;
        private System.Windows.Forms.Label lbldeleteinfo;
        private System.Windows.Forms.TextBox txtDeletetitleinfo;
        private System.Windows.Forms.Button btnDeletetitleSubmit;
    }
}