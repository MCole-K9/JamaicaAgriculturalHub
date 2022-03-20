namespace JAHub_Winforms
{
    partial class FrmProfileHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfileHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWelcomeBox = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.pictureBoxUserIcon = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtWelcomeBox);
            this.panel1.Controls.Add(this.txt);
            this.panel1.Controls.Add(this.pictureBoxUserIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 145);
            this.panel1.TabIndex = 0;
            // 
            // txtWelcomeBox
            // 
            this.txtWelcomeBox.BackColor = System.Drawing.SystemColors.Control;
            this.txtWelcomeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWelcomeBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcomeBox.Location = new System.Drawing.Point(320, 91);
            this.txtWelcomeBox.Name = "txtWelcomeBox";
            this.txtWelcomeBox.Size = new System.Drawing.Size(173, 20);
            this.txtWelcomeBox.TabIndex = 2;
            this.txtWelcomeBox.Text = "Welcome, Farmer Brown";
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.SystemColors.Control;
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(130, 113);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(595, 19);
            this.txt.TabIndex = 1;
            this.txt.Text = "To make JAH function better for you, manage your information, privacy, and securi" +
    "ty settings.";
            // 
            // pictureBoxUserIcon
            // 
            this.pictureBoxUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserIcon.Image")));
            this.pictureBoxUserIcon.Location = new System.Drawing.Point(373, 14);
            this.pictureBoxUserIcon.Name = "pictureBoxUserIcon";
            this.pictureBoxUserIcon.Padding = new System.Windows.Forms.Padding(12, 12, 0, 0);
            this.pictureBoxUserIcon.Size = new System.Drawing.Size(69, 66);
            this.pictureBoxUserIcon.TabIndex = 0;
            this.pictureBoxUserIcon.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(493, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 131);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(57, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 131);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(57, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 131);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(470, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(242, 131);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmProfileHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProfileHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmProfileHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxUserIcon;
        private System.Windows.Forms.TextBox txtWelcomeBox;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}