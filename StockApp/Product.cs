using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product()
        {

        }
        public Product(string name)
        {
            Name = name;
        }
    }
}
