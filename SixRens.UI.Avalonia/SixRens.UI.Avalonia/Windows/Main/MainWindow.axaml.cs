using Avalonia.Controls;
using Avalonia.Interactivity;
using SixRens.Core.ռ����ȡ;
using SixRens.UI.Avalonia.Services.SixRens;
using SixRens.UI.Avalonia.Windows.About;
using SixRens.UI.Avalonia.Windows.CaseCreation;
using SixRens.UI.Avalonia.Windows.PluginConfiguration;
using System;
using System.IO;
using System.Linq;

namespace SixRens.UI.Avalonia.Windows.Main
{
    public partial class MainWindow : Window
    {
        private readonly SixRensCore core;
        public MainWindow()
        {
            InitializeComponent();

            var sixrensSavingsPath = Path.GetFullPath("savings", AppContext.BaseDirectory);
            core = new SixRensCore(new(sixrensSavingsPath));
        }

        private void CreateCase(object sender, RoutedEventArgs e)
        {
            _ = new CaseCreationWindow(core).ShowDialog<ռ��?>(this);
        }

        private void Configurate(object sender, RoutedEventArgs e)
        {
            _ = new PluginConfigurationWindow(core).ShowDialog(this);
        }

        private void DisplayAbout(object sender, RoutedEventArgs e)
        {
            _ = new AboutWindow().ShowDialog(this);
        }

        private async void OpenCaseFileAsync(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() {
                AllowMultiple = false,
                Filters = new() {
                    new() {
                        Extensions = new() {
                            "srs"
                        },
                        Name = "ռ���ļ�"
                    }
                }
            };
            var r = await dialog.ShowAsync(this);
            if (r is null)
                return;
            var s = r.Single();
            _ = ռ��.�����л�(s);
        }
    }
}
