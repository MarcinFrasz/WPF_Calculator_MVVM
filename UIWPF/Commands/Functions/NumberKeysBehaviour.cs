using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWPF.Commands.Functions
{
    internal class NumberKeysBehaviour
    {
        internal string NumKeysBehaviour(string textBox_content,char num)
        {
            if (textBox_content == "0")
                textBox_content = Convert.ToString(num);
            else
            {
                if (textBox_content == "-0")
                    textBox_content = "-"+num;
                else
                    textBox_content = textBox_content + num;
            }
            return textBox_content;
        }
    }
}
