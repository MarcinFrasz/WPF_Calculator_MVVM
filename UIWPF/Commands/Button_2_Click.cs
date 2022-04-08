using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    internal class Button_2_Click:CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;
        internal Button_2_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        private string TwoClick_functionality(string textBox_content)
        {
            if (textBox_content == "0")
                textBox_content = "2";
            else
            {
                if (textBox_content == "-0")
                    textBox_content = "-2";
                else
                    textBox_content = textBox_content + '2';
            }
            return textBox_content;
        }
        public override void Execute(object? parameter)
        {
            _calculatorViewModel.TextBlock_result=TwoClick_functionality(_calculatorViewModel.TextBlock_result);
        }
    }
}
