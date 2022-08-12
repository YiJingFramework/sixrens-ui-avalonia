using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;

namespace SixRens.UI.Avalonia.Views
{
    public partial class TianPan : UserControl
    {
        public List<string> ClockWiseString = new() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

        public string BigBox = "BigBox";

        public TianPan()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
