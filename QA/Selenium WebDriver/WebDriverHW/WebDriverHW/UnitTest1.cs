using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebDriverHW
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TelerikAcademyTest()
        {
            const string newFirstName = "ЛЕЛЕЛЕЛЕЛЕ";
            const string newLastName = "ЛАЛАЛАЛАЛАЛА";
            IWebDriver driver = new FirefoxDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Url = @"http://test.telerikacademy.com/";
            driver.FindElement(By.Id("LoginButton")).Click();
            wait.Until<IWebElement>(d =>
                {
                    return d.FindElement(By.Id("UsernameOrEmail"));
                }).SendKeys("pesho");
            driver.FindElement(By.Id("Password")).SendKeys("blabla");
            driver.FindElement(By.XPath("//input[@value='Вход']")).Click();
            wait.Until<IWebElement>(d =>
                {
                    return d.FindElement(By.XPath("//a[@id='SettingMI']"));
                }).Click();
            wait.Until<IWebElement>(d =>
                {
                    return d.FindElement(By.XPath("//input[@id='FirstName']"));
                }).Clear();
            driver.FindElement(By.XPath("//input[@id='FirstName']")).SendKeys(newFirstName);
            driver.FindElement(By.XPath("//input[@id='LastName']")).Clear();
            driver.FindElement(By.XPath("//input[@id='LastName']")).SendKeys(newLastName);
            driver.FindElement(By.XPath("//input[@value='Запази промените']")).Click();
            var actualFirstName = wait.Until<IWebElement>(d =>
                {
                    return d.FindElement(By.XPath("//input[@id='FirstName']"));
                }).GetAttribute("value");
            var actualLastName = driver.FindElement(By.XPath("//input[@id='LastName']")).GetAttribute("value");

            Assert.AreEqual(newFirstName, actualFirstName);
            Assert.AreEqual(newLastName, actualLastName);

            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().Refresh();
        }
    }
}
