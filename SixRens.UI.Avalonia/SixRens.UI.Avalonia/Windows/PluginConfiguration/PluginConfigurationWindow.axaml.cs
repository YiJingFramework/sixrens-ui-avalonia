using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SixRens.UI.Avalonia.Services.SixRens;
using System;

namespace SixRens.UI.Avalonia.Windows.PluginConfiguration
{
    public partial class PluginConfigurationWindow : Window
    {
        [Obsolete("Ӧ��ʹ���в������캯��")]
        public PluginConfigurationWindow()
        {
            throw new NotImplementedException("Ӧ��ʹ���в������캯��");
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
