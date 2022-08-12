using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SixRens.UI.Avalonia.Services.SixRens;
using System;

namespace SixRens.UI.Avalonia.Windows.PluginConfiguration
{
    public partial class PluginConfigurationWindow : Window
    {
        [Obsolete("应该使用有参数构造函数")]
        public PluginConfigurationWindow()
        {
            throw new NotImplementedException("应该使用有参数构造函数");
        }

        public PluginConfigurationWindow(SixRensCore core)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
