using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms.Shop_Controls
{
    public partial class UsrOrderItem : System.Web.UI.UserControl
    {
        private OrderItem orderItem;
        int IDSequence;

        public void SetOItem(OrderItem item)
        {
            this.orderItem = item;
        }
        public void SetIDSequence(int id)
        {
            this.IDSequence = id;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                PopulateFields();
                Price.ID += IDSequence;
                ProductImage.ID += IDSequence;
                lblProductName.ID += IDSequence;
                lblSubtotal.ID += IDSequence;

            }
        }
        private void PopulateFields()
        {
            if (orderItem.OrderProduct != null)
            {
                Price.InnerText = orderItem.OrderProduct.Price.ToString();
                ProductImage.Src = orderItem.OrderProduct.Image;
                lblProductName.InnerText = orderItem.OrderProduct.Name;
                lblQty.Text = orderItem.Quantity.ToString();
                lblSubtotal.Text = (orderItem.OrderProduct.Price * orderItem.Quantity).ToString();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}