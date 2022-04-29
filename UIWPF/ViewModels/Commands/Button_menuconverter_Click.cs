using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.Commands;

namespace UIWPF.ViewModels.Commands
{
    internal class Button_menuconverter_Click : CommandBase
    {
        private  ConverterViewModel _converterViewModel;
        public Button_menuconverter_Click(ConverterViewModel converterViewModel)
        {
            _converterViewModel = converterViewModel;
        }
        public override void Execute(object? parameter)
        {
            if (_converterViewModel.NavigationViewModel.NavigationWidth > 0)
                _converterViewModel.NavigationViewModel.NavigationWidth = 0;
            else
                _converterViewModel.NavigationViewModel.NavigationWidth = 150;
        }
    }
}
