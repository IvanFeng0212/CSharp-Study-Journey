using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Interfaces.Observer
{
    public interface IWeatherObserable
    {
        void AddObserver(IWeatherObserver observer);

        void RemoveObserver(IWeatherObserver observer);

        void SetTemperature(int temperature);

        void NotifyObservers();
    }
}