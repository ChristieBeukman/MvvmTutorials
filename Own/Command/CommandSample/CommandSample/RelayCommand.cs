using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandSample
{
    public class RelayCommand : ICommand
    {
        private Action _executeMethod;
        private Predicate<object> _canExecuteMethod;

        public RelayCommand(Action executeMethod, Predicate<object> canExecuteMethod)
        {
            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }

        #region ICommand Members

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (_canExecuteMethod == null)
                return true;

            return _canExecuteMethod(parameter);
        }
        public void Execute(object parameter)
        {
            _executeMethod();
        }
        #endregion
    }
}
