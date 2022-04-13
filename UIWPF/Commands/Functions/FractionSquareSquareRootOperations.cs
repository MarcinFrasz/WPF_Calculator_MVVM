using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWPF.Commands.Functions
{
    internal class FractionSquareSquareRootOperations
    {
        private string[] Negative_case_for_FractionSquareSquareRoot(string textBox_content)
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
                        textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'), 1);
                        subs = textBox_content.Split('-');
                        subs[0] = '-' + subs[0];
                    }
                    else
                    {
                        textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'), 1);
                        subs = textBox_content.Split('-');
                        subs[1] = '-' + subs[1];
                    }
                    break;
                case 3:

                    textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'), 1);
                    textBox_content = textBox_content.Remove(textBox_content.IndexOf('-'), 1);
                    subs = textBox_content.Split('-');
                    subs[0] = '-' + subs[0];
                    subs[1] = '-' + subs[1];
                    break;
            }
            return subs;
        }
        private string FractionSquareRoot(string textBox_content,char operation_type)
        {
            decimal result = 0;
            switch (operation_type)
            {
                case '1':
                    if (Convert.ToDecimal(textBox_content) != 0)
                    {
                        result = 1 / Convert.ToDecimal(textBox_content);
                        textBox_content = Convert.ToString(result);
                    }
                    else
                    {
                        textBox_content = "Cannot divide by 0";
                    }
                    break;
                case '2':
                    if (Convert.ToDecimal(textBox_content) != 0)
                    {
                        result = Convert.ToDecimal(textBox_content) * Convert.ToDecimal(textBox_content);
                        textBox_content = Convert.ToString(result);
                    }
                    else
                        textBox_content = "0";
                    break;
                case '3':
                    if (textBox_content[0] != '-')
                    {
                        result = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(textBox_content)));
                        textBox_content = Convert.ToString(result);
                    }
                    else
                    {
                        if (Convert.ToDecimal(textBox_content) == 0)
                            textBox_content = "0";
                        else
                            textBox_content = "Invalid input";
                    }
                    
                    break;
            }
            return textBox_content;
        }
        internal string FractionSquareSquareRoot_Functionality(string textBox_content,char operation_type)
        {
            string[] subs = { "", "" };
            char operation_sign = '\0';
            switch(textBox_content)
            {
                case String a when a.Contains('+'):
                    operation_sign = '+';
                    subs = textBox_content.Split('+');
                    break;
                case String b when b.Contains('x'):
                    operation_sign = 'x';
                    subs = textBox_content.Split('x');
                    break;
                case String c when c.Contains('÷'):
                    operation_sign = '÷';
                    subs = textBox_content.Split('÷');
                    break;
                case String d when d.Contains('-'):
                    operation_sign= '-';    
                    subs = Negative_case_for_FractionSquareSquareRoot(textBox_content);
                    break;
            }
            if(subs[0] == "" && subs[1] == "")
            {
                    textBox_content = FractionSquareRoot(textBox_content,operation_type);
            }
            else
            {
                if(subs[1].Length>0)
                {
                        subs[1] = FractionSquareRoot(subs[1], operation_type);
                    if (subs[1] != "Cannot divide by 0" && subs[1]!= "Invalid input")
                        textBox_content = subs[0] + operation_sign + subs[1];
                    else
                        textBox_content = subs[1];
                }
            }
            return textBox_content;
        }
    }
}
