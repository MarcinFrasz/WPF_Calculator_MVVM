using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    internal class Button_clearall_Click : CommandBase
    {
        CalculatorViewModel _calculatorViewModel;
        internal Button_clearall_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            _calculatorViewModel.TextBlock_result = "0";
        }
    }
}
