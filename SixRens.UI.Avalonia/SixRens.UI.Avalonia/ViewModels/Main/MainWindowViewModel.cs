using Avalonia.Controls;
using SixRens.Core.��ʽ����;
using System;
using System.Threading.Tasks;

namespace SixRens.UI.Avalonia.ViewModels.Main
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ��ʽ? Plate { get; private set; }
        public string Words { get; set; } = string.Empty;
        public DateTime Time { get; set; }
    }
}
