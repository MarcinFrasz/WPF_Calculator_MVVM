using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    public class Button_dot_Click : CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;
        public Button_dot_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            if(!_calculatorViewModel.TextBlock_result.Contains("."))
            {
                _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + ".";
            }
        }
    }
}
