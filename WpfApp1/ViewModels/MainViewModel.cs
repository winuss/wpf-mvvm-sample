using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Helpers;

namespace WpfApp1.ViewModels
{
    public class MainViewModel : NotificationObject
    {
        private ObservableCollection<ChangedFile> _changedFiles = new ObservableCollection<ChangedFile>();
        public ObservableCollection<ChangedFile> ChangedFiles 
        {
            get { return _changedFiles; }
            set
            {
                if (_changedFiles != value)
                {
                    _changedFiles = value;
                    RaisePropertyChanged(() => ChangedFiles);
                }
            }
        }

        public ICommand SearchChangedFileCommand { get { return new DelegateCommand(OnSearchChangedFiles); } }

        public virtual void OnSearchChangedFiles(object parameter)
        {
            this.ChangedFiles.Add(
                new ChangedFile() { Path = "TestFile.csv", Status = "Change" }
            );
        }

        private void InitChangedFiles()
        {
            this.ChangedFiles = new ObservableCollection<ChangedFile>();
        }
    }
}
