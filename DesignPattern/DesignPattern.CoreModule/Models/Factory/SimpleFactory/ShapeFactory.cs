using DesignPattern.CoreModule.Interfaces.Factory.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Factory.SimpleFactory
{
    /*
    意圖
    定義一個建立物件的接口，讓其子類別決定實例化哪一個特定的類別。
    工廠模式使物件的創建過程延遲到子類別。

    何時使用
    當我們需要在不同條件下建立不同實例時。

    使用場景
    日誌記錄：日誌可能記錄到本機硬碟、系統事件、遠端伺服器等，使用者可以選擇記錄日誌的位置。
    資料庫存取：當使用者不知道最終系統使用哪種資料庫，或資料庫可能會變更時。
    連接伺服器的框架設計：需要支援"POP3"、"IMAP"、"HTTP" 三種協議，可以將這三種協定作為產品類，共同實作一個介面。

    應用實例
    汽車製造：你需要一輛汽車，只需從工廠提貨，而不需要關心汽車的製造過程及其內部實現。
    Hibernate：更換資料庫時，只需更改方言（Dialect）和資料庫驅動（Driver），即可實現對不同資料庫的切換。

    優點
    呼叫者只需要知道物件的名稱即可建立物件。
    擴展性高，如果需要增加新產品，只需擴展一個工廠類即可。
    屏蔽了產品的具體實現，呼叫者只關心產品的介面。

    缺點
    每次增加一個產品時，都需要增加一個具體類別和對應的工廠，使系統中類別的數量成倍增加，增加了系統的複雜度和具體類別的依賴。

    注意事項
    工廠模式適用於產生複雜物件的場景。如果物件較為簡單，透過new 即可完成創建，則不必使用工廠模式。使用工廠模式會引入一個工廠類，增加系統複雜度。
    */

    public class ShapeFactory : IShapeFactory
    {
        public IShape CreateShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType)) return null;

            switch (shapeType.ToLower())
            {
                case "circle":
                    return new Circle();

                case "square":
                    return new Square();

                default:
                    return null;
            }
        }
    }
}