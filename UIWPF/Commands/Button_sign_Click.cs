using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    public class Button_sign_Click : CommandBase
    {
        CalculatorViewModel _calculatorViewModel;
        string[] subs = { "", ""};
        public Button_sign_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel=calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            switch(_calculatorViewModel.TextBlock_result)
            {
                case String a when a.Contains('+'):
                    subs = _calculatorViewModel.TextBlock_result.Split('+');
                    if(subs[1].Length>0)
                    {
                        if(subs[1].Contains('-'))
                        {
                            subs[1].Remove(0, 1);
                        }
                        else
                        {
                            subs[1] = '-' + subs[1];
                        }
                        _calculatorViewModel.TextBlock_result = subs[0] + "+" + subs[1];
                    }     
                    break;
                case String b when b.Contains('-'):
                    //extra steps needed
                    break;
                case String c when c.Contains('x'):
                    subs = _calculatorViewModel.TextBlock_result.Split('x');
                    if (subs[1].Length > 0)
                    {
                        if (subs[1].Contains('-'))
                        {
                            subs[1].Remove(0, 1);
                        }
                        else
                        {
                            subs[1] = '-' + subs[1];
                        }
                        _calculatorViewModel.TextBlock_result = subs[0] + "x" + subs[1];
                    }
                    break;
                case String d when d.Contains('÷'):
                    subs = _calculatorViewModel.TextBlock_result.Split('÷');
                    if (subs[1].Length > 0)
                    {
                        if (subs[1].Contains('-'))
                        {
                            subs[1].Remove(0, 1);
                        }
                        else
                        {
                            subs[1] = '-' + subs[1];
                        }
                        _calculatorViewModel.TextBlock_result = subs[0] + "÷" + subs[1];
                    }
                    break;
                default:
                    if (_calculatorViewModel.TextBlock_result[0] != '-')
                        _calculatorViewModel.TextBlock_result = '-' + _calculatorViewModel.TextBlock_result;
                    else
                        _calculatorViewModel.TextBlock_result.Remove(0, 1);
                    break;
            }
        }
    }
}
