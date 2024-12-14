using DesignPattern.CoreModule.Interfaces.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Template
{
    public class TemplateCoffee : TemplateBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override bool CustomerWantsCondiments()
        {
            Console.Write("Do you want sugar and milk in your coffee (y/n)? ");
            string? answer = Console.ReadLine();
            return answer?.ToLower() == "y";
        }
    }
}