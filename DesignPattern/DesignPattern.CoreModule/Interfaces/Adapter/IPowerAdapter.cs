using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Interfaces.Adapter
{
    /// <summary>
    /// 電源轉接頭的介面 ITarget
    /// </summary>
    public interface IPowerAdapter
    {
        string ProvidePower();
    }
}