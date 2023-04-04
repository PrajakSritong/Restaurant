using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    internal class Spicy : Restaurantfood
    {
        private string spicy;
        public Spicy(string name, int price, string spicy) : base(name, price)
        {
            this.spicy = spicy;
        }
        public string getSpicy() { return spicy; }
    }
}

