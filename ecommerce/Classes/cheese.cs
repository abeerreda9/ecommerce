using ecommerce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Classes
{
    internal class cheese : Product, Iexpired,Ishipping
    {
        public cheese(string name, double price, int quantity,DateTime expireddate, double weight): base(name, price, quantity)
        {
            this.expireddate = expireddate;
            this.weight = weight;
        }

        public DateTime expireddate { get; set; }
        public double weight { get; set; }

        

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
           return weight;
        }

        bool Iexpired.IsExpired()
        {
           return DateTime.Now>expireddate;
        }
    }
}
