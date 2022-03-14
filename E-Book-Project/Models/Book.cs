using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_Project.Models
{
    public class Book
    {
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string BookAuthorName { get; set; }
        public string BookPrice { get; set; }
        public DateTime Created_at { get; set; }

    }
}
