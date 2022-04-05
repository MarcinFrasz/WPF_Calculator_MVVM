using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UIWPF.ViewModels
{
    public class CalculatorViewModel : ViewModelBase
    {
        private string _textBox_result;

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


        private string _button_fraction = "1/x";
        private string _button_x_squared = "x²";
        private string _button_squareroot_of_x = "√x";
        private string _button_division = "÷";
        private string _button_multiplication = "x";
        private string _button_substraction = "-";
        private string _button_addition = "+";

        public CalculatorViewModel()
        {
          _textBox_result = "0";

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
    }

        public string TextBox_result
        {
            get { return _textBox_result; }
            set
            {
                _textBox_result = value;
                OnPropertyChanged(nameof(TextBox_result));
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



    }
}
