using Demo2.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;
using System.Windows.Input;

namespace Demo2.ViewModels
{
    class MainViewModel : BaseViewModel
    {

        private string _title;
        private string _subtitle;
        private ObservableCollection<ItemColorViewModel> _items;
        private ItemColorViewModel _selectedItem;

        public MainViewModel()
        {
            this.Title = "Hola";
            this.Subtitle = "Mundo";
            this.Items = new ObservableCollection<ItemColorViewModel>()
            {
                new ItemColorViewModel(){ Name = "Red", Value = Color.Red },
                new ItemColorViewModel(){ Name = "Blue", Value = Color.Blue },
                new ItemColorViewModel(){ Name = "Green", Value = Color.Green }
            };
            this.SelectedItem = this.Items[1];


            this.SetValues1Command = new SimpleCommand(o =>
            {
                this.Title = "Marco";
                this.Subtitle = "Polo";
            });
            this.SetValues2Command = new SimpleCommand<MainViewModel>(o =>
            {
                o.Title = "Alfa";
                o.Subtitle = "Beta";
            });
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        public string Subtitle
        {
            get => _subtitle;
            set => SetProperty(ref _subtitle, value);
        }

        public ObservableCollection<ItemColorViewModel> Items
        {
            get => _items;
            private set => SetProperty(ref _items, value);
        }

        public ItemColorViewModel SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }

        public ICommand SetValues1Command
        {
            get;
        }

        public ICommand SetValues2Command
        {
            get;
        }
    }
}
