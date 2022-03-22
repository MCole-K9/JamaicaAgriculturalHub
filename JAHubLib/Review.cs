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
        private int rating;
        private string comment;
        public Customer customer;

        public int Id { get => id; set => id = value; }
        public int Rating { get => rating; set => rating = value; }
        public string Comment { get => comment; set => comment = value; }
        public Customer Customer { get => customer; set => customer = value; }
    }
}
