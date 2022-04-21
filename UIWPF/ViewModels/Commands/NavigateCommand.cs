using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.Commands;
using UIWPF.Services;
using UIWPF.Stores;

namespace UIWPF.ViewModels.Commands
{
    internal class NavigateCommand<TViewModel> : CommandBase
        where TViewModel:ViewModelBase
    {
        private readonly NavigationService<TViewModel> _navigationStore;

        public NavigateCommand(Services.NavigationService<TViewModel> navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.Navigate();
        }
    }
}
