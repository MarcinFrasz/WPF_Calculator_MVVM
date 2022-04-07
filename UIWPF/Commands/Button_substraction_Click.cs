using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    public class Button_substraction_Click : CommandBase
    {
        CalculatorViewModel _calculatorViewModel;
        public Button_substraction_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            string[] subs = { "", "" };
            decimal result = 0;
            switch (_calculatorViewModel.TextBlock_result)
            {
                case String a when a.Contains('+'):
                    Array.Clear(subs);
                    subs = _calculatorViewModel.TextBlock_result.Split('+');
                    if (subs[1].Length != 0)
                    {
                         result = Convert.ToDecimal(subs[0]) + Convert.ToDecimal(subs[1]);
                        _calculatorViewModel.TextBlock_result = Convert.ToString(result) + "-";
                    }
                    break;
                case String b when b.Contains('-'):
                    Array.Clear(subs);
                    subs = _calculatorViewModel.TextBlock_result.Split('-');
                    switch(subs.Length)
                    {
                        case 2:
                            break;
                        case 3:
                            if(_calculatorViewModel.TextBlock_result[0]=='-')
                            {
                                subs[0] = "-"+subs[1];
                                subs[1] =  subs[2];
                            }
                            else
                            {
                                subs[1] = "-" + subs[3];
                            }
                            break;
                        case 6:
                            subs[0] = "-" + subs[1];
                            subs[1] = "-" + subs[5];
                            break;

                        default:
                            _calculatorViewModel.TextBlock_result="Something went wrong line56 substraction_click";
                            break;
                    }
                     result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                    _calculatorViewModel.TextBlock_result=Convert.ToString(result) + "-";
                    break;
                case String c when c.Contains('x'):
                    Array.Clear(subs);
                    subs = _calculatorViewModel.TextBlock_result.Split('x');
                    if (subs[1].Length != 0)
                    {
                        decimal res = Convert.ToDecimal(subs[0]) * Convert.ToDecimal(subs[1]);
                        _calculatorViewModel.TextBlock_result = Convert.ToString(res) + "-";
                    }
                    break;
                case String d when d.Contains('÷'):
                    Array.Clear(subs);
                    subs = _calculatorViewModel.TextBlock_result.Split('÷');
                    if (subs[1].Length != 0)
                    {
                         result = Convert.ToDecimal(subs[0]) / Convert.ToDecimal(subs[1]);
                        _calculatorViewModel.TextBlock_result = Convert.ToString(result) + "-";
                    }
                    break;
                default:
                    if (_calculatorViewModel.TextBlock_result[_calculatorViewModel.TextBlock_result.Length - 1].Equals('.'))
                    {
                        _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result.Remove(_calculatorViewModel.TextBlock_result.Length - 1, 1);
                    }
                    _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + "-";
                    break;
            }
        }
    }
}
