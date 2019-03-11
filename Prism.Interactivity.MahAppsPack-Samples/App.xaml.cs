using Prism.Interactivity.MahAppsPack_Samples.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace Prism.Interactivity.MahAppsPack_Samples
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
