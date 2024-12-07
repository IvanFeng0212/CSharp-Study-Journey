﻿using DesignPattern.CoreModule.Interfaces.Factory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Factory.AbstractFactory
{
    public class ChingshinBlackTea : IBubbleTea
    {
        public int Cost()
        {
            return 35;
        }

        public string GetDescription()
        {
            return "清新福全-錫蘭紅茶";
        }
    }
}