using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITemplate.ViewModels.dialogs
{
    public class AddProjectViewModel : BindableBase, IDialogAware
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(); }
        }

        public string Title { get; set; }

        public event Action<IDialogResult> RequestClose;

        public AddProjectViewModel()
        {
            SaveCommand = new DelegateCommand(Save);
            CancelCommand = new DelegateCommand(Cancel);
        }

        private void Cancel()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.No));
        }

        private void Save()
        {
            DialogParameters keys = new DialogParameters();
            keys.Add("Value", Name);
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK, keys));
        }

        public DelegateCommand SaveCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }


        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
    }
}
