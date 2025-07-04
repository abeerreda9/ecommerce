using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Classes
{
    public class Customer
    {
        public Customer(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public string Name { get; set; }
        public double Balance { get; set; }
        public void deduct(double amount)
        {
          Balance -= amount;
        }
    }
}
