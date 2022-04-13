using Microsoft.VisualStudio.TestTools.UnitTesting;
using UIWPF.Commands;
using UIWPF.ViewModels;

namespace UIWPF.UnitTests
{
    [TestClass]
    public class Button_clear_ClickTests
    {
        [TestMethod]
        public void Clear_functionality_Test_3plus56()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click clear = new Button_clear_Click(model);
            var result=clear.Clear_functionality("3+56");
            Assert.AreEqual("3+5",result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3plus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3+5");
            Assert.AreEqual("3+", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3+");
            Assert.AreEqual("3+", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3+");
            Assert.AreEqual("-3+", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3plus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3+5");
            Assert.AreEqual("-3+", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3plusminus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3+-5");
            Assert.AreEqual("3+", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3plusminus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3+-5");
            Assert.AreEqual("-3+", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3plus5point6()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click clear = new Button_clear_Click(model);
            var result = clear.Clear_functionality("0.3+5.6");
            Assert.AreEqual("0.3+5.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3plus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3+5");
            Assert.AreEqual("0.3+", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3+");
            Assert.AreEqual("0.3+", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3plus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3+");
            Assert.AreEqual("-0.3+", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3plus0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3+0.5");
            Assert.AreEqual("-0.3+0.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3plusminus0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3+-0.5");
            Assert.AreEqual("0.3+-0.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3plusminus0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3+-0.5");
            Assert.AreEqual("-0.3+-0.", result);
        }
        // TESTS FOR -
        [TestMethod]
        public void Clear_functionality_Test_3minus56()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click clear = new Button_clear_Click(model);
            var result = clear.Clear_functionality("3-56");
            Assert.AreEqual("3-5", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3minus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3-5");
            Assert.AreEqual("3-", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3-");
            Assert.AreEqual("3-", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3-");
            Assert.AreEqual("-3-", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3minus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3-5");
            Assert.AreEqual("-3-", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3minusminus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3--5");
            Assert.AreEqual("3-", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3minusminus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3--5");
            Assert.AreEqual("-3-", result);
        }
                [TestMethod]
        public void Clear_functionality_Test_0point3minus5point6()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click clear = new Button_clear_Click(model);
            var result = clear.Clear_functionality("0.3-5.6");
            Assert.AreEqual("0.3-5.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3minus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3-5");
            Assert.AreEqual("0.3-", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3-");
            Assert.AreEqual("0.3-", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3minus()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3-");
            Assert.AreEqual("-0.3-", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3minus0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3-0.5");
            Assert.AreEqual("-0.3-0.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3minusminus0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3--0.5");
            Assert.AreEqual("0.3--0.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3minusminus0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3--0.5");
            Assert.AreEqual("-0.3--0.", result);
        }
        // TEST for x
        [TestMethod]
        public void Clear_functionality_Test_3x56()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click clear = new Button_clear_Click(model);
            var result = clear.Clear_functionality("3x56");
            Assert.AreEqual("3x5", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3x5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3x5");
            Assert.AreEqual("3x", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3x");
            Assert.AreEqual("3x", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3x");
            Assert.AreEqual("-3x", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3x5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3x5");
            Assert.AreEqual("-3x", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3xminus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3x-5");
            Assert.AreEqual("3x", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3xminus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3x-5");
            Assert.AreEqual("-3x", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3x5point6()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click clear = new Button_clear_Click(model);
            var result = clear.Clear_functionality("0.3x5.6");
            Assert.AreEqual("0.3x5.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3x5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3x5");
            Assert.AreEqual("0.3x", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3x");
            Assert.AreEqual("0.3x", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3x()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3x");
            Assert.AreEqual("-0.3x", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3x0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3x0.5");
            Assert.AreEqual("-0.3x0.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3xminus0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3x-0.5");
            Assert.AreEqual("0.3x-0.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3xminus0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3x-0.5");
            Assert.AreEqual("-0.3x-0.", result);
        }
        //TEST for div
        [TestMethod]
        public void Clear_functionality_Test_3div56()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click clear = new Button_clear_Click(model);
            var result = clear.Clear_functionality("3÷56");
            Assert.AreEqual("3÷5", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3div5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3÷5");
            Assert.AreEqual("3÷", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3÷");
            Assert.AreEqual("3÷", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3÷");
            Assert.AreEqual("-3÷", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3div5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3÷5");
            Assert.AreEqual("-3÷", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_3divminus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("3÷-5");
            Assert.AreEqual("3÷", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus3divminus5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-3÷-5");
            Assert.AreEqual("-3÷", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3div5point6()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click clear = new Button_clear_Click(model);
            var result = clear.Clear_functionality("0.3÷5.6");
            Assert.AreEqual("0.3÷5.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3div5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3÷5");
            Assert.AreEqual("0.3÷", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3÷");
            Assert.AreEqual("0.3÷", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3div()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3÷");
            Assert.AreEqual("-0.3÷", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3div0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3÷0.5");
            Assert.AreEqual("-0.3÷0.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_0point3divminus0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("0.3÷-0.5");
            Assert.AreEqual("0.3÷-0.", result);
        }
        [TestMethod]
        public void Clear_functionality_Test_minus0point3divminus0point5()
        {
            CalculatorViewModel model = new CalculatorViewModel();
            Button_clear_Click t = new Button_clear_Click(model);
            var result = t.Clear_functionality("-0.3÷-0.5");
            Assert.AreEqual("-0.3÷-0.", result);
        }
    }
}
