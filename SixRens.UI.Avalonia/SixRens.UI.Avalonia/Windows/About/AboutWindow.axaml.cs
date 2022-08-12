using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SixRens.UI.Avalonia.Windows.About
{
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
