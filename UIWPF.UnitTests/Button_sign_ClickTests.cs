using Microsoft.VisualStudio.TestTools.UnitTesting;
using UIWPF.Commands;
using UIWPF.ViewModels;

namespace UIWPF.UnitTests
{
    [TestClass]
    public class Button_sign_ClickTests
    {
        [TestMethod]
        public void Button_sign_Click_5minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5-", '-');
            Assert.AreEqual("5-", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5-", '-');
            Assert.AreEqual("0.5-", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5-", '-');
            Assert.AreEqual("-0.5-", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5", '-');
            Assert.AreEqual("0.5", result);
        }

        [TestMethod]
        public void Button_sign_Click_minus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5", '-');
            Assert.AreEqual("5", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result=sign.Set_sign("-5-",'-');
            Assert.AreEqual("-5-",result);
        }
        [TestMethod]
        public void Button_sign_Click_5plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5+", '+');
            Assert.AreEqual("5+", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5+", '+');
            Assert.AreEqual("0.5+", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5+", '+');
            Assert.AreEqual("-0.5+", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5+", '+');
            Assert.AreEqual("-5+", result);
        }
        [TestMethod]
        public void Button_sign_Click_5x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5x", 'x');
            Assert.AreEqual("5x", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5x", 'x');
            Assert.AreEqual("0.5x", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5x", 'x');
            Assert.AreEqual("-0.5x", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5x", 'x');
            Assert.AreEqual("-5x", result);
        }
        [TestMethod]
        public void Button_sign_Click_5div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5÷", '÷');
            Assert.AreEqual("5÷", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5÷", '÷');
            Assert.AreEqual("0.5÷", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5÷", '÷');
            Assert.AreEqual("-0.5÷", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5÷", '÷');
            Assert.AreEqual("-5÷", result);
        }
        [TestMethod]
        public void Button_sign_Click_5plus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5+3", '+');
            Assert.AreEqual("5+-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5plus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5+3", '+');
            Assert.AreEqual("-5+-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5plusminus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5+-3", '+');
            Assert.AreEqual("-5+3", result);
        }
        [TestMethod]
        public void Button_sign_Click_5minus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5-3", '-');
            Assert.AreEqual("5--3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5minus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5-3", '-');
            Assert.AreEqual("-5--3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5minusminus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5--3", '-');
            Assert.AreEqual("-5-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_5x3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5x3", 'x');
            Assert.AreEqual("5x-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5x3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5x3", 'x');
            Assert.AreEqual("-5x-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5xminus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5x-3", 'x');
            Assert.AreEqual("-5x3", result);
        }
        [TestMethod]
        public void Button_sign_Click_5div3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5÷3", '÷');
            Assert.AreEqual("5÷-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5div3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5÷3", '÷');
            Assert.AreEqual("-5÷-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5divminus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5÷-3", '÷');
            Assert.AreEqual("-5÷3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5plus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5+3", '+');
            Assert.AreEqual("0.5+-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5minus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5-3", '-');
            Assert.AreEqual("0.5--3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5x3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5x3", 'x');
            Assert.AreEqual("0.5x-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5div3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5÷3", '÷');
            Assert.AreEqual("0.5÷-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5plus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5+3", '+');
            Assert.AreEqual("-0.5+-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5minus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5-3", '-');
            Assert.AreEqual("-0.5--3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5x3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5x3", 'x');
            Assert.AreEqual("-0.5x-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5div3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5÷3", '÷');
            Assert.AreEqual("-0.5÷-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5plusminus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5+-3", '+');
            Assert.AreEqual("-0.5+3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5minusminus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5--3", '-');
            Assert.AreEqual("-0.5-3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5xminus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5x-3", 'x');
            Assert.AreEqual("-0.5x3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5divminus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5÷-3", '÷');
            Assert.AreEqual("-0.5÷3", result);
        }
        [TestMethod]
        public void Button_sign_Click_5plus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5+0.3", '+');
            Assert.AreEqual("5+-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_5minus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5-0.3", '-');
            Assert.AreEqual("5--0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_5x0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5x0.3", 'x');
            Assert.AreEqual("5x-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_5div0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5÷0.3", '÷');
            Assert.AreEqual("5÷-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5plus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5+0.3", '+');
            Assert.AreEqual("-5+-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5minus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5-0.3", '-');
            Assert.AreEqual("-5--0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5x0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5x0.3", 'x');
            Assert.AreEqual("-5x-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5div0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5÷0.3", '÷');
            Assert.AreEqual("-5÷-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_5plusminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5+-0.3", '+');
            Assert.AreEqual("5+0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_5minusminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5--0.3", '-');
            Assert.AreEqual("5-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_5xminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5x-0.3", 'x');
            Assert.AreEqual("5x0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_5divminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("5÷-0.3", '÷');
            Assert.AreEqual("5÷0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5plusminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5+-0.3", '+');
            Assert.AreEqual("-5+0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5minusminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5--0.3", '-');
            Assert.AreEqual("-5-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5xminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5x-0.3", 'x');
            Assert.AreEqual("-5x0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus5divminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-5÷-0.3", '÷');
            Assert.AreEqual("-5÷0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5plus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5+0.3", '+');
            Assert.AreEqual("0.5+-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5minus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5-0.3", '-');
            Assert.AreEqual("0.5--0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5x0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5x0.3", 'x');
            Assert.AreEqual("0.5x-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5div0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5÷0.3", '÷');
            Assert.AreEqual("0.5÷-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5plus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5+0.3", '+');
            Assert.AreEqual("-0.5+-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5minus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5-0.3", '-');
            Assert.AreEqual("-0.5--0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5x0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5x0.3", 'x');
            Assert.AreEqual("-0.5x-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5div0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5÷0.3", '÷');
            Assert.AreEqual("-0.5÷-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5plusminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5+-0.3", '+');
            Assert.AreEqual("0.5+0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5minusminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5--0.3", '-');
            Assert.AreEqual("0.5-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5xminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5x-0.3", 'x');
            Assert.AreEqual("0.5x0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_0point5divminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("0.5÷-0.3", '÷');
            Assert.AreEqual("0.5÷0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5plusminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5+-0.3", '+');
            Assert.AreEqual("-0.5+0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5minusminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5--0.3", '-');
            Assert.AreEqual("-0.5-0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5xminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5x-0.3", 'x');
            Assert.AreEqual("-0.5x0.3", result);
        }
        [TestMethod]
        public void Button_sign_Click_minus0point5divminus0point3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_sign_Click sign = new Button_sign_Click(model);
            var result = sign.Set_sign("-0.5÷-0.3", '÷');
            Assert.AreEqual("-0.5÷0.3", result);
        }
    }
}
