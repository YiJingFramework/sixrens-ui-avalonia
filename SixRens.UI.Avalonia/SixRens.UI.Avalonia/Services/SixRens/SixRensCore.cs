using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixRens.Core.插件管理.插件包管理;
using SixRens.Core.插件管理.预设管理;

namespace SixRens.UI.Avalonia.Services.SixRens
{
    public partial class SixRensCore
    {
        public 插件包管理器 PluginPackages { get; }
        public 预设管理器 Presets { get; }

        public SixRensCore(DirectoryInfo savingsDirectory)
        {
            var saver = new DataSaver(savingsDirectory);
            this.PluginPackages = new(saver);
            this.Presets = new(saver);
        }
    }
}
