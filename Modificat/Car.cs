using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Car
    {
        private string make;
        private string model;
        public string Year { get; set; }

        internal void SetMakeModel(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        protected void DisplayInfo()
        {
            Console.WriteLine($"Марка: {make}, Модель: {model}, Год: {Year}");
        }
    }
}
