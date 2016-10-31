using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskF1A
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> owners = new List<Person>();
            Person owner1 = new Person("Le Thuy Hang");
            owners.Add(owner1);
            Person owner2 = new Person("Nguyen Thi Cuong");
            owners.Add(owner2);
            Car car1 = new Car("2355", "Audi 2016", owner1);
            Car car2 = new Car("2341", "RR2x8", owner1);
            Car car3 = new Car("2f45", "Mer424", owner2);
            foreach( Person newOwner in owners)
            {
                Console.WriteLine("The owner " + newOwner.Name + " has: ");
                foreach( Car car in newOwner.Cars)
                {
                    Console.WriteLine("The car " + car.Model + " number " + car.RegNumber + " ; ");
                }
            }
            Console.ReadKey();
        }
    }
}
