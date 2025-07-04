using ecommerce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Classes
{
    public class TV : Product, Ishipping
    {
        public TV(string name, double price, int quantity,double weight):base(name,price,quantity)
        {
            this.weight = weight;
        }

        public double weight { get; set; }
        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
           return weight;
        }
    }
}
