using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAHubLib
{
    public static class Cart
    {
        public static Dictionary<Product, int> ShoppingCart = new Dictionary<Product, int>();

        public static void AddToCart(Product product, int quantity)
        {
            try
            {
                ShoppingCart.Add(product, quantity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void UpdateProductQuantity(Product product, int quantity)
        {
            ShoppingCart[product] = quantity;
        }

        public static void RemoveFromCart(Product product)
        {
            ShoppingCart.Remove(product);
        }

        public static List<Product> GetProductsInCart()
        {
            return ShoppingCart.Keys.ToList();
        }

        public static float CaluculateTotal()
        {
            float total = 0.0f;

            foreach (Product product in ShoppingCart.Keys.ToList())
            {
                total += product.Price * ShoppingCart[product];
            }
            return total;
        }


        public static float CostOfProductOrder(Product product)
        {
            return product.Price * ShoppingCart[product];
        }
    }
}
    