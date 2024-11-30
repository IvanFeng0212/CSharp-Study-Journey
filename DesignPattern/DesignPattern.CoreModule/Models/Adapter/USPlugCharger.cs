using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Adapter
{
    /// <summary>
    /// 美規插頭充電器（Adaptee）
    /// </summary>
    public class USPlugCharger
    {
        public string ProvidePower()
        {
            return "美規電力";
        }
    }
}