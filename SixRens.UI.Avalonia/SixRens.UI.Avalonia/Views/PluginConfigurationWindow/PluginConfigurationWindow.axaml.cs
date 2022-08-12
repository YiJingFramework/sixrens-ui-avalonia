using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SixRens.UI.Avalonia.Views.PluginConfigurationWindow
{
    public partial class PluginConfigurationWindow : Window
    {
        public PluginConfigurationWindow()
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
