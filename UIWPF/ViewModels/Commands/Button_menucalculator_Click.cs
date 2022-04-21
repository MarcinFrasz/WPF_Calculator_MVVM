using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.Commands;

namespace UIWPF.ViewModels.Commands
{
    internal class Button_menucalculator_Click : CommandBase
    {
        CalculatorViewModel _calculatorViewModel;
        internal Button_menucalculator_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            if (_calculatorViewModel.NavigationViewModel.NavigationWidth > 0)
                _calculatorViewModel.NavigationViewModel.NavigationWidth = 0;
            else
                _calculatorViewModel.NavigationViewModel.NavigationWidth = 150;


        }
    }
}
