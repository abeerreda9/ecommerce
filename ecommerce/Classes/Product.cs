using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Classes
{
    public class Product
    {
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
           

        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
       public void decreasequantity(int quantity)
        {
            Quantity-=quantity;
        }
        public bool ISavailable(int quantity)
        {
            return Quantity >= quantity;
        }
    }
}
