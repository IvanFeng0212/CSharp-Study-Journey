using DesignPattern.CoreModule.Interfaces.Factory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Factory.AbstractFactory
{
    public class CocofreshteaBlackTea : IBubbleTea
    {
        public int Cost()
        {
            return 35;
        }

        public string GetDescription()
        {
            return "Coco都可-手採紅茶";
        }
    }
}