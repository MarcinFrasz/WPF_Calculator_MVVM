using Microsoft.VisualStudio.TestTools.UnitTesting;
using UIWPF.Commands;
using UIWPF.ViewModels;

namespace UIWPF.UnitTests
{
    [TestClass]
    public  class Button_dot_ClickTests
    {
        [TestMethod]
        public void Dot_functionalityTest_minus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("-5", '-');
            Assert.AreEqual("-5.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result=click.Dot_functionality("5+",'+');
            Assert.AreEqual("5+0.",result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5-", '-');
            Assert.AreEqual("5-0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5x", 'x');
            Assert.AreEqual("5x0.", result);
        }
        [TestMethod]
        public void Dot_functionalityTest_5div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_dot_Click click = new Button_dot_Click(model);
            var result = click.Dot_functionality("5÷", '÷');
            Assert.AreEqual("5÷0.", result);
        }
    }
}
