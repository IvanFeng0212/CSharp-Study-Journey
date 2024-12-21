using DesignPattern.CoreModule.Interfaces.Responsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Responsibility
{
    /// <summary>
    /// 專門處理 "Debug" 類型的 Log
    /// </summary>
    public class DebugLoggerHandler : LoggerHandler
    {
        public override void Handle(int logType, string message)
        {
            if (logType == LoggerHandler.Debug)
            {
                WriteMessage(message);
            }
            else
            {
                base.Handle(logType, message);
            }
        }

        protected override void WriteMessage(string message)
        {
            Console.WriteLine($"DebugLoggerHandler:{message}");
        }
    }
}