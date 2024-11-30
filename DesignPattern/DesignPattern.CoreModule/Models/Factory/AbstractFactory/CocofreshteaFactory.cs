using DesignPattern.CoreModule.Interfaces.Factory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Factory.AbstractFactory
{
    public class CocofreshteaFactory : IBubbleTeaShopFactory
    {
        public IBubbleTea GetBubbleTea(string teaType)
        {
            if (string.IsNullOrEmpty(teaType)) return null;

            switch (teaType.ToLower())
            {
                case "blacktea":
                    return new CocofreshteaBlackTea();

                case "greentea":
                    return new CocofreshteaGreenTea();

                default:
                    return null;
            }
        }
    }
}