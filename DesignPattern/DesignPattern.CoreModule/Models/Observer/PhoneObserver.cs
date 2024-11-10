using DesignPattern.CoreModule.Interfaces.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Observer
{
    public class PhoneObserver : IWeatherObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine($"Phone Display: Current temperature is {temperature}°C");
        }
    }
}