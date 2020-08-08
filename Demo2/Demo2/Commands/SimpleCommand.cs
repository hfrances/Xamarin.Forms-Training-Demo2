using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Demo2.Commands
{
    class SimpleCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;

        private Func<object, bool> CanExecuteFunc { get; }
        private Action<object> OnExecute { get; }

        public SimpleCommand(Action<object> onExecute, Func<object,bool> canExecuteFunc = null)
        {
            this.OnExecute = onExecute;
            this.CanExecuteFunc = canExecuteFunc;
        }

        public bool CanExecute(object parameter)
        {
            return CanExecuteFunc?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            OnExecute.Invoke(parameter);
        }

    }
}
