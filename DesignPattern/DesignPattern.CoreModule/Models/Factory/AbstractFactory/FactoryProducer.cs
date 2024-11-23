using DesignPattern.CoreModule.Interfaces.Factory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Factory.AbstractFactory
{
    /*
    意圖
    提供一個創建一系列相關或相互依賴物件的接口，而無需指定它們的特定類別。

    適用場景
    當系統需要建立多個相關或依賴的對象，而不需要指定特定類別時。

    使用場景
    創建跨平台應用程式時，產生不同作業系統的程式。

    應用實例
    假設有不同類型的衣櫃，每個衣櫃（具體工廠）只能存放一類衣服（成套的具體產品），
    如商務裝、時尚裝等。每套衣服包括具體的上衣和褲子（具體產品）。
    所有衣櫃都是衣櫃類別（抽象工廠）的具體實現，
    所有上衣和褲子分別實現上衣介面和褲子介面（抽象產品）。

    優點
    確保同一產品族的物件一起工作。
    客戶端不需要知道每個物件的具體類，簡化了程式碼。

    缺點
    擴展產品族非常困難。
    增加一個新的產品族需要修改抽象工廠和所有特定工廠的程式碼。

    注意事項
    增加新的產品族相對容易，而增加新的產品等級結構較為困難。
    */

    public class FactoryProducer
    {
        public static IBubbleTeaShopFactory GetBubbleShop(string shopName)
        {
            if (string.IsNullOrEmpty(shopName)) return null;

            switch (shopName.ToLower())
            {
                case "coco":
                    return new CocofreshteaFactory();

                case "chingshin":
                    return new ChingshinFactory();

                default:
                    return null;
            }
        }
    }
}