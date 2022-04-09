using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAHubLib
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public Product OrderProduct { get; set; }
        public int Quantity { get; set; }

       
    }
}
