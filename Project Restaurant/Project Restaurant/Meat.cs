using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    internal class Meat : Restaurantfood
    {
        private string meat;
        public Meat(string name, int price, string meat) : base(name, price)
        {
            this.meat = meat;
        }
        public string getMeat() { return meat; }
    }
}
