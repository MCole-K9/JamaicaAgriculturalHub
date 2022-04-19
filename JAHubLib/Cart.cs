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
               
                if (ShoppingCart.ContainsKey(product))
                {
                    ShoppingCart[product]++;
                }
                else
                {
                   ShoppingCart.Add(product, quantity);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void UpdateProductQuantity(Product product, int quantity)
        {
            try
            {
                ShoppingCart[product] = quantity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public static void RemoveFromCart(Product product)
        {
            try
            {
                ShoppingCart.Remove(product);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public static List<Product> GetProductsInCart()
        {
            try
            {
                return ShoppingCart.Keys.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
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
    