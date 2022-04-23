using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.Commands.Functions;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    internal class Button_equals_Click : CommandBase
    {
        CalculatorViewModel _calculatorViewModel;
        internal Button_equals_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            Operations op = new Operations();
            switch (_calculatorViewModel.TextBlock_result)
            {
                case String a when a.Contains('+'):
                    _calculatorViewModel.TextBlock_result = op.Calculations_for_Execute(_calculatorViewModel.TextBlock_result, '+', '\0');
                    break;
                case String b when b.Contains('x'):
                    _calculatorViewModel.TextBlock_result = op.Calculations_for_Execute(_calculatorViewModel.TextBlock_result, 'x', '\0');
                    break;
                case String c when c.Contains('÷'):
                    _calculatorViewModel.TextBlock_result = op.Calculations_for_Execute(_calculatorViewModel.TextBlock_result, '÷', '\0');
                    if (_calculatorViewModel.TextBlock_result == "Cannot divide by 0")
                    {
                        _calculatorViewModel.Buttons_enabled = false;
                    }
                    break;
                case String d when d.Contains('-'):
                    _calculatorViewModel.TextBlock_result = op.Calculations_for_Execute(_calculatorViewModel.TextBlock_result, '-', '\0');
                    break; 
            }
        }
    }
}
