using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskF1F
{
    public class Vehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        public Vehicle(string model, int year, int price)
        {
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }
    }
}
