using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.Commands.Functions;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    internal class Button_squareroot_of_x_Click : CommandBase
    {
        CalculatorViewModel _calculatorViewModel;
        internal Button_squareroot_of_x_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            _calculatorViewModel.TextBlock_result = op.FractionSquareSquareRoot_Functionality(_calculatorViewModel.TextBlock_result, '3');
            if (_calculatorViewModel.TextBlock_result == "Invalid input")
            {
                _calculatorViewModel.Buttons_enabled = false;
            }
        }
    }
}
