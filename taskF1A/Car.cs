using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskF1A
{
    public class Car
    {
        public string RegNumber { get; set; }
        public string Model { get; set; }
        public Person Owner { get; set; }

        public Car(string regNumber, string model, Person owner = null)
        {
            this.RegNumber = regNumber;
            this.Model = model;
            this.Owner = owner;

            this.Owner.Cars.Add(this);
        }
    }
}
