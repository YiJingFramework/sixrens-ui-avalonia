using SixRens.Core.插件管理.插件包管理;
using SixRens.Core.插件管理.预设管理;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SixRens.UI.Avalonia.Services.SixRens
{
    internal partial class SixRensCore
    {
        private sealed class DataSaver : I插件包管理器储存器, I预设管理器储存器
        {
            public DataSaver(DirectoryInfo directory)
            {
                directory.Create();
                this.pluginPackagesDirectory = directory.CreateSubdirectory("plugins");
                this.presetsDirectory = directory.CreateSubdirectory("presets");
            }

            #region PluginPackage
            private readonly DirectoryInfo pluginPackagesDirectory;
            private FileInfo GetFileByPluginPackageId(string id)
            {
                var path = $"{id}.srspg";
                path = Path.GetFullPath(path, pluginPackagesDirectory.FullName);
                return new(path);
            }
            public string 储存插件包文件(Stream 插件包)
            {
                for(; ; )
                {
                    var id = Path.GetRandomFileName();
                    id = Path.GetFileNameWithoutExtension(id);
                    var file = GetFileByPluginPackageId(id);
                    if (file.Exists)
                        continue;
                    using var stream = file.Open(FileMode.CreateNew);
                    插件包.CopyTo(stream);
                    return id;
                }
            }

            public void 移除插件包文件(string 插件包本地识别码)
            {
                var file = GetFileByPluginPackageId(插件包本地识别码);
                var backupPath = Path.ChangeExtension(file.FullName, "srspg-backup");
                file.MoveTo(backupPath, true);
            }

            public IEnumerable<(string 插件包本地识别码, Stream 插件包)> 获取所有插件包文件()
            {
                foreach(var file in pluginPackagesDirectory.EnumerateFiles())
                {
                    if (file.Extension is not "srspg")
                        continue;
                    var id = Path.GetFileNameWithoutExtension(file.Name);
                    yield return (id, file.Open(FileMode.Open));
                }
            }

            public Stream? 获取插件包文件(string 插件包本地识别码)
            {
                var file = GetFileByPluginPackageId(插件包本地识别码);
                if (!file.Exists)
                    return null;
                return file.Open(FileMode.Open);
            }
            #endregion

            #region Preset
            private readonly DirectoryInfo presetsDirectory;
            private static readonly Encoding presetContentEncoding = Encoding.UTF8;
            private FileInfo GetFileByPresetName(string name)
            {
                var path = $"{name}.srspt";
                path = Path.GetFullPath(path, presetsDirectory.FullName);
                return new(path);
            }
            public IEnumerable<(string 预设名, string 内容)> 获取所有预设文件()
            {
                foreach (var file in presetsDirectory.EnumerateFiles())
                {
                    if (file.Extension is not "srspt")
                        continue;
                    var name = Path.GetFileNameWithoutExtension(file.Name);
                    yield return (name, File.ReadAllText(file.FullName, presetContentEncoding));
                }
            }

            public bool 新建预设文件(string 预设名)
            {
                var file = GetFileByPresetName(预设名);
                if (file.Exists)
                    return false;
                using var s = file.Open(FileMode.CreateNew);
                return true;
            }

            public void 储存预设文件(string 预设名, string 内容)
            {
                var file = GetFileByPresetName(预设名);
                File.WriteAllText(file.FullName, 内容);
            }

            public void 移除预设文件(string 预设名)
            {
                var file = GetFileByPresetName(预设名);
                file.Delete();
            }
            #endregion
        }
    }
}
