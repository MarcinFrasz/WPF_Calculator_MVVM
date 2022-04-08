using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    internal class Button_4_Click:CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;
        internal Button_4_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        private string FourClick_functionality(string textBox_content)
        {
            if (textBox_content == "0")
                textBox_content = "4";
            else
            {
                if (textBox_content == "-0")
                    textBox_content = "-4";
                else
                    textBox_content = textBox_content + '4';
            }
            return textBox_content;
        }
        public override void Execute(object? parameter)
        {
            _calculatorViewModel.TextBlock_result=FourClick_functionality(_calculatorViewModel.TextBlock_result);
        }
    }
}
