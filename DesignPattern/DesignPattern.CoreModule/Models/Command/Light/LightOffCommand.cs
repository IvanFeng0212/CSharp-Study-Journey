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
    public class LightOffCommand : ICommand
    {
        private readonly IReceiver _light;

        public LightOffCommand(IReceiver light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}