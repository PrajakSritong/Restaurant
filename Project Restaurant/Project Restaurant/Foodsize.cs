using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant
{
    internal class Foodsize : Restaurantfood
    {
        private string size;
        public Foodsize(string name , int price,string size) : base(name,price)
        {
            this.size = size;
        }
        public string getSize() { return size; }

    }
}
    

