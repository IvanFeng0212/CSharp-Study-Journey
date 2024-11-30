using DesignPattern.CoreModule.Interfaces.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Adapter
{
    public class EuropeanPlugAdapter : IPowerAdapter
    {
        private readonly USPlugCharger _usPlugCharger;

        public EuropeanPlugAdapter(USPlugCharger usPlugCharger)
        {
            _usPlugCharger = usPlugCharger;
        }

        public string ProvidePower()
        {
            // 將美規電力轉換為歐規電力
            return $"轉換: {_usPlugCharger.ProvidePower()} -> 歐規電力";
        }
    }
}