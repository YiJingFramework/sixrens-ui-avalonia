using ReactiveUI;
using SixRens.Core.插件管理.插件包管理;
using SixRens.UI.Avalonia.Services.SixRens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixRens.UI.Avalonia.Windows.PluginConfiguration
{
    public sealed class WindowBindings : ReactiveObject
    {
        [Obsolete("应该使用有参数构造函数")]
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public WindowBindings()
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        {
        }

        private readonly SixRensCore core;
        public WindowBindings(SixRensCore core)
        {
            this.core = core;
        }

        public IEnumerable<插件包> InstalledPackages 
            => this.core.PluginPackages.插件包;

        private 插件包? selectedPackage;
        public 插件包? SelectedPackage
        {
            get => selectedPackage;
            set => this.RaiseAndSetIfChanged(ref selectedPackage, value);
        }
    }
}
