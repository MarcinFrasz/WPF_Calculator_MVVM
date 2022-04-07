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
        private string Set_sign(string textBox_content,char sign_type)
        {
            Array.Clear(subs);
            if (sign_type != '-')
            {
                subs = textBox_content.Split(sign_type);
                if (subs[1].Length > 0 && subs[1].Count(x => x == '-') == 0)
                {
                    subs[1].Remove(subs[1].IndexOf('-'), 1);
                    textBox_content = subs[0] + subs[1];
                }
                else
                {
                    if (subs[1].Length > 0)
                    {
                        textBox_content = subs[0] + '-' + subs[1];
                    }
                }
            }
            else
            {
                switch(textBox_content.Count(x=>x==sign_type))
                {
                    case 1:
                        if (textBox_content[0] == sign_type)
                            textBox_content = textBox_content.Remove(0, 1);
                        else
                        {
                            subs = textBox_content.Split(sign_type);
                            if(subs[1].Length>0)
                            {
                                textBox_content = subs[0] + sign_type + sign_type + subs[1];
                            }
                        }
                        break;
                    case 2:
                        if(textBox_content[0]== sign_type)
                        {
                            textBox_content.Remove(0, 1);
                            subs = textBox_content.Split(sign_type);
                            if (subs[1].Length > 0)
                                textBox_content = sign_type+subs[0] + sign_type +sign_type+ subs[1];
                        }
                        else
                        {
                            textBox_content=textBox_content.Remove(textBox_content.IndexOf('-'), 1);
                            subs = textBox_content.Split(sign_type);
                            if (subs[1].Length > 0)
                            {
                                textBox_content = subs[0] + sign_type + subs[1];
                            }
                            else
                                textBox_content = subs[0] + sign_type + sign_type;
                        }
                        break;
                    case 3:
                        textBox_content=textBox_content.Remove(textBox_content.IndexOf('-'));
                        textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'));
                        textBox_content = sign_type + textBox_content;
                        break;
                }
            }
            return textBox_content;
        }
        public override void Execute(object? parameter)
        {
            Array.Clear(subs);  
            switch(_calculatorViewModel.TextBlock_result)
            {
                case String a when a.Contains('+'):
                    _calculatorViewModel.TextBlock_result=Set_sign(_calculatorViewModel.TextBlock_result, '+');
                    break;
                case String b when b.Contains('x'):
                    _calculatorViewModel.TextBlock_result = Set_sign(_calculatorViewModel.TextBlock_result, 'x');
                    break;
                case String c when c.Contains('÷'):
                    _calculatorViewModel.TextBlock_result = Set_sign(_calculatorViewModel.TextBlock_result, '÷');
                    break;
                case String d when d.Contains('-'):
                    _calculatorViewModel.TextBlock_result = Set_sign(_calculatorViewModel.TextBlock_result, '-');
                    break;
                default:
                    _calculatorViewModel.TextBlock_result = '-'+_calculatorViewModel.TextBlock_result;
                    break;
            }
        }
        }
}

