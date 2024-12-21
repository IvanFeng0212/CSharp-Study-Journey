using DesignPattern.CoreModule.Interfaces.Responsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Responsibility
{
    /// <summary>
    /// 專門處理 "Error" 類型的 Log
    /// </summary>
    public class ErrorLoggerHandler : LoggerHandler
    {
        public override void Handle(int logType, string message)
        {
            if (logType == LoggerHandler.Error)
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
            Console.WriteLine($"ErrorLoggerHandler:{message}");
        }
    }
}