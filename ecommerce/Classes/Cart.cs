using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Classes
{
    public class Cart
    {
        private Dictionary<Product, int> items = new();
 public void add (Product product,int quantity)
        {
            if (!product.ISavailable(quantity))
                throw new Exception($"not enough stock");
            if(items.ContainsKey(product))
                items[product] += quantity;
            else items[product] = quantity;

        }
        public Dictionary<Product, int> GetItems() => items;
        public bool IsEmpty() => !items.Any();
    }
}
