using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;

namespace Modificat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetMakeAndModel("BMW", "X5");
            car.Year = 2007;

            ElectricCar electriccar = new ElectricCar();
            ElectricCar.SetMakeAndModel("Tesla", "Model X");
            car.Year = 2020;

            ElectricCar.SetBatteryCapacity(100);
            Console.WriteLine("Информация о обычном автомобиле: ");
            car.DisplayInfo();

            Console.WriteLine("\n Информация о электрическом автомобиле: ");
            electricCar.DisplayInfo();
        }
    }
}
