namespace TelerikLoginHW.Website
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    internal class MainPage
    {
        [FindsBy(How = How.Id, Using = "hlYourAccount")]
        private IWebElement loginLink;

        public IWebElement LoginLink
        {
            get { return this.loginLink; }
            set { this.loginLink = value; }
        }

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement emailField;

        public IWebElement EmailFiled
        {
            get { return this.emailField; }
            set { this.emailField = value; }
        }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;

        public IWebElement Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        [FindsBy(How = How.Id, Using = "LoginButton")]
        private IWebElement loginButton;

        public IWebElement LoginButton
        {
            get { return this.loginButton; }
            set { this.loginButton = value; }
        }

        public void DefaultLogin(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl(@"http://www.telerik.com/");
            driver.Navigate().Refresh();

            this.LoginLink.Click();

            this.EmailFiled.Clear();
            this.EmailFiled.SendKeys("a4130403@trbvm.com");

            this.Password.Clear();
            this.password.SendKeys("12345");

            this.loginButton.Click();
        }
    }
}