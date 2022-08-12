using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;

namespace SixRens.UI.Avalonia.ViewModels.Main
{
    public partial class TianPan : UserControl
    {
        public List<string> ClockWiseString;
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
