using DesignPattern.CoreModule.Interfaces.Command;
using DesignPattern.CoreModule.Models.Command.Light;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CoreModule.Models.Command
{
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

    /// <summary>
    /// 請求發送者
    /// </summary>
    public class RemoteControlInvoker
    {
        private readonly Dictionary<int, ICommand> _commands = new Dictionary<int, ICommand>();
        private ICommand _lastCommand;

        public void SetCommand(int button, ICommand command)
        {
            _commands[button] = command;
        }

        public void PressButton(int button)
        {
            if (_commands.TryGetValue(button, out ICommand currentCommand))
            {
                _lastCommand = currentCommand;
                currentCommand.Execute();
            }
            else
            {
                Console.WriteLine("沒有此按鍵功能");
            }
        }

        public void PressUndoButton()
        {
            if (_lastCommand != null)
            {
                _lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("無法復原上一個命令");
            }
        }
    }
}