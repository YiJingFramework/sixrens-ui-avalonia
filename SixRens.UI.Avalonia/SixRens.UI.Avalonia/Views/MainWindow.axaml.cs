using Avalonia.Controls;
using SixRens.UI.Avalonia.Services.SixRens;
using System;
using System.IO;

namespace SixRens.UI.Avalonia.Views
{
    public partial class MainWindow : Window
    {
        private SixRensCore sixRensCore;

        public MainWindow()
        {
            this.InitializeComponent();

            var sixrensSavingsPath = Path.GetFullPath("savings", AppContext.BaseDirectory);
            sixRensCore = new SixRensCore(new(sixrensSavingsPath));
        }
    }
}
