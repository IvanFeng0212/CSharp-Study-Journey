using DesignPattern.CoreModule.Interfaces.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Decorator
{
    /*
    意圖
    動態地為一個物件添加額外的職責，同時不改變其結構。
    裝飾器模式提供了一種靈活的替代繼承方式來擴展功能。

    主要解決的問題
    避免透過繼承引入靜態特徵，特別是在子類別數量急劇膨脹的情況下。
    允許在運行時動態地新增或修改物件的功能。

    使用場景
    當需要在不增加大量子類別的情況下擴展類別的功能。
    當需要動態地新增或撤銷物件的功能。

    應用實例
    孫悟空的72變：孫悟空透過變化獲得新的能力。
    畫框裝飾畫：一幅畫可以透過添加玻璃和畫框來增強其展示效果。

    優點
    低耦合：裝飾類別和被裝飾類別可以獨立變化，互不影響。
    靈活性：可以動態地新增或撤銷功能。
    替代繼承：提供了一種繼承之外的擴展物件功能的方式。

    缺點
    複雜性：多層裝飾可能導致系統複雜性增加。

    使用建議
    在需要動態擴充功能時，請考慮使用裝飾器模式。
    保持裝飾者和特定組件的介面一致，以確保靈活性。

    注意事項
    裝飾器模式可以替代繼承，但應謹慎使用，避免過度裝飾導致系統複雜。
    */

    public class BubbleDecorator : IBeverage
    {
        private readonly IBeverage _beverage;

        public BubbleDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public int Cost()
        {
            return 10 + _beverage.Cost();
        }

        public string GetDescription()
        {
            return $"{_beverage.GetDescription()} With Bubble";
        }
    }
}