using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Interfaces.Template
{
    /*
    意圖
    在父類別中定義了演算法的骨架，並允許子類別在不改變演算法結構的前提下重定義演算法的某些特定步驟。

    使用場景
    當存在一些通用的方法，可以在多個子類別中共用時。

    應用實例
    建築流程：地基、走線、水管等步驟相同，後期建築如加壁櫥、柵欄等步驟不同。
    西遊記的81難：菩薩定好的81難代表一個頂層邏輯骨架。

    優點
    封裝不變部分：演算法的不變部分被封裝在父類別中。
    擴展可變部分：子類別可以擴展或修改演算法的可變部分。
    提取公共代碼：減少程式碼重複，方便維護。

    缺點
    類別數目增加：每個不同的實作都需要一個子類，可能導致系統龐大。

    使用建議
    當有多個子類別共有的方法且邏輯相同時，請考慮使用模板方法模式。
    對於重要或複雜的方法，可以考慮作為模板方法定義在父類別中。
    */

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