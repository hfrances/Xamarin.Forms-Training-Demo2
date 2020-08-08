using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Demo2.ViewModels
{
    abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T field, T value,
            [CallerMemberName] string propertyName = "", 
            Action onChanged = null)
        {
            bool hasChanged = !EqualityComparer<T>.Default.Equals(field, value);

            if (hasChanged)
            {
                field = value;
                onChanged?.Invoke();
                RaisePropertyChanged(propertyName);
            }
            return hasChanged;
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
