using DesignPattern.CoreModule.Interfaces.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Template
{
    public class TemplateBlackTea : TemplateBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}