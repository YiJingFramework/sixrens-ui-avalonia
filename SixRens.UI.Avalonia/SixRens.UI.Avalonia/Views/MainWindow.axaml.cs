using Avalonia.Controls;
using Avalonia.Interactivity;
using SixRens.Core.占例存取;
using SixRens.UI.Avalonia.Services.SixRens;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SixRens.UI.Avalonia.Views
{
    public partial class MainWindow : Window
    {
        private readonly SixRensCore sixRensCore;

        public MainWindow()
        {
            this.InitializeComponent();

            var sixrensSavingsPath = Path.GetFullPath("savings", AppContext.BaseDirectory);
            sixRensCore = new SixRensCore(new(sixrensSavingsPath));
        }
        private async void OpenDivinationCaseAsync(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() {
                AllowMultiple = false,
                Filters = new() {
                    new() {
                        Extensions = new() {
                            "srs"
                        },
                        Name = "占例文件"
                    }
                }
            };
            var r = await dialog.ShowAsync(this);
            if (r is null)
                return;
            var s = r.Single();
            var c = 占例.反序列化(s);
        }
    }
}
