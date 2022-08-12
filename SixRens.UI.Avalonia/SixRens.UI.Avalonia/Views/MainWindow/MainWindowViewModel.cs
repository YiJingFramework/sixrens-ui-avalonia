using Avalonia.Controls;
using ReactiveUI;
using SixRens.Core.壬式生成;
using System;
using System.Threading.Tasks;

namespace SixRens.UI.Avalonia.Views.MainWindow
{
    public class MainWindowViewModel : ReactiveObject
    {
        public 壬式? Plate { get; private set; }
        public string Words { get; set; } = string.Empty;
        public DateTime Time { get; set; }
    }
}
