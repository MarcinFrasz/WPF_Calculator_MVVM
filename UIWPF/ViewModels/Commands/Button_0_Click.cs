using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    internal class Button_0_Click:CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;

        public Button_0_Click(CalculatorViewModel calculatorViewModel) 
        {
                _calculatorViewModel = calculatorViewModel;
        }

        private string ZeroClick_functionality(string textBox_content)
        {
            if(textBox_content !="0")
            {
                textBox_content = textBox_content + '0';
            }
            return textBox_content;
        }
        public override void Execute(object? parameter)
        {
            _calculatorViewModel.TextBlock_result = ZeroClick_functionality(_calculatorViewModel.TextBlock_result);
        }
    }
}
