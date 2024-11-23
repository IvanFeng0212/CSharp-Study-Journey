using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Interfaces.Factory.AbstractFactory
{
    public interface IBubbleTea
    {
        int Cost();

        string GetDescription();
    }
}