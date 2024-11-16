// See https://aka.ms/new-console-template for more information
using DesignPattern.CoreModule.Interfaces.Decorator;
using DesignPattern.CoreModule.Models.Decorator;
using DesignPattern.CoreModule.Models.Observer;

//// 觀察者模式
// ObserverPattern();

//// 裝飾者模式
// DecoratorPattern();

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