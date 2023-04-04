using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    internal class Restaurantfood
    {
        private string name;
        private int price;
        public Restaurantfood(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string getName() { return name; }
        public int getPrice() { return price; }


    }   
}   
