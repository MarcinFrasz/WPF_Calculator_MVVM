﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    public class Button_2_Click:CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;
        public Button_2_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            if (_calculatorViewModel.TextBlock_result != "0")
            {
                _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + "2";
            }
            else
            {
                _calculatorViewModel.TextBlock_result = "2";
            }
        }
    }
}
