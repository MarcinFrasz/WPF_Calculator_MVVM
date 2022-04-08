using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    internal class Button_8_Click:CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;
        internal Button_8_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        private string EightClick_functionality(string textBox_content)
        {
            if (textBox_content == "0")
                textBox_content = "8";
            else
            {
                if (textBox_content == "-0")
                    textBox_content = "-8";
                else
                    textBox_content = textBox_content + '8';
            }
            return textBox_content;
        }
        public override void Execute(object? parameter)
        {
            _calculatorViewModel.TextBlock_result=EightClick_functionality(_calculatorViewModel.TextBlock_result);
        }
    }
}
