using Avalonia.Controls;
using Avalonia.Controls.Templates;
using System;

namespace SixRens.UI.Avalonia
{
    public class ViewLocator : IDataTemplate
    {
        public IControl Build(object data)
        {
            throw new NotImplementedException("未实现 ViewLocationor");
            /*
            var name = data.GetType().FullName!.Replace("ViewModel", "View");
            var type = Type.GetType(name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type)!;
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
            */
        }

        public bool Match(object data)
        {
            throw new NotImplementedException("未实现 ViewLocationor");
            /*
            return data is ViewModelBase;
            */
        }
    }
}
