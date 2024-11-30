using DesignPattern.CoreModule.Interfaces.Factory.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Factory.SimpleFactory
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Square!!");
        }
    }
}