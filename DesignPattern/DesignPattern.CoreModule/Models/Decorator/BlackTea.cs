using DesignPattern.CoreModule.Interfaces.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Decorator
{
    public class BlackTea : IBeverage
    {
        public int Cost()
        {
            return 35;
        }

        public string GetDescription()
        {
            return "Classic Black Tea";
        }
    }
}