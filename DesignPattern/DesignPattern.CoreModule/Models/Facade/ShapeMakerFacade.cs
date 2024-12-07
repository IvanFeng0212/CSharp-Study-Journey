using DesignPattern.CoreModule.Interfaces.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Facade
{
    /*
    意圖
    為一個複雜的子系統提供一個一致的高層介面。
    這樣客戶端程式碼就可以透過這個簡化的介面與子系統交互，而不需要了解子系統內部的複雜性。

    使用場景
    當客戶端不需要了解系統內部的複雜邏輯和元件互動時。
    當需要為整個系統定義一個清晰的入口點時。

    應用實例
    醫院接待：醫院的接待人員簡化了掛號、門診、劃價、取藥等複雜流程。
    三層架構：透過外觀模式，可以簡化對表示層、業務邏輯層和資料存取層的存取。

    優點
    減少依賴：客戶端與子系統之間的依賴減少。
    提高靈活性：子系統的內部變化不會影響客戶端。
    增強安全性：隱藏了子系統的內部實現，只暴露必要的操作。

    缺點
    違反開閉原則：子系統的修改可能需要對外觀類別進行相應的修改。

    使用建議
    在需要簡化複雜系統存取時使用外觀模式。
    確保外觀類別提供的方法足夠簡單，以便於客戶端使用。
    避免過度使用外觀模式，以免隱藏過多的細節，導致維護困難。
    */

    public class ShapeMakerFacade
    {
        private readonly IFacadeShape _facadeCircle;
        private readonly IFacadeShape _facadeSquare;

        public ShapeMakerFacade()
        {
            this._facadeCircle = new FacadeCircle();
            this._facadeSquare = new FacadeSquare();
        }

        public void DrawCircle()
        {
            this._facadeCircle.Draw();
        }

        public void DrawSquare()
        {
            this._facadeSquare.Draw();
        }
    }
}