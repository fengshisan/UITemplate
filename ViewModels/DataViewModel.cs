using BlankApp2.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UITemplate.ViewModels
{
    public class DataViewModel:BindableBase
    {

        public DelegateCommand AddCommand { get; set; }
        public DataViewModel(IDialogService dialog)
        {
            AddCommand = new DelegateCommand(AddProject);
            Init();
            this.dialog = dialog;
        }

        private void AddProject()
        {
            dialog.ShowDialog("AddProject",arg=> {
                if (arg.Result == ButtonResult.OK)
                {
                    string str = arg.Parameters.GetValue<string>("Value");
                    Modules.Add(new ModuleInfo() { IconFont = "\xe626", Title = str });
                }
            });
        }

        private ObservableCollection<ModuleInfo> modules;
        private readonly IDialogService dialog;

        public ObservableCollection<ModuleInfo> Modules
        {
            get { return modules; }
            set { modules = value;RaisePropertyChanged(); }
        }

        public ObservableCollection<UserModule> GridModelList { get; set; }

        private void Init()
        {
            Modules = new ObservableCollection<ModuleInfo>();
            Modules.Add(new ModuleInfo() { IconFont = "\xe626", Title = "Application" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe77a", Title = "Opinion" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe50a", Title = "Tasks" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe669", Title = "Program" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe502", Title = "Data" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe77a", Title = "Opinion" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe50a", Title = "Tasks" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe669", Title = "Program" });

            GridModelList = new ObservableCollection<UserModule>();
            GridModelList.Add(new UserModule() { Name = "Vaughan", Address = "Delaware", Email = "jack163@outlook.com", UserType = "Quality inspector", Status = "S1", BackColor = "#FF7000" });
            GridModelList.Add(new UserModule() { Name = "Abbey", Address = "Florida", Email = "jack163@outlook.com", UserType = "Quality inspector", Status = "S2", BackColor = "#FFC100" });
            GridModelList.Add(new UserModule() { Name = "Dahlia", Address = "Illinois", Email = "jack163@outlook.com", UserType = "Quality inspector", Status = "S1", BackColor = "#FF7000" });
            GridModelList.Add(new UserModule() { Name = "Fallon", Address = "Tennessee", Email = "jack163@outlook.com", UserType = "Quality inspector", Status = "S3", BackColor = "#59E6B5" });
            GridModelList.Add(new UserModule() { Name = "Hannah", Address = "Washington", Email = "jack163@outlook.com", UserType = "Quality inspector", Status = "S4", BackColor = "#FFC100" });
            GridModelList.Add(new UserModule() { Name = "Laura", Address = "Mississippi", Email = "jack163@outlook.com", UserType = "Quality inspector", Status = "S2", BackColor = "#59E6B5" });
            GridModelList.Add(new UserModule() { Name = "Lauren", Address = "Wyoming", Email = "jack163@outlook.com", UserType = "Quality inspector", Status = "S3", BackColor = "#FFC100" });
        }
    }
}
