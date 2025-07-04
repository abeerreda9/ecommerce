using ecommerce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Classes
{
    public class Shepping_Service
    {
        public static void Ship(List<Ishipping> items)
        {
            Console.WriteLine("** Shipment notice **");

            double totalWeight = 0;

            var group = items
                .GroupBy(item => item.GetName())
                .ToDictionary(e => e.Key, e => e.ToList());

            foreach (var item in group)
            {
                string name = item.Key;
                double weight = item.Value.Sum(i => i.GetWeight());
                Console.WriteLine($"{item.Value.Count}x {name} \t {weight * 1000}g");
                totalWeight += weight;
            }

            Console.WriteLine($"Total package weight {totalWeight}kg\n");
        }
    }
}
