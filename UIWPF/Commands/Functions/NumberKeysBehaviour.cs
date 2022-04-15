using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWPF.Commands.Functions
{
    internal class NumberKeysBehaviour
    {
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
        internal string NumKeysBehaviour(string textBox_content,char num)
        {
            string[] subs = { "", "" };
            switch(textBox_content)
            {
                case String a when a.Contains('+'):
                    subs = textBox_content.Split('+');
                    break;
                case String b when b.Contains('x'):
                    subs=textBox_content.Split('x');
                    break;
                case String c when c.Contains('÷'):
                    subs = textBox_content.Split('÷');
                    break;
                case String d when d.Contains('-'):
                    subs=Negative_case_for_Clear_functionality(textBox_content);
                    break;
            }
            if (subs[0] == "" && subs[1] == "")
            {
                if (textBox_content!="0" && textBox_content!="-0")
                {
                    textBox_content = textBox_content + Convert.ToString(num);
                }
                else
                {
                    textBox_content = Convert.ToString(num);
                }
            }
            else
            {
                if (subs[1].Length > 0 && subs[1]!="0" && subs[1]!="-0")
                {
                    textBox_content = textBox_content + Convert.ToString(num);
                }
                else
                {
                    if (subs[1].Length == 0)
                        textBox_content =textBox_content+Convert.ToString(num);

                }
            }








            /*
            if (textBox_content == "0")
                textBox_content = Convert.ToString(num);
            else
            {
                if (textBox_content == "-0")
                    textBox_content = "-"+num;
                else
                    textBox_content = textBox_content + num;
            }
            */
            return textBox_content;
        }
    }
}
