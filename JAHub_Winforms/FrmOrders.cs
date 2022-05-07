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
    public partial class FrmOrders : Form
    {
        private FrmShop _frmShop;
        public FrmOrders()
        {
            InitializeComponent();
        }
        public FrmOrders(FrmShop frmshop)
        {
            InitializeComponent();
            this._frmShop = frmshop;
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.orders);

        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orders.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.orders.Order);
            Customer customer = new Customer(true);
            customerToolStripTextBox.Text = customer.CustomerID.ToString();
            fillByToolStripButton.PerformClick();
     
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderTableAdapter.FillBy(this.orders.Order, new System.Nullable<int>(((int)(System.Convert.ChangeType(customerToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void customerToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order
                {
                    OrderId = (int)orderDataGridView.SelectedRows[0].Cells[0].Value,


                };
                order.FetchOrderData();
                _frmShop.OpenChildForm(new FrmOrderDetails(order));

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            
            
        }
    }
}
