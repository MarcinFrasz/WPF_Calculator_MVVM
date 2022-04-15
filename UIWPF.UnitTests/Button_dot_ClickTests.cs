using Microsoft.VisualStudio.TestTools.UnitTesting;
using UIWPF.Commands;
using UIWPF.ViewModels;

namespace UIWPF.UnitTests
{
    [TestClass]
    public  class Button_dot_ClickTests
    {
        [TestMethod]
        public void Dot_functionalityTest_0()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("0");
            Assert.AreEqual("0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus0()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("-0");
            Assert.AreEqual("-0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus0point()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-0.",'-');
            Assert.AreEqual("-0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("-5");
            Assert.AreEqual("-5.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result=click.Dot_functionality_default("5+");
            Assert.AreEqual("5+0.",result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("5-");
            Assert.AreEqual("5-0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("5x");
            Assert.AreEqual("5x0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("5÷");
            Assert.AreEqual("5÷0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5plus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("5+3");
            Assert.AreEqual("5+3.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5minus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("5-3");
            Assert.AreEqual("5-3.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5x3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("5x3");
            Assert.AreEqual("5x3.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5div3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("5÷3");
            Assert.AreEqual("5÷3.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5minus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("-5-3");
            Assert.AreEqual("-5-3.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5minusminus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("5--3");
            Assert.AreEqual("5--3.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5minusminus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality_default("-5--3");
            Assert.AreEqual("-5--3.", result);
        }
        //testing with . present
        [TestMethod]
        public void Dot_functionalityTest_5point0plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.0+",'+');
            Assert.AreEqual("5.0+0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5point0minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.0-",'-');
            Assert.AreEqual("5.0-0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5point0x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.0x",'x');
            Assert.AreEqual("5.0x0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5point0div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.0÷", '÷');
            Assert.AreEqual("5.0÷0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5point0plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-5.0+", '+');
            Assert.AreEqual("-5.0+0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5point0minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-5.0-", '-');
            Assert.AreEqual("-5.0-0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5point0x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-5.0x", 'x');
            Assert.AreEqual("-5.0x0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5point0div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-5.0÷", '÷');
            Assert.AreEqual("-5.0÷0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5pluspoint21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5+3.21", '+');
            Assert.AreEqual("5+3.21", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5minuspoint21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5-3.21", '-');
            Assert.AreEqual("5-3.21", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5xpoint21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5x3.21", 'x');
            Assert.AreEqual("5x3.21", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5div3point21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5÷3.21", '÷');
            Assert.AreEqual("5÷3.21", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5point5plus3point21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.5+3.21", '+');
            Assert.AreEqual("5.5+3.21", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5point5minus3point21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.5-3.21", '-');
            Assert.AreEqual("5.5-3.21", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5point5x3point21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.5x3.21", 'x');
            Assert.AreEqual("5.5x3.21", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5point5div3point21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.5÷3.21", '÷');
            Assert.AreEqual("5.5÷3.21", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5point5plus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.5+3", '+');
            Assert.AreEqual("5.5+3.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5point5minus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.5-3", '-');
            Assert.AreEqual("5.5-3.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5point5x3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.5x3", 'x');
            Assert.AreEqual("5.5x3.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5point5div3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5.5÷3", '÷');
            Assert.AreEqual("5.5÷3.", result);
        }

        [TestMethod]
        public void Dot_functionalityTest_minus5point5minus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-5.5-3", '-');
            Assert.AreEqual("-5.5-3.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5point5minusminus3()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-5.5--3", '-');
            Assert.AreEqual("-5.5--3.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5point5minus3point21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-5.5-3.21", '-');
            Assert.AreEqual("-5.5-3.21", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5point5minusminus3point21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-5.5--3.21", '-');
            Assert.AreEqual("-5.5--3.21", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5minus3point21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-5-3.21", '-');
            Assert.AreEqual("-5-3.21", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_minus5minusminus3point21()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-5--3.21", '-');
            Assert.AreEqual("-5--3.21", result);
        }
    }
}
