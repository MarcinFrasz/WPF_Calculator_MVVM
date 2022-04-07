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
        private string Dot_functionality(string textBox_content,char sign_type)
        {
            string[] subs = { "", "" };
            if (sign_type != '-')
            {
                subs = textBox_content.Split(sign_type);
                if (!subs[1].Contains('.'))
                {
                    if (subs[1].Length == 0)
                    {
                        textBox_content = textBox_content + "0.";
                    }
                    else
                    {
                        textBox_content = textBox_content + ".";
                    }

                }
            }
            else
            {
                switch(textBox_content.Count(x=>x=='-'))
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
            return textBox_content;
        }
        public override void Execute(object? parameter)
        {
            if(_calculatorViewModel.TextBlock_result.Contains("."))
            {
                
                switch(_calculatorViewModel.TextBlock_result)
                {
                    case String a when a.Contains("+"):
                        _calculatorViewModel.TextBlock_result=Dot_functionality(_calculatorViewModel.TextBlock_result, '+');
                        break;
                    case String b when b.Contains("x"):
                        _calculatorViewModel.TextBlock_result = Dot_functionality(_calculatorViewModel.TextBlock_result, 'x');
                        break;
                    case String c when c.Contains("÷"):
                        _calculatorViewModel.TextBlock_result = Dot_functionality(_calculatorViewModel.TextBlock_result, '÷');
                        break;
                    case String d when d.Contains("-"):
                        _calculatorViewModel.TextBlock_result = Dot_functionality(_calculatorViewModel.TextBlock_result, '-');
                        break;
                }               
            }
            else
            {
                _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + ".";
            }
        }
    }
}
