using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskF1F
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Car car1 = new Car("Audi2402", 1994, 800090, "secondhand Car");
            vehicles.Add(car1);
            Car car2 = new Car("AutoDustch", 1997, 120090, "new Car");
            vehicles.Add(car2);

            foreach( Car newCar in vehicles)
            {
                Console.WriteLine("The vehicle named " + newCar.Model + " year " 
                                    + newCar.Year.ToString() + " USD" + newCar.Price.ToString() 
                                    + " which are " + newCar.CarType);
            }
            Console.ReadKey();
        }
    }
}
