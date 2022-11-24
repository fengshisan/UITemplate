using Prism.Ioc;
using System.Windows;
using UITemplate.ViewModels;
using UITemplate.ViewModels.dialogs;
using UITemplate.Views;
using UITemplate.Views.Dialogs;

namespace UITemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<AddProject, AddProjectViewModel>();

            containerRegistry.RegisterForNavigation<ChartsView, ChartsViewModel>();
            containerRegistry.RegisterForNavigation<FootView, FootViewModel>();
            containerRegistry.RegisterForNavigation<IndustryView, IndustryViewModel>();
            containerRegistry.RegisterForNavigation<DataView, DataViewModel>();
        }
    }
}
