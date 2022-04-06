using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    public class Button_addition_Click : CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;
        public Button_addition_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            if(_calculatorViewModel.TextBlock_result.Contains("+") || 
                _calculatorViewModel.TextBlock_result.Contains("-") ||
                _calculatorViewModel.TextBlock_result.Contains("x") ||
                _calculatorViewModel.TextBlock_result.Contains("÷"))
            {
                _calculatorViewModel.TextBlock_result = "Result";
            }
            else
            {
                if(_calculatorViewModel.TextBlock_result[_calculatorViewModel.TextBlock_result.Length - 1].Equals('.'))
                {
                    _calculatorViewModel.TextBlock_result.Remove(_calculatorViewModel.TextBlock_result.Length-1,1);
                }
                _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + "+";
            }
        }
    }
}
