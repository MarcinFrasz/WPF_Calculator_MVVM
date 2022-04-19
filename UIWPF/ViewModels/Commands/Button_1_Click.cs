using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UIWPF.ViewModels;
using UIWPF.Commands.Functions;

namespace UIWPF.Commands
{
    internal class Button_1_Click : CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;
        internal Button_1_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            NumberKeysBehaviour nkb = new NumberKeysBehaviour();
            _calculatorViewModel.TextBlock_result = nkb.NumKeysBehaviour(_calculatorViewModel.TextBlock_result, '1');
        }
    }
}
