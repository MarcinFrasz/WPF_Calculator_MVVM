using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UIWPF.Stores;
using UIWPF.ViewModels.Commands;

namespace UIWPF.ViewModels
{
    public class ConverterViewModel: ViewModelBase
    {
        private  NavigationViewModel _navigationViewModel;
        public ICommand Button_menu_Click { get; }
        public ConverterViewModel(NavigationViewModel navigationViewModel)
        {
            _navigationViewModel = navigationViewModel;
            Button_menu_Click = new Button_menuconverter_Click(this);
        }
        public NavigationViewModel NavigationViewModel
        {
            get { return _navigationViewModel; }
        }
    }
}
