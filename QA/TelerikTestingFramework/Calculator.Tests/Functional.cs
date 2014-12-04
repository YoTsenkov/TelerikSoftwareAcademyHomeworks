namespace Calculator.Tests
{
    using Calculator.Core.Pages;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestingFramework.Core;

    [TestClass]
    public class Functional : BaseTest
    {
        [TestMethod]
        public void CanSum()
        {
            MainPage.Instance.ExecuteExpression("1 + 2 =")
                .AssertResultEquals(3);
        }

        [TestMethod]
        public void CanSubtract()
        {
            MainPage.Instance.ExecuteExpression("3 - 4 =")
                .AssertResultEquals(-1);
        }

        [TestMethod]
        public void CanDivide()
        {
            MainPage.Instance.ExecuteExpression("15,0 / 5 =")
                .AssertResultEquals(3);
        }

        [TestMethod]
        public void CanMultiply()
        {
            MainPage.Instance.ExecuteExpression("6 * 7 =")
                .AssertResultEquals(42);
        }

        [TestMethod]
        public void CanGetDivisionReminder()
        {
            MainPage.Instance.ExecuteExpression("9 % 8 =")
                .AssertResultEquals(1);
        }

        [TestMethod]
        public void CanChangeSign()
        {
            MainPage.Instance.ExecuteExpression("56")
                .Map.ChangeSign.Click();
            MainPage.Instance.AssertResultEquals(-56);
        }

        [TestMethod]
        public void CanDeleteLastDigit()
        {
            MainPage.Instance.ExecuteExpression("12345")
                .Map.Delete.Click();
            MainPage.Instance.AssertResultEquals(1234);
        }

        [TestMethod]
        public void CanClear()
        {
            MainPage.Instance.ExecuteExpression("5 + 6 * 2")
                .AssertResultNotEquals(0);            
            MainPage.Instance.Map.Clear.Click();
            MainPage.Instance.AssertResultEquals(0);
        }
    }
}
