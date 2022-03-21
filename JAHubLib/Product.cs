using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAHubLib
{
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private string category;
        private string image;
        private float price;
        private List<Review> reviews;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Category { get => category; set => category = value; }
        public string Image { get => image; set => image = value; }
        public float Price { get => price; set => price = value; }
        
        public List<Review> Reviews { get => reviews; set => reviews = value; }
    }
}
