using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using UITemplate.Model;

namespace UITemplate.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "UI实例";
        private readonly IRegionManager regionManager;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand<object> SelectedCommand { get; set; }

        public ObservableCollection<MenuInfo> Menus { get; set; }
        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            SelectedCommand = new DelegateCommand<object>(Navigate);
            Menus = new ObservableCollection<MenuInfo>();
            Menus.Add(new MenuInfo() { Title = "案例一", SpaceName = "ChartsView" });
            Menus.Add(new MenuInfo() { Title = "案例二", SpaceName = "IndustryView" });
            Menus.Add(new MenuInfo() { Title = "案例三", SpaceName = "FootView" });
            Menus.Add(new MenuInfo() { Title = "案例四", SpaceName = "DataView" });
            
        }

        private void Navigate(object obj)
        {
            if (obj != null || string.IsNullOrWhiteSpace((obj as MenuInfo).SpaceName))
            {
                regionManager.Regions["ContentRegion"].RequestNavigate((obj as MenuInfo).SpaceName);
            }
            //MessageBox.Show((obj as MenuInfo).SpaceName.ToString());
        }
    }
}
