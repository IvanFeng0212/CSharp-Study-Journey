using DesignPattern.CoreModule.Interfaces.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Observer
{
    public class ComputerObserver : IWeatherObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine($"Computer Display: Current temperature is {temperature}°C");
        }
    }
}