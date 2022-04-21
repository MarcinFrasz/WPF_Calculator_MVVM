using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UIWPF.Services;
using UIWPF.Stores;
using UIWPF.ViewModels.Commands;

namespace UIWPF.ViewModels
{
    public class NavigationViewModel : ViewModelBase
    {
        private int _navigationWidth;
        public ICommand Button_simplecalculator_Click { get; }
        public ICommand Button_converter_Click { get; }
        public ICommand Button_menu_Click { get; }
        public NavigationViewModel(NavigationStore navigationStore, NavigationService<CalculatorViewModel> calculatorNavigationService, NavigationService<ConverterViewModel> converterNavigationService)
        {
            _navigationWidth = 0;
            Button_simplecalculator_Click =new NavigateCommand<CalculatorViewModel>(calculatorNavigationService);
            Button_converter_Click = new NavigateCommand<ConverterViewModel>(converterNavigationService);
            Button_menu_Click = new Button_menu_Click(this);
        }
        public int NavigationWidth
        {
            get { return _navigationWidth; }
            set 
            {
                _navigationWidth = value;
                OnPropertyChanged(nameof(NavigationWidth));
            }
        }
    }
}
