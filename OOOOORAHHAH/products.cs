using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOOOORAHHAH
{
    internal class Product
    {
        public string InvName { get; set; }
        public int InvID { get; set; }
        public int InvQuantity { get; set; }
        public double InvPrice { get; set; }

        public Product(string name, int quantity, double price, int id)
        {
            InvName = name;
            InvID = id;
            InvQuantity = quantity;
            InvPrice = price; 
        }
    }
}
