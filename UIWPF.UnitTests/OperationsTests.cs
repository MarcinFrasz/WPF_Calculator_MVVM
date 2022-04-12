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
    }
}