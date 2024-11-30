using DesignPattern.CoreModule.Interfaces.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Command.AirConditioner
{
    /// <summary>
    /// 具體接收者
    /// </summary>
    public class AirConditioner : IReceiver
    {
        public void Off()
        {
            Console.WriteLine("關空調");
        }

        public void On()
        {
            Console.WriteLine("開空調");
        }
    }
}