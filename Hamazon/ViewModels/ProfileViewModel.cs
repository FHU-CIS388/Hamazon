using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hamazon.ViewModels
{
    class ProfileViewModel : INotifyPropertyChanged
    {
        private string fullName = string.Empty;
        public string FullName {
            get
            { return fullName; }
            set {
                if (fullName == value)
                    return;

                fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string HeaderImage { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
