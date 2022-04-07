﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UIWPF.ViewModels;

namespace UIWPF.Commands
{
    public class Button_1_Click : CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;
        public Button_1_Click(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
        public override void Execute(object? parameter)
        {
            if (_calculatorViewModel.TextBlock_result != "0")
            {
                _calculatorViewModel.TextBlock_result = _calculatorViewModel.TextBlock_result + "1";
            }
            else
            {
                _calculatorViewModel.TextBlock_result = "1";
            }
        }
    }
}