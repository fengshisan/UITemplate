using BlankApp2.Model;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UITemplate.ViewModels
{
    public class FootViewModel:BindableBase
    {
        private ObservableCollection<MenuModel> menuModels;

        public ObservableCollection<MenuModel> MenuModels
        {
            get { return menuModels; }
            set { menuModels = value; }
        }

        private MenuModel menuModel;

        public MenuModel MenuModel
        {
            get { return menuModel; }
            set { menuModel = value; RaisePropertyChanged(); }
        }

        public DelegateCommand<object> SelectedCommand { get; set; }
        public FootViewModel()
        {
            MenuModels = new ObservableCollection<MenuModel>();
            MenuModels.Add(new MenuModel() { IconFont = "\xe608", Title = "Live scores", });
            MenuModels.Add(new MenuModel() { IconFont = "\xe620", Title = "Series", });
            MenuModels.Add(new MenuModel() { IconFont = "\xe622", Title = "Teams", });
            MenuModels.Add(new MenuModel() { IconFont = "\xe603", Title = "Features", });
            MenuModels.Add(new MenuModel() { IconFont = "\xe51c", Title = "Videos", });
            MenuModels.Add(new MenuModel() { IconFont = "\xe790", Title = "Stats", });
            MenuModels.Add(new MenuModel() { IconFont = "\xe672", Title = "World cup 2019", });
            SelectedCommand = new DelegateCommand<object>(Select);
        }

        private void Select(object obj)
        {
            var str = (MenuModel)obj;
            MessageBox.Show(str.Title);
        }
    }
}
