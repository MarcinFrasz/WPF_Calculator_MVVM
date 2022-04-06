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
            switch(_calculatorViewModel.TextBlock_result)
            {
                case String a when a.Contains('+'):      
                    string[] subs = _calculatorViewModel.TextBlock_result.Split('+');
                    if (subs[1].Length != 0)
                    {
                        double result = Convert.ToDouble(subs[0]) + Convert.ToDouble(subs[1]);
                        _calculatorViewModel.TextBlock_result = Convert.ToString(result)+"+";
                    }
                    break;
                default:
                    if (_calculatorViewModel.TextBlock_result[_calculatorViewModel.TextBlock_result.Length - 1].Equals('.'))
                    {
                        _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result.Remove(_calculatorViewModel.TextBlock_result.Length - 1, 1);
                    }
                    _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + "+";
                    break;
            }
        }
    }
}
