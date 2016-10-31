using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskF1F
{
    public class Car : Vehicle
    {
        public string CarType { get; set; }
        public Car(string model, int year, int price, string carType) : base(model, year, price)
        {
            this.CarType = carType;
        }
    }
}
