using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Interfaces.Command
{
    /// <summary>
    /// 接收者（Receiver）
    /// </summary>
    public interface IReceiver
    {
        void On();

        void Off();
    }
}