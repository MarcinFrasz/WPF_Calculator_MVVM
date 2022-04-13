using Microsoft.VisualStudio.TestTools.UnitTesting;
using UIWPF.Commands.Functions;

namespace UIWPF.UnitTests
{
    [TestClass]
    public class FractionSquareSquareRootOperationsTests
    {
        //TESTING FRACTION
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0point00_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0.00", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0point00_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0.00", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result=op.FractionSquareSquareRoot_Functionality("5",'1');
            Assert.AreEqual("0.2",result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5", '1');
            Assert.AreEqual("-0.2", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0point5_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0.5", '1');
            Assert.AreEqual("2", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0point5_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0.5", '1');
            Assert.AreEqual("-2", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+8", '1');
            Assert.AreEqual("5+0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5-8", '1');
            Assert.AreEqual("5-0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5x8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x8", '1');
            Assert.AreEqual("5x0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5div8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷8", '1');
            Assert.AreEqual("5÷0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+8", '1');
            Assert.AreEqual("-5+0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5-8", '1');
            Assert.AreEqual("-5-0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5x8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x8", '1');
            Assert.AreEqual("-5x0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5div8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷8", '1');
            Assert.AreEqual("-5÷0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plusminus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+-8", '1');
            Assert.AreEqual("5+-0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minusminus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5--8", '1');
            Assert.AreEqual("5--0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5xminus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x-8", '1');
            Assert.AreEqual("5x-0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5divminus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷-8", '1');
            Assert.AreEqual("5÷-0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plusminus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+-8", '1');
            Assert.AreEqual("-5+-0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minusminus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5--8", '1');
            Assert.AreEqual("-5--0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5xminus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x-8", '1');
            Assert.AreEqual("-5x-0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5divminus8_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷-8", '1');
            Assert.AreEqual("-5÷-0.125", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5-0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5x0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5div0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plusminus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+-0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minusminus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5--0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5xminus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x-0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5divminus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷-0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5-0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5x0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5div0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plusminus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+-0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minusminus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5--0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5xminus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x-0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5divminus0_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷-0", '1');
            Assert.AreEqual("Cannot divide by 0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plus_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+", '1');
            Assert.AreEqual("5+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minus_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5-", '1');
            Assert.AreEqual("5-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5x_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x", '1');
            Assert.AreEqual("5x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5div_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷", '1');
            Assert.AreEqual("5÷", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plus_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+", '1');
            Assert.AreEqual("-5+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minus_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5-", '1');
            Assert.AreEqual("-5-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5x_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x", '1');
            Assert.AreEqual("-5x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5div_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷", '1');
            Assert.AreEqual("-5÷", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0plus_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0+", '1');
            Assert.AreEqual("0+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0minus_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0-", '1');
            Assert.AreEqual("0-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0x_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0x", '1');
            Assert.AreEqual("0x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0div_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0÷", '1');
            Assert.AreEqual("0÷", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0plus_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0+", '1');
            Assert.AreEqual("-0+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0minus_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0-", '1');
            Assert.AreEqual("-0-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0x_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0x", '1');
            Assert.AreEqual("-0x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0div_fraction()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0÷", '1');
            Assert.AreEqual("-0÷", result);
        }
        //TESTING squared
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0", '2');
            Assert.AreEqual("0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0", '2');
            Assert.AreEqual("0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0point00_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0.00", '2');
            Assert.AreEqual("0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0point00_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0.00", '2');
            Assert.AreEqual("0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5", '2');
            Assert.AreEqual("25", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5", '2');
            Assert.AreEqual("25", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0point5_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0.5", '2');
            Assert.AreEqual("0.25", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0point5_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0.5", '2');
            Assert.AreEqual("0.25", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+8", '2');
            Assert.AreEqual("5+64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5-8", '2');
            Assert.AreEqual("5-64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5x8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x8", '2');
            Assert.AreEqual("5x64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5div8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷8", '2');
            Assert.AreEqual("5÷64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+8", '2');
            Assert.AreEqual("-5+64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5-8", '2');
            Assert.AreEqual("-5-64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5x8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x8", '2');
            Assert.AreEqual("-5x64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5div8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷8", '2');
            Assert.AreEqual("-5÷64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plusminus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+-8", '2');
            Assert.AreEqual("5+64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minusminus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5--8", '2');
            Assert.AreEqual("5-64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5xminus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x-8", '2');
            Assert.AreEqual("5x64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5divminus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷-8", '2');
            Assert.AreEqual("5÷64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plusminus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+-8", '2');
            Assert.AreEqual("-5+64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minusminus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5--8", '2');
            Assert.AreEqual("-5-64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5xminus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x-8", '2');
            Assert.AreEqual("-5x64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5divminus8_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷-8", '2');
            Assert.AreEqual("-5÷64", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+0", '2');
            Assert.AreEqual("5+0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5-0", '2');
            Assert.AreEqual("5-0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5x0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x0", '2');
            Assert.AreEqual("5x0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5div0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷0", '2');
            Assert.AreEqual("5÷0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plusminus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+-0", '2');
            Assert.AreEqual("5+0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minusminus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5--0", '2');
            Assert.AreEqual("5-0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5xminus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x-0", '2');
            Assert.AreEqual("5x0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5divminus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷-0", '2');
            Assert.AreEqual("5÷0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+0", '2');
            Assert.AreEqual("-5+0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5-0", '2');
            Assert.AreEqual("-5-0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5x0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x0", '2');
            Assert.AreEqual("-5x0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5div0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷0", '2');
            Assert.AreEqual("-5÷0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plusminus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+-0", '2');
            Assert.AreEqual("-5+0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minusminus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5--0", '2');
            Assert.AreEqual("-5-0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5xminus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x-0", '2');
            Assert.AreEqual("-5x0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5divminus0_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷-0", '2');
            Assert.AreEqual("-5÷0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plus_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+", '2');
            Assert.AreEqual("5+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minus_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5-", '2');
            Assert.AreEqual("5-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5x_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x", '2');
            Assert.AreEqual("5x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5div_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷", '2');
            Assert.AreEqual("5÷", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plus_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+", '2');
            Assert.AreEqual("-5+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minus_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5-", '2');
            Assert.AreEqual("-5-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5x_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x", '2');
            Assert.AreEqual("-5x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5div_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷", '2');
            Assert.AreEqual("-5÷", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0plus_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0+", '2');
            Assert.AreEqual("0+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0minus_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0-", '2');
            Assert.AreEqual("0-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0x_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0x", '2');
            Assert.AreEqual("0x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0div_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0÷", '2');
            Assert.AreEqual("0÷", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0plus_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0+", '2');
            Assert.AreEqual("-0+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0minus_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0-", '2');
            Assert.AreEqual("-0-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0x_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0x", '2');
            Assert.AreEqual("-0x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0div_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0÷", '2');
            Assert.AreEqual("-0÷", result);
        }
        //TESTING squaredroot
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0", '3');
            Assert.AreEqual("0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0", '3');
            Assert.AreEqual("0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0point00_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0.00", '3');
            Assert.AreEqual("0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0point00_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0.00", '3');
            Assert.AreEqual("0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_25_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("25", '3');
            Assert.AreEqual("5", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus25_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-25", '3');
            Assert.AreEqual("Invalid input", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0point25_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0.25", '3');
            Assert.AreEqual("0.5", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0point25_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0.25", '3');
            Assert.AreEqual("Invalid input", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plus64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+64", '3');
            Assert.AreEqual("5+8", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minus64_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5-64", '3');
            Assert.AreEqual("5-8", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5x64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x64", '3');
            Assert.AreEqual("5x8", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5div64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷64", '3');
            Assert.AreEqual("5÷8", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plus64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+64", '3');
            Assert.AreEqual("-5+8", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minus64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5-64", '3');
            Assert.AreEqual("-5-8", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5x64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x64", '3');
            Assert.AreEqual("-5x8", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5div64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷64", '3');
            Assert.AreEqual("-5÷8", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plusminus64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+-64", '3');
            Assert.AreEqual("Invalid input", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minusminus64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5--64", '3');
            Assert.AreEqual("Invalid input", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5xminus64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x-64", '3');
            Assert.AreEqual("Invalid input", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5divminus64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷-64", '3');
            Assert.AreEqual("Invalid input", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plusminus64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+-64", '3');
            Assert.AreEqual("Invalid input", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minusminus64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5--64", '3');
            Assert.AreEqual("Invalid input", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5xminus64_squared()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x-64", '3');
            Assert.AreEqual("Invalid input", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5divminus64_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷-64", '3');
            Assert.AreEqual("Invalid input", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+0", '3');
            Assert.AreEqual("5+0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5-0", '3');
            Assert.AreEqual("5-0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5x0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x0", '3');
            Assert.AreEqual("5x0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5div0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷0", '3');
            Assert.AreEqual("5÷0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plusminus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+-0", '3');
            Assert.AreEqual("5+0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minusminus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5--0", '3');
            Assert.AreEqual("5-0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5xminus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x-0", '3');
            Assert.AreEqual("5x0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5divminus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷-0", '3');
            Assert.AreEqual("5÷0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+0", '3');
            Assert.AreEqual("-5+0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5-0", '3');
            Assert.AreEqual("-5-0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5x0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x0", '3');
            Assert.AreEqual("-5x0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5div0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷0", '3');
            Assert.AreEqual("-5÷0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plusminus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+-0", '3');
            Assert.AreEqual("-5+0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minusminus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5--0", '3');
            Assert.AreEqual("-5-0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5xminus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x-0", '3');
            Assert.AreEqual("-5x0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5divminus0_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷-0", '3');
            Assert.AreEqual("-5÷0", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5plus_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5+", '3');
            Assert.AreEqual("5+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5minus_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5-", '3');
            Assert.AreEqual("5-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5x_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5x", '3');
            Assert.AreEqual("5x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_5div_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("5÷", '3');
            Assert.AreEqual("5÷", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5plus_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5+", '3');
            Assert.AreEqual("-5+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5minus_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5-", '3');
            Assert.AreEqual("-5-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5x_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5x", '3');
            Assert.AreEqual("-5x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus5div_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-5÷", '3');
            Assert.AreEqual("-5÷", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0plus_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0+", '3');
            Assert.AreEqual("0+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0minus_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0-", '3');
            Assert.AreEqual("0-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0x_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0x", '3');
            Assert.AreEqual("0x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_0div_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("0÷", '3');
            Assert.AreEqual("0÷", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0plus_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0+", '3');
            Assert.AreEqual("-0+", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0minus_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0-", '3');
            Assert.AreEqual("-0-", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0x_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0x", '3');
            Assert.AreEqual("-0x", result);
        }
        [TestMethod]
        public void FractionSquareSquareRoot_Functionality_Test_minus0div_squaredroot()
        {
            FractionSquareSquareRootOperations op = new FractionSquareSquareRootOperations();
            var result = op.FractionSquareSquareRoot_Functionality("-0÷", '3');
            Assert.AreEqual("-0÷", result);
        }
    }
}
