using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.Commands;
using UIWPF.Stores;

namespace UIWPF.ViewModels.Commands
{
    internal class Button_simplecalculator_Click : CommandBase
    {
       private readonly NavigationStore _navigationStore;
        private readonly NavigationViewModel _navigationViewModel;
        public Button_simplecalculator_Click(NavigationViewModel navigationViewModel, NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationViewModel = navigationViewModel;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new CalculatorViewModel(_navigationViewModel);
        }
    }
}
