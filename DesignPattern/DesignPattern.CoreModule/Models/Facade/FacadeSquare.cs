using DesignPattern.CoreModule.Interfaces.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Facade
{
    public class FacadeSquare : IFacadeShape
    {
        public void Draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }
}