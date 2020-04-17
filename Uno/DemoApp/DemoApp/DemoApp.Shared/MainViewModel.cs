using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoApp.Shared
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Framework _selectedFramework;

        public MainViewModel()
        {
            Frameworks = new List<Framework>
            {
                new Framework("Windows Forms", "1.0", 2002),
                new Framework("ASP.NET Web Forms", "1.0", 2002),
                new Framework("WPF", "3.0", 2006),
            };
        }

        public List<Framework> Frameworks { get; }

        public Framework SelectedFramework
        {
            get => _selectedFramework;
            set
            {
                if (Equals(value, _selectedFramework)) return;
                _selectedFramework = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FrameworkSelected));
            }
        }

        public bool FrameworkSelected => SelectedFramework != null;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
