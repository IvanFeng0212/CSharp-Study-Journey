using DesignPattern.CoreModule.Interfaces.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Command.Light
{
    /// <summary>
    /// 具體命令（ConcreteCommand）
    /// </summary>
    public class LightOnCommand : ICommand
    {
        private readonly IReceiver _light;

        public LightOnCommand(IReceiver light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}