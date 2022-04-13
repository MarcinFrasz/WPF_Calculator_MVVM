using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.Commands.Functions;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    internal class Button_x_squared_Click : CommandBase
    {
        CalculatorViewModel _calculatorViewModel;
        internal Button_x_squared_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel=calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            _calculatorViewModel.TextBlock_result = op.FractionSquareSquareRoot_Functionality(_calculatorViewModel.TextBlock_result, '2');
        }
    }
}
