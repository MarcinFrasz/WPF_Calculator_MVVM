using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UIWPF.Commands;
using UIWPF.Stores;
using UIWPF.ViewModels.Commands;
using UIWPF.ViewModels.Commands.NumbersCommands;

namespace UIWPF.ViewModels
{
    public class CalculatorViewModel : ViewModelBase
    {
        private bool _buttons_enabled;
        private  string  _textBlock_result;
        private readonly string _button_clear;
        private readonly string _button_clearall;
        private int _sidePanelWidth;

        private readonly string _button_sign;
        private readonly string _button_dot;
        private readonly string _button_0;


        private readonly char _button_1;
        private readonly char _button_2;
        private readonly char _button_3;
        private readonly char _button_4;
        private readonly char _button_5;
        private readonly char _button_6;
        private readonly char _button_7;
        private readonly char _button_8;
        private readonly char _button_9;


        private readonly string _button_fraction;
        private readonly string _button_x_squared;
        private readonly string _button_squareroot_of_x;
        private readonly string _button_division;
        private readonly string _button_multiplication;
        private readonly string _button_substraction;
        private readonly string _button_addition;
        private readonly string _button_equals;
        public ICommand Button_0_Click { get; }
        public ICommand Button_1_Click { get; }
        public ICommand Button_2_Click { get; }
        public ICommand Button_3_Click { get; }
        public ICommand Button_4_Click { get; }
        public ICommand Button_5_Click { get; }
        public ICommand Button_6_Click { get; }
        public ICommand Button_7_Click { get; }
        public ICommand Button_8_Click { get; }
        public ICommand Button_9_Click { get; }
        public ICommand Button_fraction_Click { get; }
        public ICommand Button_x_squared_Click { get; }
        public ICommand Button_squareroot_of_x_Click { get; }
        public ICommand Button_division_Click { get; }
        public ICommand Button_multiplication_Click { get; }
        public ICommand Button_substraction_Click { get; }
        public ICommand Button_addition_Click { get; }
        public ICommand Button_sign_Click { get; }
        public ICommand Button_dot_Click { get; }
        public ICommand Button_equals_Click { get; }
        public ICommand Button_clear_Click { get; }
        public ICommand Button_clearall_Click { get; }
        public ICommand Button_menu_Click { get; }
        internal NavigationViewModel _navigationViewModel;

        internal CalculatorViewModel(NavigationViewModel navigationViewModel)
        {
            _navigationViewModel = navigationViewModel;
            _sidePanelWidth = 0;
            _buttons_enabled = true;
            _textBlock_result = "0";
            _button_sign = "+/-";
            _button_dot = ".";
            _button_0 = "0";
            _button_1 = '1';
            _button_2 = '2';
            _button_3 = '3';
            _button_4 = '4';
            _button_5 = '5';
            _button_6 = '6';
            _button_7 = '7';
            _button_8 = '8';
            _button_9 = '9';
            _button_fraction = "1/x";
            _button_x_squared = "x²";
            _button_squareroot_of_x = "√x";
            _button_division = "÷";
            _button_multiplication = "x";
            _button_substraction = "-";
            _button_addition = "+";
            _button_equals = "=";
            _button_clear = "|X|";
            _button_clearall = "C";

            Button_dot_Click = new Button_dot_Click(this);
            Button_sign_Click = new Button_sign_Click(this);
            Button_clear_Click = new Button_clear_Click(this);
            Button_clearall_Click = new Button_clearall_Click(this);
            Button_0_Click = new Button_0_Click(this);
            Button_1_Click = new Button_1_Click(this);
            Button_2_Click = new Button_2_Click(this);
            Button_3_Click = new Button_3_Click(this);
            Button_4_Click = new Button_4_Click(this);
            Button_5_Click = new Button_5_Click(this);
            Button_6_Click = new Button_6_Click(this);
            Button_7_Click = new Button_7_Click(this);
            Button_8_Click = new Button_8_Click(this);
            Button_9_Click = new Button_9_Click(this);
            Button_addition_Click = new Button_addition_Click(this);
            Button_substraction_Click = new Button_substraction_Click(this);
            Button_multiplication_Click=new Button_multiplication_Click(this);
            Button_division_Click = new Button_division_Click(this);
            Button_equals_Click = new Button_equals_Click(this);
            Button_fraction_Click = new Button_fraction_Click(this);
            Button_x_squared_Click = new Button_x_squared_Click(this);
            Button_squareroot_of_x_Click = new Button_squareroot_of_x_Click(this);
            Button_menu_Click = new Button_menu_Click(this);
        }

        public NavigationViewModel NavigationViewModel
        {
            get { return _navigationViewModel; }
        }
        public int SidePanelWidth
        {
            get { return _sidePanelWidth; }
            set
            {
                _sidePanelWidth = value;
                OnPropertyChanged(nameof(SidePanelWidth));
            }
        }
        public bool Buttons_enabled
        {
            get { return _buttons_enabled; }
            set 
            {
                _buttons_enabled = value;
                OnPropertyChanged(nameof(Buttons_enabled));
            }
        }
        public string TextBlock_result
        {
            get { return _textBlock_result; }
            set
            {
                _textBlock_result = value;
                OnPropertyChanged(nameof(TextBlock_result));
            }
        }
        
        public string Button_0
        {
            get { return _button_0; }
        }
        public char Button_1
        {
            get { return _button_1; }
        }
        public char Button_2
        {
            get { return _button_2; }
        }
        public char Button_3
        {
            get { return _button_3; }
        }
        public char Button_4
        {
            get { return _button_4; }
        }
        public char Button_5
        {
            get { return _button_5; }
        }
        public char Button_6
        {
            get { return _button_6; }
        }
        public char Button_7
        {
            get { return _button_7; }
        }
        public char Button_8
        {
            get { return _button_8; }
        }
        public char Button_9
        {
            get { return _button_9; }
        }
        public string Button_fraction
        {
            get { return _button_fraction; }
        }
        public string Button_x_squared
        {
            get { return _button_x_squared; }
        }
        public string Button_squareroot_of_x
        {
            get { return _button_squareroot_of_x; }
        }
        public string Button_divison
        {
            get { return _button_division; }
        }
        public string Button_multiplication
        {
            get { return _button_multiplication; }
        }
        public string Button_substraction
        {
            get { return _button_substraction; }
        }
        public string Button_addition
        {
            get { return _button_addition; }
        }
        public string Button_sign
        {
            get { return _button_sign; }
        }
        public string Button_dot
        {
            get { return _button_dot; }
        }
        public string Button_equals
        {
            get { return _button_equals; }
        }
        public string Button_clear
        {
            get { return _button_clear; }
        }
        public string Button_clearall
        {
            get { return _button_clearall; }
        }
    }
}
