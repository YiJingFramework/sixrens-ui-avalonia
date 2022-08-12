using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SixRens.UI.Avalonia.Services.SixRens;
using System;

namespace SixRens.UI.Avalonia.Windows.CaseCreation
{
    public partial class CaseCreationWindow : Window
    {
        [Obsolete("应该使用有参数构造函数")]
        public CaseCreationWindow()
        {
            throw new NotImplementedException("应该使用有参数构造函数");
        }

        public CaseCreationWindow(SixRensCore core)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
