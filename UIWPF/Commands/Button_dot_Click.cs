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
            if(_calculatorViewModel.TextBlock_result.Contains("."))
            {
                
                switch(_calculatorViewModel.TextBlock_result)
                {
                    case String a when a.Contains("+"):
                       
                        string[] subs = _calculatorViewModel.TextBlock_result.Split('+');
                        if(!subs[1].Contains('.'))
                        {
                            if(subs[1].Length==0)
                            {
                                _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + "0.";
                            }
                            else
                            {
                                _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + ".";
                            }
                            
                        }
                        break;
                    case String b when b.Contains("-"): _calculatorViewModel.TextBlock_result = "test-"; break;
                    case String c when c.Contains("x"): _calculatorViewModel.TextBlock_result = "testx"; break;
                    case String d when d.Contains("÷"): _calculatorViewModel.TextBlock_result = "test÷"; break;
                }               
            }
            else
            {
                _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + ".";
            }
        }
    }
}
