using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinaAssignment
{
    public class Command : ICommand
    {
        readonly Action _action;
        readonly Func<bool> _canAction;
        public Command(Action action,Func<bool> canAction)
        {
            if(action==null)
            {
                throw new NullReferenceException("action");
            }
            _action = action;
            _canAction = canAction;
        }

        public Command(Action action):this(action,null)
        {

        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canAction == null ? true : _canAction();
        }

        public void Execute(object parameter)
        {
            _action.Invoke();
        }
    }
}
