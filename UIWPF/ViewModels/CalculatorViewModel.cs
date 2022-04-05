using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UIWPF.Commands;

namespace UIWPF.ViewModels
{
    public class CalculatorViewModel : ViewModelBase
    {
        private string _textBlock_result;

        private string _button_sign;
        private string _button_dot;
        private string _button_0 ;


        private string _button_1;
        private string _button_2;
        private string _button_3;
        private string _button_4;
        private string _button_5;
        private string _button_6;
        private string _button_7;
        private string _button_8;
        private string _button_9;


        private string _button_fraction;
        private string _button_x_squared;
        private string _button_squareroot_of_x;
        private string _button_division;
        private string _button_multiplication;
        private string _button_substraction;
        private string _button_addition;
        private string _button_equals;

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

        public CalculatorViewModel()
        {
        _textBlock_result = "0";
          _button_sign = "+/-";
          _button_dot = ".";
          _button_0 = "0";
          _button_1 = "1";
          _button_2 = "2";
          _button_3 = "3";
          _button_4 = "4";
          _button_5 = "5";
          _button_6 = "6";
          _button_7 = "7";
          _button_8 = "8";
          _button_9 = "9";
          _button_fraction = "1/x";
          _button_x_squared = "x²";
          _button_squareroot_of_x = "√x";
          _button_division = "÷";
          _button_multiplication = "x";
          _button_substraction = "-";
         _button_addition = "+";
         _button_equals = "=";

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
        public string Button_1
        {
            get { return _button_1; }
        }
        public string Button_2
        {
            get { return _button_2; }
        }
        public string Button_3
        {
            get { return _button_3; }
        }
        public string Button_4
        {
            get { return _button_4; }
        }
        public string Button_5
        {
            get { return _button_5; }
        }
        public string Button_6
        {
            get { return _button_6; }
        }
        public string Button_7
        {
            get { return _button_7; }
        }
        public string Button_8
        {
            get { return _button_8; }
        }
        public string Button_9
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
    }
}
