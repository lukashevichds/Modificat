using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificat
{
    internal class ElectricCar
    {
        private double baterryCapacity;

        public void SetBatteryCapacity(double capacity)
        {
            baterryCapacity = capacity;
        }



        protected new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Емкость батареи: {baterryCapacity} кВтч");
        }
    }
}
