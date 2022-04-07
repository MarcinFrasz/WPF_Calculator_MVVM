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
            string[] subs = {"",""};
            decimal result;
            switch (_calculatorViewModel.TextBlock_result)
            {
                case String a when a.Contains('+'):
                    Array.Clear(subs);
                    subs = _calculatorViewModel.TextBlock_result.Split('+');
                    if (subs[1].Length != 0)
                    {
                         result = Convert.ToDecimal(subs[0]) + Convert.ToDecimal(subs[1]);
                        _calculatorViewModel.TextBlock_result = Convert.ToString(result)+"+";
                    }
                    break;              
                case String c when c.Contains('x'):
                    Array.Clear(subs);
                    subs = _calculatorViewModel.TextBlock_result.Split('x');
                    if (subs[1].Length != 0)
                    {
                         result = Convert.ToDecimal(subs[0]) * Convert.ToDecimal(subs[1]);
                        _calculatorViewModel.TextBlock_result = Convert.ToString(result) + "+";
                    }
                    break;
                case String d when d.Contains('÷'):
                    Array.Clear(subs);
                    subs = _calculatorViewModel.TextBlock_result.Split('÷');
                    if (subs[1].Length != 0)
                    {
                         result = Convert.ToDecimal(subs[0]) / Convert.ToDecimal(subs[1]);
                        _calculatorViewModel.TextBlock_result = Convert.ToString(result) + "+";
                    }
                    break;

                case String b when b.Contains('-') && b.Count(x=>x=='-')==1:
                    if (_calculatorViewModel.TextBlock_result[0] == '-')
                        _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + "+";
                    else
                    {
                        subs = _calculatorViewModel.TextBlock_result.Split('-');
                        if (subs[1].Length > 0)
                        {
                            result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                        }
                        else
                        {
                            _calculatorViewModel.TextBlock_result =_calculatorViewModel.TextBlock_result.Remove(_calculatorViewModel.TextBlock_result.Length - 1, 1);
                            _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + "+";
                        }
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
