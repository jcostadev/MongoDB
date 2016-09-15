using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    public class BookStore
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string Auther { get; set; }
        public string Category { get; set; }
        public string ISBN { get; set; }
    }
}
