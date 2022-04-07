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
        private string Calculations_for_Execute(string textBox_content,char sign_type)
        {
            string[] subs = { "", "" };
            decimal result = 0;
            if (sign_type!='-')
            {
                Array.Clear(subs);
                subs = textBox_content.Split(sign_type);
                if (subs[1].Length > 0)
                {
                    result = Convert.ToDecimal(subs[0]) + Convert.ToDecimal(subs[1]);
                    _calculatorViewModel.TextBlock_result = Convert.ToString(result) + "-";
                }
            }
            else
            {
                switch (textBox_content.Count(x => x == sign_type))
                {
                    case 1:
                        if (textBox_content[0] == sign_type)
                        {
                            textBox_content = textBox_content + '-';
                        }
                        else
                        {
                            subs = textBox_content.Split('-');
                            if (subs[1].Length > 0)
                            {
                                result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                                textBox_content = Convert.ToString(result) + '-';
                            }
                            else
                            {
                                textBox_content = textBox_content.Remove(_calculatorViewModel.TextBlock_result.Length - 1, 1);
                                textBox_content = textBox_content + '-';
                            }
                        }
                        break;
                    case 2:
                        if (textBox_content[0] == sign_type)
                        {
                            textBox_content = textBox_content.Remove(0, 1);
                            subs = textBox_content.Split(sign_type);
                            subs[0] = '-' + subs[0];
                            if (subs[1].Length > 0)
                            {
                                result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                                textBox_content = Convert.ToString(result) + '-';
                            }
                            else
                            {
                                textBox_content = subs[0] + '-';
                            }
                        }
                        else
                        {
                            textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'), 1);
                            subs = textBox_content.Split('-');
                            subs[1] = "-" + subs[1];
                            result = Convert.ToDecimal(subs[0]) + Convert.ToDecimal(subs[1]);
                            textBox_content = Convert.ToString(result) + '-';

                        }
                        break;
                    case 3:
                        textBox_content = textBox_content.Remove(0, 1);
                        textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'), 1);
                        subs = textBox_content.Split('-');
                        subs[0] = '-' + subs[0];
                        subs[1] = '-' + subs[1];
                        result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                        textBox_content = Convert.ToString(result) + '-';
                        break;
                }
            }
            return textBox_content;
        }
        public override void Execute(object? parameter)
        {
            string[] subs = { "", "" };
            decimal result = 0;
            switch (_calculatorViewModel.TextBlock_result)
            {
                case String a when a.Contains('+'):
                    _calculatorViewModel.TextBlock_result=Calculations_for_Execute(_calculatorViewModel.TextBlock_result, '+');
                    break;
                case String b when b.Contains('x'):
                    _calculatorViewModel.TextBlock_result = Calculations_for_Execute(_calculatorViewModel.TextBlock_result, 'x');
                    break;
                case String c when c.Contains('÷'):
                    _calculatorViewModel.TextBlock_result = Calculations_for_Execute(_calculatorViewModel.TextBlock_result, '÷');
                    break;
                case String d when d.Contains('-'):
                    _calculatorViewModel.TextBlock_result = Calculations_for_Execute(_calculatorViewModel.TextBlock_result, '-');
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
