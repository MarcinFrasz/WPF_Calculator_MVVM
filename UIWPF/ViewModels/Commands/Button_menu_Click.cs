using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.Commands;

namespace UIWPF.ViewModels.Commands
{
    internal class Button_menu_Click : CommandBase
    {
        CalculatorViewModel _calculatorViewModel;
        internal Button_menu_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            if (_calculatorViewModel.SidePanelWidth > 0)
                _calculatorViewModel.SidePanelWidth = 0;
            else
                _calculatorViewModel.SidePanelWidth = 150;


        }
    }
}
