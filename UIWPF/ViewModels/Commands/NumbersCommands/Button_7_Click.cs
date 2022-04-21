using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.Commands;
using UIWPF.Commands.Functions;

namespace UIWPF.ViewModels.Commands.NumbersCommands
{
    internal class Button_7_Click : CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;
        internal Button_7_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            NumberKeysBehaviour nkb = new NumberKeysBehaviour();
            _calculatorViewModel.TextBlock_result = nkb.NumKeysBehaviour(_calculatorViewModel.TextBlock_result, '7');
        }
    }
}
