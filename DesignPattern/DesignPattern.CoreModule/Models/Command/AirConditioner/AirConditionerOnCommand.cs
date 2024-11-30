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
    public class AirConditionerOnCommand : ICommand
    {
        private readonly IReceiver _airConditioner;

        public AirConditionerOnCommand(IReceiver airConditioner)
        {
            _airConditioner = airConditioner;
        }

        public void Execute()
        {
            _airConditioner.On();
        }

        public void Undo()
        {
            _airConditioner.Off();
        }
    }
}