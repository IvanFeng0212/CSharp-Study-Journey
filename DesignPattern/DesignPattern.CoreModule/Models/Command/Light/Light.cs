using DesignPattern.CoreModule.Interfaces.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Command.Light
{
    /// <summary>
    /// 具體接收者
    /// </summary>
    public class Light : IReceiver
    {
        public void Off()
        {
            Console.WriteLine("關燈");
        }

        public void On()
        {
            Console.WriteLine("開燈");
        }
    }
}