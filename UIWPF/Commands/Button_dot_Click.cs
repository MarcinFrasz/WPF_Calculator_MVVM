using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;


namespace UIWPF.Commands
{
    internal class Button_dot_Click : CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;
        internal Button_dot_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        private string Dot_functionality_negativeswitchcase(string textBox_content,char sign_type)
        {
            string[] subs = { "", "" };
            switch (textBox_content.Count(x => x == sign_type))
            {
                case 1:
                    if (textBox_content[0] == sign_type && textBox_content.Length > 1 && !textBox_content.Contains('.'))
                        textBox_content = textBox_content + '.';
                    else
                    {
                        if (textBox_content.Length > 1 && textBox_content[0] != sign_type)
                        {
                            subs = textBox_content.Split(sign_type);
                            if (subs[1].Length > 0 && !subs[1].Contains('.'))
                            {
                                subs[1] = subs[1] + '.';
                            }
                            else
                            {
                                if (!subs[1].Contains('.'))
                                    subs[1] = subs[1] + ".";
                            }
                            textBox_content = subs[0] + sign_type + subs[1];
                        }

                    }

                    break;
                case 2:
                    if (textBox_content[0] == sign_type)
                    {
                        textBox_content = textBox_content.Remove(0, 1);
                        subs = textBox_content.Split(sign_type);
                        if (subs[1].Length > 0 && !subs[1].Contains('.'))
                        {
                            subs[1] = subs[1] + '.';
                        }
                        else
                        {
                            if (subs[1].Length == 0)
                            {
                                subs[1] = "0.";
                            }
                        }
                        textBox_content = sign_type + subs[0] + sign_type + subs[1];
                    }
                    else
                    {
                        textBox_content = textBox_content.Remove(textBox_content.IndexOf(sign_type), 1);
                        subs = textBox_content.Split(sign_type);
                        if (subs[1].Length > 0 && !subs[1].Contains('.'))
                        {
                            textBox_content = subs[0] + sign_type + sign_type + subs[1] + "0.";
                        }
                        else
                        {
                            if (subs[1].Length == 0)
                            {
                                textBox_content = subs[0] + sign_type + sign_type + "0.";
                            }
                        }
                    }
                    break;
                case 3:
                    textBox_content = textBox_content.Remove(textBox_content.IndexOf(sign_type), 1);
                    textBox_content = textBox_content.Remove(textBox_content.IndexOf(sign_type), 1);
                    subs = textBox_content.Split(sign_type);
                    if (subs[1].Length > 0 && !subs[1].Contains('.'))
                    {
                        textBox_content = sign_type + subs[0] + sign_type + sign_type + subs[1];
                    }
                    else
                    {
                        if (subs[1].Length == 0)
                        {
                            textBox_content = sign_type + subs[0] + sign_type + sign_type + "0.";
                        }
                    }
                    break;
            }
            return textBox_content;
        }
        internal string Dot_functionality(string textBox_content, char sign_type)
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
                        if(subs[1].Length!=1 || !subs[1].Contains('.'))
                            textBox_content = textBox_content + ".";
                    }

                }
            }
            else
            {
                textBox_content=Dot_functionality_negativeswitchcase(textBox_content, sign_type);
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
                int n = _calculatorViewModel.TextBlock_result.Length - 1;
                if (_calculatorViewModel.TextBlock_result[n] != '-' && _calculatorViewModel.TextBlock_result[n] != '+' && _calculatorViewModel.TextBlock_result[n] != 'x' && _calculatorViewModel.TextBlock_result[n] != '÷' && _calculatorViewModel.TextBlock_result[n]!='.')
                    _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + ".";
                else
                    _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + "0.";
            }
        }
    }
}
