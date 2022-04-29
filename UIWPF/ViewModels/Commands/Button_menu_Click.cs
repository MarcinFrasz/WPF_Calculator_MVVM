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
        private NavigationViewModel _navigationViewModel;
        internal Button_menu_Click(NavigationViewModel navigationViewModel)
        {
            _navigationViewModel = navigationViewModel;
        }
        public override void Execute(object? parameter)
        {
            if (_navigationViewModel.NavigationWidth > 0)
                _navigationViewModel.NavigationWidth = 0;
            else
                _navigationViewModel.NavigationWidth = 150;


        }
    }
}
