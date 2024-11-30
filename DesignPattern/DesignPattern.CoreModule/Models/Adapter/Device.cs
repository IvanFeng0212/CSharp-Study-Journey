using DesignPattern.CoreModule.Interfaces.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Adapter
{
    /*
    意圖：將一個類別的接口轉換為另一個接口，使得原本不相容的類別可以協同工作。

    使用場景
    需使用現有類別，但其介面不符合系統需求。
    希望創建一個可重複使用的類，與多個不相關的類別（包括未來可能引入的類別）一起工作，這些類別可能沒有統一的介面。
    透過介面轉換，將一個類別整合到另一個類別系中。

    應用實例
    電壓適配器：將110V 電壓轉換為220V，以適應不同國家的電器標準。
    介面轉換：例如，將Java JDK 1.1 的Enumeration 介面轉換為1.2 的Iterator 介面。
    跨平台運行：在Linux上執行Windows程式。
    資料庫連線：Java 中的JDBC 透過適配器模式與不同類型的資料庫互動。

    優點
    促進了類別之間的協同工作，即使它們沒有直接的關聯。
    提高了類別的複用性。
    增加了類的透明度。
    提供了良好的靈活性。

    缺點
    過度使用適配器可能導致系統結構混亂，難以理解和維護。
    在Java中，由於只能繼承一個類，因此只能適配一個類，且目標類必須是抽象的。

    使用建議
    適配器模式應謹慎使用，特別是在詳細設計階段，它更多地用於解決現有系統的問題。
    在考慮修改一個正常運作的系統介面時，適配器模式是一個合適的選擇。
    透過這種方式，適配器模式可以清楚地表達其核心概念和應用，同時避免了不必要的複雜性。
    */

    /// <summary>
    /// 需要電力的設備 (Device)
    /// </summary>
    public class Device
    {
        public void Charge(IPowerAdapter powerAdapter)
        {
            Console.WriteLine(powerAdapter.ProvidePower());
        }
    }
}