using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixRens.UI.Avalonia.Views
{
    public class WindowBase<TViewModel> : Window where TViewModel : class
    {
        public new TViewModel? DataContext
        {
            get
            {
                return base.DataContext as TViewModel;
            }
            set
            {
                base.DataContext = value;
            }
        }

        public WindowBase(TViewModel viewModel)
        {
            base.DataContext = viewModel;
        }
    }
}
