using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UIWPF.Commands;

namespace UIWPF.ViewModels.Commands
{
    internal class Button_convert_Click : CommandBase
    {
        ConverterViewModel _converterViewModel;
        public Button_convert_Click(ConverterViewModel converterViewModel) 
        {
            _converterViewModel = converterViewModel;
        }

        private string ConvertFunctionality(string inputType,string outputType,string input)
        {
            switch(inputType)
            {
                case String a when a == "decimal":
                    int dummy;
                    if (Int32.TryParse(input, out dummy))
                    {
                        switch (outputType)
                        {
                            case String b when b == "binary":
                                    input = Convert.ToString(Convert.ToInt32(input), 2);
                                break;
                            case String c when c == "hexadecimal":
                                input = Convert.ToInt32(input).ToString("X8");
                                break;
                        }
                    }
                    else
                        input = "Invalid input";
                    break;
                case String b when b == "binary":
                    if (Regex.IsMatch(input, @"^[0-1]*$"))
                    {
                        switch (outputType)
                        {
                            case String c when c == "decimal":
                                input = Convert.ToInt32(input, 2).ToString();
                                break;
                            case String d when d == "hexadecimal":
                                input = Convert.ToInt32(input, 2).ToString("X8");
                                break;
                        }
                    }
                    else
                        input = "Invalid input";
                    break;
                case String c when c == "hexadecimal":
                    if(Regex.IsMatch(input,@"^[0-9A-F]"))
                    {
                        switch(outputType)
                        {
                            case String a when a == "decimal":
                                input = Convert.ToInt32(input, 16).ToString();
                                break;
                            case String b when b == "binary":
                                input = Convert.ToString((Convert.ToInt32(input, 16)),2);
                                break;
                        }
                    }
                    else
                    {
                        input = "Invalid input";
                    }
                    break;
            }
            return input;
        }
        public override void Execute(object? parameter)
        {
           _converterViewModel.Result=ConvertFunctionality(_converterViewModel.SelectedInput, _converterViewModel.SelectedOutput, _converterViewModel.InputValue);
        }
    }
}
