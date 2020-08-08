using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Demo2.Commands
{
    class SimpleCommand<T> : ICommand
    {

        public event EventHandler CanExecuteChanged;

        private Func<T, bool> CanExecuteFunc { get; }
        private Action<T> OnExecute { get; }

        public SimpleCommand(Action<T> onExecute, Func<T, bool> canExecuteFunc = null)
        {
            this.OnExecute = onExecute;
            this.CanExecuteFunc = canExecuteFunc;
        }

        public bool CanExecute(T parameter)
        {
            return CanExecuteFunc?.Invoke(parameter) ?? true;
        }

        public void Execute(T parameter)
        {
            OnExecute.Invoke(parameter);
        }

        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute((T)parameter);
        }

        void ICommand.Execute(object parameter)
        {
            Execute((T)parameter);
        }

    }
}
