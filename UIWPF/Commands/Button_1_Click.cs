using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    internal class Button_1_Click : CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;
        internal Button_1_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        private string OneClick_functionality(string textBox_content)
        {
            if (textBox_content == "0")
                textBox_content = "1";
            else
            {
                if (textBox_content == "-0")
                    textBox_content = "-1";
                else
                    textBox_content = textBox_content + '1';
            }
            return textBox_content;
        }
        public override void Execute(object? parameter)
        {
            _calculatorViewModel.TextBlock_result=OneClick_functionality(_calculatorViewModel.TextBlock_result);
        }
    }
}
