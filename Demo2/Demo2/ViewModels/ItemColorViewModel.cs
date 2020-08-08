using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Demo2.ViewModels
{
    class ItemColorViewModel : BaseViewModel
    {

        private string _name;
        private Color _value;



        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public Color Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }

    }
}
