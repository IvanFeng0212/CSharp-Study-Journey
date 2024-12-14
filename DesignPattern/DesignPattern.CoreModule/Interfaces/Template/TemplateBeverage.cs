using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Interfaces.Template
{
    /// <summary>
    /// 抽象基類，定義模板方法和可覆寫的步驟
    /// </summary>
    public abstract class TemplateBeverage
    {
        // 子類必須實作
        protected abstract void Brew();

        protected abstract void AddCondiments();

        //  可選步驟（子類可覆寫來改變行為）
        protected virtual bool CustomerWantsCondiments()
        {
            // 預設加入調味料
            return true;
        }

        /// <summary>
        /// 模板方法，定義製作飲料的步驟框架
        /// </summary>
        public void PrepareBeverage()
        {
            BoilWater();

            Brew();

            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        // 一般步驟，所有子類共用
        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}