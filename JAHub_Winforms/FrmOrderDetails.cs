using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHubLib;

namespace JAHub_Winforms
{
    
    public partial class FrmOrderDetails : Form
    {
        private Order order;
        public FrmOrderDetails()
        {
            InitializeComponent();
        }
        public FrmOrderDetails(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmOrderDetails_Load(object sender, EventArgs e)
        {
            PopulateFields();
            LoadOrderItems();
        }
        private void PopulateFields()
        {
            lblShipStreetAddress.Text += order.ShipStreetAddress;
            lblShipTown.Text += order.ShipCity;
            lblShipParish.Text += order.ShipParish;

            //PaymentMethod.InnerText = order.PaymentDetails.PaymentType;
            lblBillingStreetAddress.Text += order.PaymentDetails.BillingStreetAddress;
            lblBillingTown.Text += order.PaymentDetails.BillingCity;
            lblBilllingParish.Text += order.PaymentDetails.BIllingParish;

            lblDate.Text = order.OrderDate.ToString("dddd, MMMM dd, yyyy");
            lblSubtotal.Text = $"${order.TotalAmount}";
            
        }

        public void LoadOrderItems()
        {
            foreach (var item in this.order.Items)
            {
                Shop_Controls.UsrOrderItem OItem = new Shop_Controls.UsrOrderItem(item);
                fpnlOrderItems.Controls.Add(OItem);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
