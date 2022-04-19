using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    internal class Button_clear_Click : CommandBase
    {
        CalculatorViewModel _calculatorViewModel;
        internal Button_clear_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel= calculatorViewModel;
        }
        private string[] Negative_case_for_Clear_functionality(string textBox_content)
        {
            string[] subs = { "", "" };
            switch (textBox_content.Count(x => x == '-'))
            {
                case 1:
                    if (textBox_content[0] != '-')
                        subs = textBox_content.Split('-');
                    break;
                case 2:
                    if (textBox_content[0] == '-')
                    {
                        textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'),1);
                        subs = textBox_content.Split('-');
                        subs[0] = '-' + subs[0];
                    }
                    else
                    {
                        textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'),1);
                        subs = textBox_content.Split('-');
                        subs[1] = '-' + subs[1];
                    }
                    break;
                case 3:

                    textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'),1);
                    textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'),1);
                    subs = textBox_content.Split('-');
                    subs[0] = '-' + subs[0];
                    subs[1] = '-' + subs[1];
                    break;
            }
            return subs;
        }
        internal string Clear_functionality(string textBox_content)
        {
            string[] subs = { "", ""};
            char operation_type = '\0';
            switch(textBox_content)
            {
                case String a when a.Contains('+'):
                    operation_type='+';
                    subs=textBox_content.Split(operation_type);
                    break;
                case String b when b.Contains('x'):
                    operation_type = 'x';
                    subs=textBox_content.Split(operation_type);
                    break;
                case String c when c.Contains('÷'):
                    operation_type = '÷';
                    subs =textBox_content.Split(operation_type);
                    break;
                case String d when d.Contains('-'):
                    operation_type = '-';
                    subs = Negative_case_for_Clear_functionality(textBox_content);
                    break;
            }
            if(subs[0]=="" && subs[1]=="")
            {
                if (textBox_content != "0" && textBox_content!="-0" && textBox_content.Length!=0)
                {
                    textBox_content = textBox_content.Remove(textBox_content.Length - 1,1);
                    if (textBox_content.Length == 1 && textBox_content[0] == '-')
                        textBox_content = "0";
                    else
                    {
                        if (textBox_content.Length == 0)
                            textBox_content = "0";
                    }
                }
                else
                {
                    if(textBox_content.Length==0)
                        textBox_content = "0";                   
                }
            }
            else
            {
                if(subs[1].Length>0)
                {
                    subs[1]=subs[1].Remove(subs[1].Length - 1);
                    if(subs[1].Length == 1 && subs[1]=="-")
                    {
                        subs[1]=subs[1].Remove(subs[1].Length - 1);
                        textBox_content = subs[0] + operation_type;
                    }
                    else
                    {
                        textBox_content = subs[0] + operation_type + subs[1];
                    }
                }
                else
                {
                    textBox_content = subs[0] + operation_type;
                }
            }
            return textBox_content;
        }
        public override void Execute(object? parameter)
        {
            _calculatorViewModel.TextBlock_result=Clear_functionality(_calculatorViewModel.TextBlock_result);
        }
    }
}
