using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;
using UIWPF.Commands.Functions;

namespace UIWPF.Commands
{
    internal class Button_fraction_Click : CommandBase
    {
        CalculatorViewModel _calculatorViewModel;
        internal Button_fraction_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }

        public override void Execute(object? parameter)
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            _calculatorViewModel.TextBlock_result=op.FractionSquareSquareRoot_Functionality(_calculatorViewModel.TextBlock_result,'1');
        }
    }
}
