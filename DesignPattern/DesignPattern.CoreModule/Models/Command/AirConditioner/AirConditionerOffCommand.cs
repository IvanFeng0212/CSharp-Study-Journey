using DesignPattern.CoreModule.Interfaces.Command;
using DesignPattern.CoreModule.Models.Command.Light;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Command.AirConditioner
{
    /// <summary>
    /// 具體命令（ConcreteCommand）
    /// </summary>
    public class AirConditionerOffCommand : ICommand
    {
        private readonly IReceiver _airConditioner;

        public AirConditionerOffCommand(IReceiver airConditioner)
        {
            _airConditioner = airConditioner;
        }

        public void Execute()
        {
            _airConditioner.Off();
        }

        public void Undo()
        {
            _airConditioner.On();
        }
    }
}