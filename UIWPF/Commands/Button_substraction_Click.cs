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
                case String b when b.Contains('x'):
                    Array.Clear(subs);
                    subs = _calculatorViewModel.TextBlock_result.Split('x');
                    if (subs[1].Length != 0)
                    {
                        decimal res = Convert.ToDecimal(subs[0]) * Convert.ToDecimal(subs[1]);
                        _calculatorViewModel.TextBlock_result = Convert.ToString(res) + "-";
                    }
                    break;
                case String c when c.Contains('÷'):
                    Array.Clear(subs);
                    subs = _calculatorViewModel.TextBlock_result.Split('÷');
                    if (subs[1].Length != 0)
                    {
                         result = Convert.ToDecimal(subs[0]) / Convert.ToDecimal(subs[1]);
                        _calculatorViewModel.TextBlock_result = Convert.ToString(result) + "-";
                    }
                    break;
                case String d when d.Contains('-'):
                    Array.Clear(subs);
                     
                    switch (_calculatorViewModel.TextBlock_result.Count(x => x == '-'))
                    {
                        case 1:
                            if(_calculatorViewModel.TextBlock_result[0]=='-')
                            {
                                _calculatorViewModel.TextBlock_result=_calculatorViewModel.TextBlock_result+"-";
                            }
                            else
                            {
                                subs = _calculatorViewModel.TextBlock_result.Split('-');
                                if (subs[1].Length > 0)
                                {
                                    result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                                    _calculatorViewModel.TextBlock_result=Convert.ToString(result) + "-";
                                }
                                else
                                {
                                    _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result.Remove(_calculatorViewModel.TextBlock_result.Length - 1, 1);
                                    _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + "-";
                                }
                            }
                            break;
                        case 2:
                            if(_calculatorViewModel.TextBlock_result[0]=='-')
                            {
                                _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result.Remove(0, 1);
                                subs = _calculatorViewModel.TextBlock_result.Split('-');
                                subs[0] = '-' + subs[0];
                                if (subs[1].Length > 0)
                                {
                                    result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                                    _calculatorViewModel.TextBlock_result = Convert.ToString(result)+'-';
                                }
                                else
                                {
                                    _calculatorViewModel.TextBlock_result = subs[0] + '-';
                                }
                            }
                            else
                            {
                                _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result.Remove(_calculatorViewModel.TextBlock_result.IndexOf('-'), 1);
                                subs = _calculatorViewModel.TextBlock_result.Split('-');
                                subs[1] = "-" + subs[1];
                                result = Convert.ToDecimal(subs[0]) + Convert.ToDecimal(subs[1]);
                                _calculatorViewModel.TextBlock_result = Convert.ToString(result) + '-';
                                
                            }
                            break;
                        case 3:
                            _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result.Remove(0, 1);
                            _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result.Remove(_calculatorViewModel.TextBlock_result.IndexOf('-'), 1);
                            subs = _calculatorViewModel.TextBlock_result.Split('-');
                            subs[0] = '-' + subs[0];
                            subs[1] = '-' + subs[1];
                            result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                            _calculatorViewModel.TextBlock_result = Convert.ToString(result) + '-';
                            break;
                        default:
                            _calculatorViewModel.TextBlock_result = "didn't enter";
                            break;
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
