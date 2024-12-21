using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Interfaces.Responsibility
{
    /*
    意圖
    允許將請求沿著處理者鏈傳遞，直到請求被處理為止。 。

    使用場景
    當有多個物件可以處理請求，且具體由哪個物件處理由執行時間決定時。
    當需要向多個物件中的一個提交請求，而不想明確指定接收者。

    應用實例
    擊鼓傳花：遊戲中的傳遞行為，直到音樂停止。
    事件冒泡：在JavaScript中，事件從最具體的元素開始，逐級向上傳播。
    Web伺服器：如Apache Tomcat處理字元編碼，Struts2的攔截器，以及Servlet的Filter。

    優點
    降低耦合度：發送者和接收者之間解耦。
    簡化物件：物件不需要知道鏈的結構。
    彈性：透過改變鏈的成員或順序，動態地新增或刪除責任。
    易於擴展：增加新的請求處理類別很方便。

    缺點
    請求未被處理：不能保證請求一定會被鏈中的某個處理者接收。
    效能影響：可能影響系統效能，且除錯困難，可能導致循環呼叫。
    難以觀察：運轉時特徵不明顯，可能妨礙除錯。

    使用建議
    在處理請求時，如果有多個潛在的處理者，請考慮使用責任鏈模式。
    確保鏈中的每個處理者都明確知道如何傳遞請求到鏈的下一個環節。

    注意事項
    在開發中，責任鏈模式有廣泛應用，如過濾器鏈、攔截器等。
    */

    public abstract class LoggerHandler
    {
        public static int Debug = 0;

        public static int Info = 1;

        public static int Error = 2;

        private LoggerHandler _nextHandler;

        /// <summary>
        /// 設定下一個處理者
        /// </summary>
        /// <param name="nextHandler"></param>
        public void SetNextHandler(LoggerHandler nextHandler)
        {
            this._nextHandler = nextHandler;
        }

        public virtual void Handle(int logType, string message)
        {
            // 如果有下一個處理者，傳遞請求給下一個處理者
            if (_nextHandler != null)
            {
                _nextHandler.Handle(logType, message);
            }
            else
            {
                Console.WriteLine($"無法處理的請求類型：{logType}");
            }
        }

        protected abstract void WriteMessage(string message);
    }
}