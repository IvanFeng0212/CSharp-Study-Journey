using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Interfaces.Decorator
{
    public interface IBeverage
    {
        string GetDescription();

        int Cost();
    }
}