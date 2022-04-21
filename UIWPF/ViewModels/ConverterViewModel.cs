using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWPF.Stores;

namespace UIWPF.ViewModels
{
    internal class ConverterViewModel: ViewModelBase
    {
        private string _test;
        private  NavigationViewModel _navigationViewModel;
        public ConverterViewModel(NavigationViewModel navigationViewModel)
        {
            _navigationViewModel = navigationViewModel;
            _test = "test";
        }
        public NavigationViewModel NavigationViewModel
        {
            get { return _navigationViewModel; }
        }
        public string Test
        {
            get { return _test; }
        }
    }
}
