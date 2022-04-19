using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    public abstract class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        public virtual bool CanExecute(object? parameter)
        {
            if (parameter is bool)
            {
                bool check = (bool)parameter;
                if (check == true)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }


        public abstract void Execute(object? parameter);

       protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this,new EventArgs());
        }

  
    }
}
