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
        internal Button_0_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        private string ZeroClick_functionality(string textBox_content)
        {

            return textBox_content;
        }
        public override void Execute(object? parameter)
        {
            if (_calculatorViewModel.TextBlock_result != "0")
            {
                 
            }
        }
    }
}
