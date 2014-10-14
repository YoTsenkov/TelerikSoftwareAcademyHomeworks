using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHW
{
    public class EditPage
    {
        [FindsBy(How = How.XPath, Using = "//a[@id='ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_ucCountrySelector_rcbCountry_Arrow']")]
        private IWebElement countryArrow;
        [FindsBy(How = How.XPath, Using = "//li[text()='Bulgaria']")]
        private IWebElement bg;

        public IWebElement CountryArrow
        {
            get { return this.countryArrow; }
            set { this.countryArrow = value; }
        }
        public IWebElement Bg
        {
            get { return this.bg; }
            set { this.bg = value; }
        }
    }
}
