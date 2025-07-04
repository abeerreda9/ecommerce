using ecommerce.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            var cheese = new cheese("Cheese", 100, 5, DateTime.Now.AddDays(5), 0.2);
            var biscuits = new cheese("Biscuits", 150, 2, DateTime.Now.AddDays(3), 0.7);
            var tv = new TV("TV", 300, 3, 5);
            var scratchCard = new ScratchCard("ScratchCard", 50, 10);

            var customer = new Customer("Abeer", 5000);

            var cart = new Cart();
            cart.add(cheese, 2);
            cart.   add(tv, 3);
            cart.add(scratchCard, 1);

            checkout.checkout1(customer, cart);
        }
    }

}
