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
            this.InitializeComponent();
        }

        public CaseCreationWindow(SixRensCore core)
        {
            this.InitializeComponent();
        }
    }
}
