// See https://aka.ms/new-console-template for more information
using DesignPattern.CoreModule.Interfaces.Decorator;
using DesignPattern.CoreModule.Interfaces.Factory.AbstractFactory;
using DesignPattern.CoreModule.Interfaces.Factory.SimpleFactory;
using DesignPattern.CoreModule.Models.Command;
using DesignPattern.CoreModule.Models.Command.AirConditioner;
using DesignPattern.CoreModule.Models.Command.Light;
using DesignPattern.CoreModule.Models.Decorator;
using DesignPattern.CoreModule.Models.Factory.AbstractFactory;
using DesignPattern.CoreModule.Models.Factory.SimpleFactory;
using DesignPattern.CoreModule.Models.Observer;

//// 觀察者模式
// ObserverPattern();

//// 裝飾者模式
// DecoratorPattern();

//// 簡單工廠模式
// SimpleFactory();

//// 抽象工廠模式
// AbstractFactory();

//// 命令模式
// Command();

#region 觀察者模式

/*
意圖
創建了物件間的一種一對多的依賴關係，當一個物件狀態改變時，所有依賴它的物件都會被通知並自動更新。

使用場景
當一個物件的狀態變化需要同時更新其他物件時。

應用實例
拍賣系統：拍賣官作為主題，競價者作為觀察者，拍賣價格更新時通知所有競價者

優點
抽象耦合：觀察者和主題之間是抽象耦合的。
觸發機制：建立了一套狀態改變時的觸發與通知機制。

缺點
效能問題：如果觀察者眾多，通知過程可能耗時。
循環依賴：可能導致循環呼叫和系統崩潰。
缺乏變化詳情：觀察者不知道主題如何變化，只知道變化發生。

使用建議
在需要降低物件間耦合度，且物件狀態變更需要觸發其他物件變更時使用。

注意事項
避免循環引用：注意觀察者和主題之間的依賴關係，避免循環引用。
非同步執行：考慮使用非同步通知避免單點故障導致整個系統卡住。
*/

/// <summary>
/// 觀察者模式
/// </summary>
static void ObserverPattern()
{
    // 自動生成範本
    //Subject subject = new Subject();
    //subject.Attach(new Observer("Observer 1"));
    //subject.Attach(new Observer("Observer 2"));
    //subject.Attach(new Observer("Observer 3"));
    //subject.Notify("Hello World!");

    WeatherObserable weatherObserable = new WeatherObserable();

    ComputerObserver computerObserver = new ComputerObserver();
    PhoneObserver phoneObserver = new PhoneObserver();

    weatherObserable.AddObserver(computerObserver);
    weatherObserable.AddObserver(phoneObserver);

    weatherObserable.SetTemperature(1);

    Console.WriteLine("Remove PhoneObserver");
    weatherObserable.RemoveObserver(phoneObserver);

    Console.WriteLine("NotifyObservers Again!!");
    weatherObserable.NotifyObservers();
}

#endregion 觀察者模式

#region 裝飾者模式

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
static void DecoratorPattern()
{
    IBeverage blackTea = new BlackTea();
    Console.WriteLine($"Beverage is:{blackTea.GetDescription()}，Price is:{blackTea.Cost()}");

    IBeverage blackTeaWithMilk = new MilkDecorator(blackTea);
    Console.WriteLine($"Beverage is:{blackTeaWithMilk.GetDescription()}，Price is:{blackTeaWithMilk.Cost()}");

    IBeverage blackTeaWithMilkAndBubble = new BubbleDecorator(blackTeaWithMilk);
    Console.WriteLine($"Beverage is:{blackTeaWithMilkAndBubble.GetDescription()}，Price is:{blackTeaWithMilkAndBubble.Cost()}");

    IBeverage greenTea = new GreenTea();
    Console.WriteLine($"Beverage is:{greenTea.GetDescription()}，Price is:{greenTea.Cost()}");

    IBeverage greenTeaWithBubble = new BubbleDecorator(greenTea);
    Console.WriteLine($"Beverage is:{greenTeaWithBubble.GetDescription()}，Price is:{greenTeaWithBubble.Cost()}");

    IBeverage greenTeaWithMilk = new MilkDecorator(greenTea);
    Console.WriteLine($"Beverage is:{greenTeaWithMilk.GetDescription()}，Price is:{greenTeaWithMilk.Cost()}");
}

#endregion 裝飾者模式

#region 簡單工廠模式

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
static void SimpleFactory()
{
    IShapeFactory shapeFactory = new ShapeFactory();

    IShape shape = shapeFactory.CreateShape("Circle");
    shape.Draw();

    shape = shapeFactory.CreateShape("Square");
    shape.Draw();
}

#endregion 簡單工廠模式

#region 抽象工廠模式

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
static void AbstractFactory()
{
    IBubbleTeaShopFactory coco = FactoryProducer.GetBubbleShop("Coco");
    IBubbleTea cocoBlackTea = coco.GetBubbleTea("blacktea");
    Console.WriteLine($"{cocoBlackTea.GetDescription()}，價格:{cocoBlackTea.Cost()}");
    IBubbleTea cocoGreentea = coco.GetBubbleTea("greentea");
    Console.WriteLine($"{cocoGreentea.GetDescription()}，價格:{cocoGreentea.Cost()}");

    IBubbleTeaShopFactory chingshin = FactoryProducer.GetBubbleShop("ChingShin");
    IBubbleTea chingshinBlackTea = chingshin.GetBubbleTea("blacktea");
    Console.WriteLine($"{chingshinBlackTea.GetDescription()}，價格:{chingshinBlackTea.Cost()}");
    IBubbleTea chingshinGreentea = chingshin.GetBubbleTea("greentea");
    Console.WriteLine($"{chingshinGreentea.GetDescription()}，價格:{chingshinGreentea.Cost()}");
}

#endregion 抽象工廠模式

#region 命令模式

/*
意圖
將請求封裝為一個對象，允許使用者使用不同的請求對客戶端進行參數化。

使用場景
當需要對行為進行記錄、撤銷/重做或交易處理時，使用命令模式來解耦請求者和執行者。

應用實例
家庭遙控器。

優點
降低耦合度：請求者和執行者之間的耦合度降低。
易於擴展：新命令可以輕鬆添加到系統中。

缺點
過多指令類：系統可能會有過多的具體指令類，增加系統的複雜度。

使用建議
在GUI中，每個按鈕或選單項目可以視為一條指令。
在需要模擬命令列操作的場景中使用命令模式。

注意事項
如果系統需要支援命令的撤銷（Undo）和復原（Redo）操作，命令模式是一個合適的選擇。
*/
static void Command()
{
    Light light = new Light();
    LightOnCommand lightOnCommand = new LightOnCommand(light);
    LightOffCommand lightOffCommand = new LightOffCommand(light);

    AirConditioner airConditioner = new AirConditioner();
    AirConditionerOnCommand airConditionerOnCommand = new AirConditionerOnCommand(airConditioner);
    AirConditionerOffCommand airConditionerOffCommand = new AirConditionerOffCommand(airConditioner);

    RemoteControlInvoker remoteControl = new RemoteControlInvoker();
    remoteControl.SetCommand(1, lightOnCommand);
    remoteControl.SetCommand(2, lightOffCommand);
    remoteControl.SetCommand(3, airConditionerOnCommand);
    remoteControl.SetCommand(4, airConditionerOffCommand);

    remoteControl.PressButton(1);
    remoteControl.PressButton(2);
    remoteControl.PressButton(3);
    remoteControl.PressButton(4);
    remoteControl.PressUndoButton();
    remoteControl.PressUndoButton();
}

#endregion 命令模式