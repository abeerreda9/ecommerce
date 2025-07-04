using ecommerce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Classes
{
    public class checkout
    {
        public static void checkout1(Customer customer, Cart cart)
        {
            if (cart.IsEmpty())
            { Console.WriteLine("cart is empty"); }
            var items = cart.GetItems();
            double subtotal = 0;
            double shippingFee = 0;
            List<Ishipping> shippableItems = new();
            foreach (var item in items)
            {
                var product = item.Key;
                int quantity = item.Value;
                if (product is Iexpired)
                {
                    var expirable = (Iexpired)product;
                    if (expirable.IsExpired())
                    {
                        Console.WriteLine($"{product.Name} is expired");
                        return;
                    }
                }
                    subtotal += product.Price * quantity;
                    if (product is Ishipping)
                    {
                        Ishipping shippable = (Ishipping)product;

                        int count = 0;
                        while (count < quantity)
                        {
                            shippableItems.Add(shippable);
                            count++;
                        }
                    }

                
                

            }
           shippingFee = shippableItems.Any() ? 30 : 0;
            double total = subtotal + shippingFee;

            if (customer.Balance < total)
                Console.WriteLine("Insufficient balance");
            foreach (var item in items)
                item.Key.decreasequantity(item.Value);

            customer.deduct(total);
            Shepping_Service.Ship(shippableItems);

            Console.WriteLine("** Checkout receipt **");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Value}x {item.Key.Name} \t {item.Key.Price * item.Value}");
            }
            Console.WriteLine("----------------------");
            Console.WriteLine($"Subtotal \t {subtotal}");
            Console.WriteLine($"Shipping \t {shippingFee}");
            Console.WriteLine($"Amount \t\t {total}");
            Console.WriteLine($"Customer balance: {customer.Balance}\n");

        }
    }
}
