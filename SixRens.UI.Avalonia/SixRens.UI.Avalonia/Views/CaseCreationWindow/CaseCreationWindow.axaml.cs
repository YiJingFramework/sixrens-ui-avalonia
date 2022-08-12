using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SixRens.UI.Avalonia.Views.CaseCreationWindow
{
    public partial class CaseCreationWindow : Window
    {
        public CaseCreationWindow()
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
