using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Internal;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;

namespace WebDriverHW
{
    [TestClass]
    public class AcademyTest
   {        
        [TestMethod]
        public void TestMethod1()
        {
            const string username = "a4103618@trbvm.com";
            const string password = "testpassword";
            const string nickname = "QA Academy";
            IWebDriver driver = new ChromeDriver(@"E:\Telerik\QA\Drivers");
            //IWebDriver driver = new FirefoxDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //login
            driver.Url = @"https://www.telerik.com/";
            driver.FindElement(By.XPath("//a[@id='hlYourAccount']")).Click();
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@id='LoginButton']")).Click();

            //navigate to profile settings
            wait.Until<IWebElement>(d =>
            {
                return d.FindElement(By.XPath("//div[@id='ctl00_ctl00_siteNavigation30_functionalityControl30_liSignedIn']/div/div/a/span"));
            }).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@id='ctl00_ctl00_siteNavigation30_functionalityControl30_hlProfile']")));
            driver.FindElement(By.XPath("//a[@id='ctl00_ctl00_siteNavigation30_functionalityControl30_hlProfile']")).Click();

            //fill in new field data
            var nickInput = wait.Until<IWebElement>(d =>
            {
                return d.FindElement(By.XPath("//input[@id='ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbNick_tbSanitized']"));
            });
            nickInput.Clear();
            nickInput.SendKeys(nickname);
            var firstNameImput = driver.FindElement(By.XPath("//input[@id='ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbFirstName_tbSanitized']"));
            firstNameImput.Clear();
            firstNameImput.SendKeys("Asya");
            var lastNameInput = driver.FindElement(By.XPath("//input[@id='ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbLastName_tbSanitized']"));
            lastNameInput.Clear();
            lastNameInput.SendKeys("Georgieva");
            driver.FindElement(By.XPath("//input[@id='ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbCompanyName_tbSanitized']"))
                .Clear();

            EditPage editPage = new EditPage();
            PageFactory.InitElements(driver, editPage);
            
            editPage.CountryArrow.Click();
            driver.FindElement(By.Id("ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_ucCountrySelector_rcbCountry_Input")).SendKeys("b");
            wait.Until<IWebElement>(d =>
                {
                    return editPage.Bg;
                }).Click();
            //editPage.Bg.Click();
            
            //update profile
            //driver.FindElement(By.Id("ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_lbUpdate")).Click();
        }       
    }
}
