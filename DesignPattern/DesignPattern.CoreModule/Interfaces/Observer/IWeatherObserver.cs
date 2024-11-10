using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Interfaces.Observer
{
    public interface IWeatherObserver
    {
        void Update(int temperature);
    }
}