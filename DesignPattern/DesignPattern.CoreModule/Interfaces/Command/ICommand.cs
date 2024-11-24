using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Interfaces.Command
{
    /// <summary>
    /// 命令（Command）
    /// </summary>
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}