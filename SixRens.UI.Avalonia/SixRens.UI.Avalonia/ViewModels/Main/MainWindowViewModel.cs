using Avalonia.Controls;
using SixRens.Core.壬式生成;
using System;
using System.Threading.Tasks;

namespace SixRens.UI.Avalonia.ViewModels.Main
{
    public class MainWindowViewModel : ViewModelBase
    {
        public 壬式? Plate { get; private set; }
        public string Words { get; set; } = string.Empty;
        public DateTime Time { get; set; }
    }
}
