using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Contents;
using WpfApp1.Helpers;
using WpfApp1.Models;

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

        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                if (_message != value)
                {
                    _message = value;
                    RaisePropertyChanged(() => Message);
                }
            }
        }

        private bool _isWating;
        public bool IsWating
        {
            get { return _isWating; }
            set
            {
                if (_isWating != value)
                {
                    _isWating = value;
                    RaisePropertyChanged(() => IsWating);
                }
            }
        }

        public ICommand SearchChangedFileCommand { get { return new DelegateCommand(OnSearchChangedFiles); } }
        public ICommand DialogCommand { get { return new DelegateCommand(OnDialogCommand); } }
        public ICommand WatingCommand { get { return new DelegateCommand(OnWatingCommand); } }

        private void OnWatingCommand(object obj)
        {
            IsWating = true;
        }

        StringBuilder sb = new StringBuilder();
        private void OnDialogCommand(object obj)
        {
            Message += "템플릿 정보가 문제가 있습니다.\n";
            //sb.Append("템플릿 정보가 문제가 있습니다.");
        }

        public void OnSearchChangedFiles(object parameter)
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
