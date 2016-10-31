using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskF1A
{
    public class Person
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; }

        public Person(string name)
        {
            this.Name = name;
            this.Cars = new List<Car>();
        }
    }

}
