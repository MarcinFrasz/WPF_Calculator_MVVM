using Microsoft.VisualStudio.TestTools.UnitTesting;
using UIWPF.Commands.Functions;

namespace UIWPF.UnitTests
{
    [TestClass]
    public class OperationsTests
    {
        //naming method_name_Test_TextBox_content_Click_sign_type

        //TESTING MULTIPLICATION
        [TestMethod]
        public void Calculations_for_execute_Test_3x3_Click_x()
        {           
            var operations = new Operations();            
            var result=operations.Calculations_for_Execute("3x3",'x','x');
            Assert.AreEqual("9x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point3x0point3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.3x0.3", 'x', 'x');
            Assert.AreEqual("0.09x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_3x0point3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("3x0.3", 'x', 'x');
            Assert.AreEqual("0.9x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point3x3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.3x3", 'x', 'x');
            Assert.AreEqual("0.9x", result);
        }

        //TESTING MULTIPLICATION WITH NEGATIVE NUMBERS
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point3x3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.3x3", 'x', 'x');
            Assert.AreEqual("-0.9x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point3xminus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.3x-3", 'x', 'x');
            Assert.AreEqual("-0.9x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus3x0point3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-3x0.3", 'x', 'x');
            Assert.AreEqual("-0.9x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_3xminus0point3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("3x-0.3", 'x', 'x');
            Assert.AreEqual("-0.9x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus3xminus0point3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-3x-0.3", 'x', 'x');
            Assert.AreEqual("0.9x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus3x3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-3x3", 'x', 'x');
            Assert.AreEqual("-9x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_3xminus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("3x-3", 'x', 'x');
            Assert.AreEqual("-9x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus3xminus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-3x-3", 'x', 'x');
            Assert.AreEqual("9x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point3x0point3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.3x0.3", 'x', 'x');
            Assert.AreEqual("-0.09x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point3xminus0point3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.3x-0.3", 'x', 'x');
            Assert.AreEqual("-0.09x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point3xminus0point3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.3x-0.3", 'x', 'x');
            Assert.AreEqual("0.09x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_3x0_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("3x0", 'x', 'x');
            Assert.AreEqual("0x", result);
        }

        //TESTING MULTIPLICATION ODD CASES
        [TestMethod]
        public void Calculations_for_execute_Test_3x_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("3x", 'x', 'x');
            Assert.AreEqual("3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus3x_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-3x", 'x', 'x');
            Assert.AreEqual("-3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point1x_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.1x", 'x', 'x');
            Assert.AreEqual("0.1x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point1x_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.1x", 'x', 'x');
            Assert.AreEqual("-0.1x", result);
        }
        //TESTING DIVISION
        [TestMethod]
        public void Calculations_for_execute_Test_6div3_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("6÷3", '÷', '÷');
            Assert.AreEqual("2÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point6div0point3_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.6÷0.3", '÷', '÷');
            Assert.AreEqual("2÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0div3_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0÷3", '÷', '÷');
            Assert.AreEqual("0÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_3div0_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("3÷0", '÷', '÷');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        //TESTING DIVISION WITH NEGATIVE NUMBERS
        [TestMethod]
        public void Calculations_for_execute_Test_minus6div3_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-6÷3", '÷', '÷');
            Assert.AreEqual("-2÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_6divminus3_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("6÷-3", '÷', '÷');
            Assert.AreEqual("-2÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus6divminus3_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-6÷-3", '÷', '÷');
            Assert.AreEqual("2÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point6divminus0point3_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.6÷-0.3", '÷', '÷');
            Assert.AreEqual("-2÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point6div0point3_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.6÷0.3", '÷', '÷');
            Assert.AreEqual("-2÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point6divminus0point3_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.6÷-0.3", '÷', '÷');
            Assert.AreEqual("2÷", result);
        }
        //TESTING DIVISION ODD CASES
        [TestMethod]
        public void Calculations_for_execute_Test_6div_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("6÷", '÷', '÷');
            Assert.AreEqual("6÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus6div_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-6÷", '÷', '÷');
            Assert.AreEqual("-6÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_point6div_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.6÷", '÷', '÷');
            Assert.AreEqual("0.6÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minuspoint6div_Click_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.6÷", '÷', '÷');
            Assert.AreEqual("-0.6÷", result);
        }
        //TESTING ADDITIONS
        [TestMethod]
        public void Calculations_for_execute_Test_5plus3_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5+3", '+', '+');
            Assert.AreEqual("8+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point5plus0point3_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.5+0.3", '+', '+');
            Assert.AreEqual("0.8+", result);
        }
    
        //TESTING ADDITION FOR NEGATIVE NUMBERS
        [TestMethod]
        public void Calculations_for_execute_Test_minus5plus3_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5+3", '+', '+');
            Assert.AreEqual("-2+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5plusminus3_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5+-3", '+', '+');
            Assert.AreEqual("2+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5plusminus3_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5+-3", '+', '+');
            Assert.AreEqual("-8+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point5plus0point3_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.5+0.3", '+', '+');
            Assert.AreEqual("-0.2+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point5plusminus0point3_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.5+-0.3", '+', '+');
            Assert.AreEqual("0.2+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point5plusminus0point3_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.5+-0.3", '+', '+');
            Assert.AreEqual("-0.8+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point5plus0_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.5+0", '+', '+');
            Assert.AreEqual("-0.5+", result);
        }
        //TESTING ADDITION ODD CASES
        [TestMethod]
        public void Calculations_for_execute_Test_5plus_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5+", '+', '+');
            Assert.AreEqual("5+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5plus_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5+", '+', '+');
            Assert.AreEqual("-5+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point5plus_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.5+", '+', '+');
            Assert.AreEqual("-0.5+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point5plus_Click_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.5+", '+', '+');
            Assert.AreEqual("0.5+", result);
        }
        //TEST SUBSTRACTION
        [TestMethod]
        public void Calculations_for_execute_Test_5minus3_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5-3", '-', '-');
            Assert.AreEqual("2-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point5minus0point3_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.5-0.3", '-', '-');
            Assert.AreEqual("0.2-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point3minus0point5_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.3-0.5", '-', '-');
            Assert.AreEqual("-0.2-", result);
        }
        //TESTING SUBSTRACTION NEGATIVE NUMBERS
        [TestMethod]
        public void Calculations_for_execute_Test_minus5minus3_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5-3", '-', '-');
            Assert.AreEqual("-8-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5minusminus3_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5--3", '-', '-');
            Assert.AreEqual("8-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5minusminus3_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5--3", '-', '-');
            Assert.AreEqual("-2-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus3minusminus5_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-3--5", '-', '-');
            Assert.AreEqual("2-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point3minusminus0point5_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.3--0.5", '-', '-');
            Assert.AreEqual("0.2-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point3minus0point5_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.3-0.5", '-', '-');
            Assert.AreEqual("-0.8-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point3minusminus0point5_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.3--0.5", '-', '-');
            Assert.AreEqual("0.8-", result);
        }
        //TESTING SUBSTRACTION ODD CASES
        [TestMethod]
        public void Calculations_for_execute_Test_3minus_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("3-", '-', '-');
            Assert.AreEqual("3-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus3minus_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-3-", '-', '-');
            Assert.AreEqual("-3-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point3minus_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.3-", '-', '-');
            Assert.AreEqual("-0.3-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point3minus_Click_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.3-", '-', '-');
            Assert.AreEqual("0.3-", result);
        }
        //TESTING different buttons with operations
        [TestMethod]
        public void Calculations_for_execute_Test_5minus2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5-2", '-', 'x');
            Assert.AreEqual("3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5minus2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5-2", '-', 'x');
            Assert.AreEqual("-7x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5minusminus2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5--2", '-', 'x');
            Assert.AreEqual("7x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5minusminus2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5--2", '-', 'x');
            Assert.AreEqual("-3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5minus_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5-", '-', 'x');
            Assert.AreEqual("5-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5minus_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5-", '-', 'x');
            Assert.AreEqual("-5-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5", '-', 'x');
            Assert.AreEqual("-5x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point5_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.5", '-', 'x');
            Assert.AreEqual("-0.5x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point5minus_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.5-", '-', 'x');
            Assert.AreEqual("0.5-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5plus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5+3", '+', 'x');
            Assert.AreEqual("8x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5plus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5+3", '+', 'x');
            Assert.AreEqual("-2x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5plusminus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5+-3", '+', 'x');
            Assert.AreEqual("2x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5plusminus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5+-3", '+', 'x');
            Assert.AreEqual("-8x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5plus_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5+", '+', 'x');
            Assert.AreEqual("5+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point5plus_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.5+", '+', 'x');
            Assert.AreEqual("0.5+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point5plus_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.5+", '+', 'x');
            Assert.AreEqual("-0.5+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5plus_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5+", '+', 'x');
            Assert.AreEqual("-5+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point5plusminus0point3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.5+-0.3", '+', 'x');
            Assert.AreEqual("-0.8x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point5plusminus0point3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.5+-0.3", '+', 'x');
            Assert.AreEqual("0.2x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point5plus0point3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.5+0.3", '+', 'x');
            Assert.AreEqual("-0.2x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_6div2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("6÷2", '÷', 'x');
            Assert.AreEqual("3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_6div_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("6÷", '÷', 'x');
            Assert.AreEqual("6÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus6div_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-6÷", '÷', 'x');
            Assert.AreEqual("-6÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_6divminus2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("6÷-2", '÷', 'x');
            Assert.AreEqual("-3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus6div2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-6÷2", '÷', 'x');
            Assert.AreEqual("-3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus6divminus2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-6÷-2", '÷', 'x');
            Assert.AreEqual("3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point6div2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.6÷2", '÷', 'x');
            Assert.AreEqual("0.3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_6div0point2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("6÷0.2", '÷', 'x');
            Assert.AreEqual("30x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point6div0point2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.6÷0.2", '÷', 'x');
            Assert.AreEqual("3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point6div0point2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.6÷0.2", '÷', 'x');
            Assert.AreEqual("-3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_0point6divminus0point2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("0.6÷-0.2", '÷', 'x');
            Assert.AreEqual("-3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point6divminus0point2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.6÷-0.2", '÷', 'x');
            Assert.AreEqual("3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus0point6divminus2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-0.6÷-2", '÷', 'x');
            Assert.AreEqual("0.3x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus6divminus0point2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-6÷-0.2", '÷', 'x');
            Assert.AreEqual("30x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus6div0point2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-6÷0.2", '÷', 'x');
            Assert.AreEqual("-30x", result);
        }
        //
        [TestMethod]
        public void Calculations_for_execute_Test_2point00plus2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("2.00+2", '+', 'x');
            Assert.AreEqual("4x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_2point00minus2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("2.00-2", '-', 'x');
            Assert.AreEqual("0x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_2point00x2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("2.00x2", 'x', 'x');
            Assert.AreEqual("4x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_2point00div2_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("2.00÷2", '÷', 'x');
            Assert.AreEqual("1x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_1185point7400minus5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("1185.7400-5.0200", '-', '\0');
            Assert.AreEqual("1180.72", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_1185point7400plus5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("1185.7400+5.0200", '+', '\0');
            Assert.AreEqual("1190.76", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_1185point7400x5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("1185.7400x5.0200", 'x', '\0');
            Assert.AreEqual("5952.4148", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_1185point7400div5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("1185.7400÷5.0200", '÷', '\0');
            Assert.AreEqual("236.20318725099601593625498008", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus1185point7400minus5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-1185.7400-5.0200", '-', '\0');
            Assert.AreEqual("-1190.76", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus1185point7400plus5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-1185.7400+5.0200", '+', '\0');
            Assert.AreEqual("-1180.72", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus1185point7400x5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-1185.7400x5.0200", 'x', '\0');
            Assert.AreEqual("-5952.4148", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus1185point7400div5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-1185.7400÷5.0200", '÷', '\0');
            Assert.AreEqual("-236.20318725099601593625498008", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus1185point7400minusminus5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-1185.7400--5.0200", '-', '\0');
            Assert.AreEqual("-1180.72", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus1185point7400plusminus5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-1185.7400+-5.0200", '+', '\0');
            Assert.AreEqual("-1190.76", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus1185point7400xminus5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-1185.7400x-5.0200", 'x', '\0');
            Assert.AreEqual("5952.4148", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus1185point7400divminus5point0200_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-1185.7400÷-5.0200", '÷', '\0');
            Assert.AreEqual("236.20318725099601593625498008", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_5plus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5+3", '+', '\0');
            Assert.AreEqual("8", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_5minus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5-3", '-', '\0');
            Assert.AreEqual("2", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_5x3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5x3", 'x', '\0');
            Assert.AreEqual("15", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_5div3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5÷3", '÷', '\0');
            Assert.AreEqual("1.6666666666666666666666666667", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_minus5plus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5+3", '+', '\0');
            Assert.AreEqual("-2", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_minus5minus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5-3", '-', '\0');
            Assert.AreEqual("-8", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_minus5x3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5x3", 'x', '\0');
            Assert.AreEqual("-15", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_minus5div3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5÷3", '÷', '\0');
            Assert.AreEqual("-1.6666666666666666666666666667", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_minus5plusminus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5+-3", '+', '\0');
            Assert.AreEqual("-8", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_minus5minusminus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5--3", '-', '\0');
            Assert.AreEqual("-2", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_minus5xminus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5x-3", 'x', '\0');
            Assert.AreEqual("15", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Testequals_minus5divminus3_Click_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5÷-3", '÷', '\0');
            Assert.AreEqual("1.6666666666666666666666666667", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300plus31point0200_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300+31.0200",'+','+');
            Assert.AreEqual("36.023+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300plus31point0200_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300+31.0200", '+', '-');
            Assert.AreEqual("36.023-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300plus31point0200_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300+31.0200", '+', 'x');
            Assert.AreEqual("36.023x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300plus31point0200_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300+31.0200", '+', '÷');
            Assert.AreEqual("36.023÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300plus31point0200_equals()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300+31.0200", '+', '\0');
            Assert.AreEqual("36.023", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300minus31point0200_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300-31.0200", '-', '+');
            Assert.AreEqual("-26.017+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300minus31point0200_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300-31.0200", '-', '-');
            Assert.AreEqual("-26.017-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300minus31point0200_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300-31.0200", '-', 'x');
            Assert.AreEqual("-26.017x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300minus31point0200_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300-31.0200", '-', '÷');
            Assert.AreEqual("-26.017÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300minus31point0200_equals()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300-31.0200", '-', '\0');
            Assert.AreEqual("-26.017", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300x31point0200_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300x31.0200", 'x', '+');
            Assert.AreEqual("155.19306+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300x31point0200_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300x31.0200", 'x', '-');
            Assert.AreEqual("155.19306-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300x31point0200_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300x31.0200", 'x', 'x');
            Assert.AreEqual("155.19306x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300x31point0200_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300x31.0200", 'x', '÷');
            Assert.AreEqual("155.19306÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300x31point0200_equals()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300x31.0200", 'x', '\0');
            Assert.AreEqual("155.19306", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300div31point0200_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300÷31.0200", '÷', '+');
            Assert.AreEqual("0.1612830431979368149580915538+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300div31point0200_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300÷31.0200", '÷', '-');
            Assert.AreEqual("0.1612830431979368149580915538-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300div31point0200_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300÷31.0200", '÷', 'x');
            Assert.AreEqual("0.1612830431979368149580915538x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300div31point0200_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300÷31.0200", '÷', '÷');
            Assert.AreEqual("0.1612830431979368149580915538÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300div31point0200_equals()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300÷31.0200", '÷', '\0');
            Assert.AreEqual("0.1612830431979368149580915538", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5point00300minus31point0200_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5.00300-31.0200", '-', '-');
            Assert.AreEqual("-36.023-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5point00300minus31point0200_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5.00300-31.0200", '-', '+');
            Assert.AreEqual("-36.023+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5point00300minus31point0200_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5.00300-31.0200", '-', 'x');
            Assert.AreEqual("-36.023x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5point00300minus31point0200_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5.00300-31.0200", '-', '÷');
            Assert.AreEqual("-36.023÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5point00300minus31point0200_equals()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5.00300-31.0200", '-', '\0');
            Assert.AreEqual("-36.023", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300minuminuss31point0200_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300--31.0200", '-', '-');
            Assert.AreEqual("36.023-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300minusminus31point0200_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300--31.0200", '-', '+');
            Assert.AreEqual("36.023+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300minusminus31point0200_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300--31.0200", '-', 'x');
            Assert.AreEqual("36.023x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300minusminus31point0200_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300--31.0200", '-', '÷');
            Assert.AreEqual("36.023÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_5point00300minusminus31point0200_equals()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("5.00300--31.0200", '-', '\0');
            Assert.AreEqual("36.023", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5point00300minuminuss31point0200_minus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5.00300--31.0200", '-', '-');
            Assert.AreEqual("26.017-", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5point00300minusminus31point0200_plus()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5.00300--31.0200", '-', '+');
            Assert.AreEqual("26.017+", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5point00300minusminus31point0200_x()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5.00300--31.0200", '-', 'x');
            Assert.AreEqual("26.017x", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5point00300minusminus31point0200_div()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5.00300--31.0200", '-', '÷');
            Assert.AreEqual("26.017÷", result);
        }
        [TestMethod]
        public void Calculations_for_execute_Test_minus5point00300minusminus31point0200_equals()
        {
            var operations = new Operations();
            var result = operations.Calculations_for_Execute("-5.00300--31.0200", '-', '\0');
            Assert.AreEqual("26.017", result);
        }
    }
}