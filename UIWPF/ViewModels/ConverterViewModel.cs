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
    public class ConverterViewModel : ViewModelBase
    {
        private NavigationViewModel _navigationViewModel;
        public ICommand Button_menu_Click { get; }
        public ICommand Button_convert_Click { get; }
        private string _result;
        private string _inputValue;
        private string _selectedInput;
        private string _selectedOutput;
        private List<string> _comboboxInputList;
        private List<string> _comboboxOutputList;

        public ConverterViewModel(NavigationViewModel navigationViewModel)
        {
            SelectedInput = "decimal";
            _comboboxInputList = new List<string>(new string[] {"decimal","binary","hexadecimal"});            
            _result = "";
            _inputValue = "";
            navigationViewModel.NavigationWidth = 0;
            _navigationViewModel = navigationViewModel;
            Button_menu_Click = new Button_menuconverter_Click(this);
            Button_convert_Click = new Button_convert_Click(this);
        }
        public string SelectedOutput
        {
            get { return _selectedOutput; }
            set
            {
                _selectedOutput = value;
                OnPropertyChanged(nameof(SelectedOutput));
            }
        }
        public string SelectedInput
        {
            get { return _selectedInput; }
            set 
            {
                _selectedInput = value;
                switch (_selectedInput)
                {
                    case String a when a == "binary":
                        ComboBoxOutputList=new List<string>(new string[] {"decimal","hexadecimal"});
                        SelectedOutput = "decimal";
                        break;
                    case String b when b == "decimal":
                        ComboBoxOutputList = new List<string>(new string[] { "binary", "hexadecimal" });
                        SelectedOutput = "binary";
                        break;
                    case String c when c == "hexadecimal":
                        ComboBoxOutputList = new List<string>(new string[] { "decimal", "binary" });
                        SelectedOutput = "decimal";
                        break;
                }
            }
        }
        public List<string> ComboBoxOutputList
        {
            get { return _comboboxOutputList; }
            set
            {
                _comboboxOutputList = value;
                OnPropertyChanged(nameof(ComboBoxOutputList));
            }
        }
        public List<string> ComboBoxInputList
        {
            get { return _comboboxInputList; }
        }
        public string InputValue
        {
            get { return _inputValue; }
            set
            {
                _inputValue = value;
                OnPropertyChanged(nameof(InputValue));
            }
        }
        public string Result
            {
            get{ return _result; }
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
            }
        public NavigationViewModel NavigationViewModel
        {
            get { return _navigationViewModel; }
        }
    }
}
