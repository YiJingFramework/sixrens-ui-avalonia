using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SixRens.UI.Avalonia.Services.SixRens;
using System;

namespace SixRens.UI.Avalonia.Windows.CaseCreation
{
    public partial class CaseCreationWindow : Window
    {
        [Obsolete("Ӧ��ʹ���в������캯��")]
        public CaseCreationWindow()
        {
            throw new NotImplementedException("Ӧ��ʹ���в������캯��");
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
