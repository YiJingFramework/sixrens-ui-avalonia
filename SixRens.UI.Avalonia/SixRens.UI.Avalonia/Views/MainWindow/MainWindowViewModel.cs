using Avalonia.Controls;
using ReactiveUI;
using SixRens.Core.��ʽ����;
using System;
using System.Threading.Tasks;

namespace SixRens.UI.Avalonia.Views.MainWindow
{
    public class MainWindowViewModel : ReactiveObject
    {
        public ��ʽ? Plate { get; private set; }
        public string Words { get; set; } = string.Empty;
        public DateTime Time { get; set; }
    }
}
