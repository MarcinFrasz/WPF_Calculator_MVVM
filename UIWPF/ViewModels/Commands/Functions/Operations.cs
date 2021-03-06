using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UIWPF.Commands.Functions
{
    internal class Operations
    {
        private string Remove_useless_zeros(string textBox_content)
        {
            if (Regex.IsMatch(textBox_content, @"^[0-9-]*[.]+[0]*[x÷+-]+$"))
            {
                char operation_sign = textBox_content[textBox_content.Length - 1];
                string[] subs = textBox_content.Split('.');
                textBox_content = subs[0] + operation_sign;
            }
            else 
            {
                if (textBox_content.Contains('.'))
                {
                    int len = textBox_content.Length;
                    if (textBox_content[len - 1] == '+' || textBox_content[len - 1] == '-' || textBox_content[len - 1] == 'x' || textBox_content[len - 1] == '÷')
                    {
                        while (textBox_content[len - 2] == '0' && len >= 0)
                        {
                            textBox_content = textBox_content.Remove(len - 2, 1);
                            len = textBox_content.Length;
                        }
                        if (textBox_content[len - 2]=='.')
                            textBox_content.Remove(len - 2, 1);
                    }
                    else
                    {
                        while (textBox_content[len - 1] == '0' && len >= 0)
                        {
                            textBox_content = textBox_content.Remove(len - 1, 1);
                            len = textBox_content.Length;
                        }
                        if (textBox_content[len - 1] == '.')
                            textBox_content = textBox_content.Remove(len - 1, 1);
                    }       
                }
            }
            return textBox_content;
        }
        private string Operations_excluded_substraction(string textBox_content,char sign_type,char operation_type)
        {
            string[] subs = { "", "" };
            decimal result = 0;
            Array.Clear(subs);
            subs = textBox_content.Split(sign_type);
            if(subs[1].Length > 0)
            {
                switch(sign_type)
                {
                    case '+':
                        result = Convert.ToDecimal(subs[0]) + Convert.ToDecimal(subs[1]);
                        if (operation_type != '\0')
                            textBox_content = Convert.ToString(result) + operation_type;
                        else
                            textBox_content = Convert.ToString(result);      
                        textBox_content = Remove_useless_zeros(textBox_content);
                        break;
                    case 'x':
                        result = Convert.ToDecimal(subs[0]) * Convert.ToDecimal(subs[1]);
                        if (operation_type != '\0')
                            textBox_content = Convert.ToString(result) + operation_type;
                        else
                            textBox_content = Convert.ToString(result);
                        textBox_content = Remove_useless_zeros(textBox_content);
                        break;
                    case '÷':
                        if (subs[1] == "0")
                            textBox_content = "Cannot divide by 0";                           
                        else
                        {
                            if (Convert.ToDecimal(subs[1]) != 0)
                            {
                                result = Convert.ToDecimal(subs[0]) / Convert.ToDecimal(subs[1]);
                                if (operation_type != '\0')
                                    textBox_content = Convert.ToString(result) + operation_type;
                                else
                                    textBox_content = Convert.ToString(result);
                                textBox_content =Remove_useless_zeros(textBox_content);
                            }
                            else
                            {
                                textBox_content = "Cannot divide by 0";
                            }
                        }
                        break;
                }
            }
            return textBox_content;
        }
        private string Operations_substraction(string textBox_content,char operation_type)
        {
            decimal result = 0;
            string[] subs = {"","" };
            switch (textBox_content.Count(x => x == '-'))
            {
                case 1:
                    if (textBox_content[0] == '-')
                    {
                        if(operation_type!='\0')
                        textBox_content = textBox_content + operation_type;
                    }
                    else
                    {
                        subs = textBox_content.Split('-');
                        if (subs[1].Length > 0)
                        {
                            result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                            if (operation_type != '\0')
                                textBox_content = Convert.ToString(result) + operation_type;
                            else
                                textBox_content = Convert.ToString(result);
                            textBox_content = Remove_useless_zeros(textBox_content);
                        }
                    }
                    break;
                case 2:
                    if (textBox_content[0] == '-')
                    {
                        textBox_content = textBox_content.Remove(0, 1);
                        subs = textBox_content.Split('-');
                        subs[0] = '-' + subs[0];
                        if (subs[1].Length > 0)
                        {
                            result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                            if (operation_type != '\0')
                                textBox_content = Convert.ToString(result) + operation_type;
                            else
                                textBox_content = Convert.ToString(result);
                            textBox_content = Remove_useless_zeros(textBox_content);
                        }
                        else
                        {
                            textBox_content = subs[0]+'-';
                        }
                    }
                    else
                    {
                        textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'), 1);
                        subs = textBox_content.Split('-');
                        subs[1] = "-" + subs[1];
                        result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                        if (operation_type != '\0')
                            textBox_content = Convert.ToString(result) + operation_type;
                        else
                            textBox_content = Convert.ToString(result);
                        textBox_content = Remove_useless_zeros(textBox_content);

                    }
                    break;
                case 3:
                    textBox_content = textBox_content.Remove(0, 1);
                    textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'), 1);
                    subs = textBox_content.Split('-');
                    subs[0] = '-' + subs[0];
                    subs[1] = '-' + subs[1];
                    result = Convert.ToDecimal(subs[0]) - Convert.ToDecimal(subs[1]);
                    if (operation_type != '\0')
                        textBox_content = Convert.ToString(result) + operation_type;
                    else
                        textBox_content = Convert.ToString(result);
                    textBox_content = Remove_useless_zeros(textBox_content);
                    break;
            }
            return textBox_content;
        }
        internal string Calculations_for_Execute(string textBox_content, char sign_type,char operation_sing)
        {
            int n = textBox_content.Length - 1;
                if (sign_type != '-')
                {

                    textBox_content = Operations_excluded_substraction(textBox_content, sign_type,operation_sing);

                }
                else
                {
                    textBox_content = Operations_substraction(textBox_content,operation_sing);
                }
            
            return textBox_content;
        }
        internal string Calculations_for_default_Execute(string textBox_content,char operation_type)
        {
            if (textBox_content[textBox_content.Length - 1].Equals('.'))
            {
                textBox_content = textBox_content.Remove(textBox_content.Length - 1, 1);
            }
            else
            {
                int n = textBox_content.Length-1;
                if (!Regex.IsMatch(textBox_content, @"^[0-9-]*[x÷+-]+$"))
                    textBox_content = textBox_content + operation_type;
            }
            return textBox_content;
        }
    }
}
