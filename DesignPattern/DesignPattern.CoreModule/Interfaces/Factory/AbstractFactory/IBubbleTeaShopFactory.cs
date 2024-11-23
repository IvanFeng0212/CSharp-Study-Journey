using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Interfaces.Factory.AbstractFactory
{
    public interface IBubbleTeaShopFactory
    {
        IBubbleTea GetBubbleTea(string teaType);
    }
}