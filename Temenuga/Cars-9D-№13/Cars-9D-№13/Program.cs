using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_9D__13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Console.WriteLine("Iskash li na vkarash kola:");
            string command=Console.ReadLine();
            while (command == "Da")
            {
                Car car = new Car();

                string marka = Console.ReadLine();
                string model = Console.ReadLine();
                string rNomer = Console.ReadLine();
                byte godinaProizv = byte.Parse(Console.ReadLine());

                car.Marka = marka;
                car.Model = model;
                car.RNomer = rNomer;
                car.GodinaProizv = godinaProizv;

                car.MoveCar();
                car.PrintMe();
                car.EcoIs();


            }
           


            Console.WriteLine($"The cars/car is:{Car.Counter}");
        }
    }
}
