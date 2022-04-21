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
    public class NavigationViewModel : ViewModelBase
    {
        private string _test;
        public ICommand Button_simplecalculator_Click { get; }
        public ICommand Button_converter_Click { get; }
        public NavigationViewModel(NavigationStore navigationStore)
        {
            _test = "Test";
            Button_simplecalculator_Click = new Button_simplecalculator_Click(this,navigationStore);
            Button_converter_Click = new Button_converter_Click(this,navigationStore);
        }
        public string Test
        {
            get { return _test; }
        }
    }
}
