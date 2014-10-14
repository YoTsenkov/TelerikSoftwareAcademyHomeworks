namespace TelerikLoginHW.Website
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    internal class UserNavigationBox
    {
        [FindsBy(How = How.CssSelector, Using = "#ctl00_ctl00_siteNavigation30_functionalityControl30_liSignedIn > div:nth-child(1) > div")]
        private IWebElement openNavigation;

        public IWebElement OpenNavigation
        {
            get { return this.openNavigation; }
            set { this.openNavigation = value; }
        }

        [FindsBy(How = How.Id, Using = @"ctl00_ctl00_siteNavigation30_functionalityControl30_hlProfile")]
        private IWebElement editOptions;

        public IWebElement EditOptions
        {
            get { return this.editOptions; }
            set { this.editOptions = value; }
        }


    }
}