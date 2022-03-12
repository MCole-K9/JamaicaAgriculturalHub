﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms
{
    public partial class FrmShop : Form
    {
        private Form CurrentChildForm;
        public FrmShop()
        {
            InitializeComponent();
            CurrentChildForm = null;
        }

        // Opens Form inside of Panel
        private void OpenChildForm(Form childForm)
        {
            if (CurrentChildForm != null)
            {
                //Opens Only one form
                CurrentChildForm.Close();
            }
            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnlForm.Controls.Add(childForm);
            pnlForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void FrmShop_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProducts());
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProducts());
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCart());
        }
    }
}
