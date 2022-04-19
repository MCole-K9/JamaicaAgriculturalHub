using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAHubLib
{
    public class Review
    {
        private int id;
        private string headline;
        private int rating;
        private string comment;
        private int productID;
        private Customer customer;

        public int Id { get => id; set => id = value; }
        public int Rating { get => rating; set => rating = value; }
        public string Comment { get => comment; set => comment = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public int ProductID { get => productID; set => productID = value; }
        public string Headline { get => headline; set => headline = value; }
    }
}
