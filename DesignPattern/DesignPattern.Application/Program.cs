// See https://aka.ms/new-console-template for more information
using DesignPattern.CoreModule.Models.Observer;

ObserverPattern();

#region 觀察者模式

/*
意圖
創建了物件間的一種一對多的依賴關係，當一個物件狀態改變時，所有依賴它的物件都會被通知並自動更新。

使用場景
當一個物件的狀態變化需要同時更新其他物件時。

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