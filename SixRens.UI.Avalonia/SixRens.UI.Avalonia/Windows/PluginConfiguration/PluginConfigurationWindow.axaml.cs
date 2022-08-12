using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SixRens.UI.Avalonia.Services.SixRens;
using System;
using System.IO;

namespace SixRens.UI.Avalonia.Windows.PluginConfiguration
{
    public partial class PluginConfigurationWindow : Window
    {
        [Obsolete("Ӧ��ʹ���в������캯��")]
        public PluginConfigurationWindow()
        {
            this.InitializeComponent();
        }

        public PluginConfigurationWindow(SixRensCore core)
        {
            this.InitializeComponent();
            this.DataContext = new WindowBindings(core);
        }
    }
}
