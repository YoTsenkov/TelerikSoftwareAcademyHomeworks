namespace TelerikAcademy.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikAcademy.Core.Pages.MainPage;
    using TelerikAcademy.Core.Pages.SearchResultsPage;
    using TestingFramework.Core;

    [TestClass]
    public class SearchTests : BaseTest
    {
        [TestMethod]
        public void CheckWpfResults()
        {
            MainPage.Instance.SearchFor("WPF");            
            SearchResultsPage.Instance.AssertCoursesResultsCount(2);
            SearchResultsPage.Instance.AssertTracksResultsCount(1);
        }

        [TestMethod]
        public void CheckQualityResults()
        {
            MainPage.Instance.SearchFor("Quality");
            SearchResultsPage.Instance.AssertUsersResultsCount(1);
            SearchResultsPage.Instance.AssertCoursesResultsCount(5);
            SearchResultsPage.Instance.AssertTracksResultsCount(1);
        }

        [TestMethod]
        public void CheckWebaiiResults()
        {
            MainPage.Instance.SearchFor("Webaii");
            SearchResultsPage.Instance.AssertUsersResultsCount(1);
            SearchResultsPage.Instance.AssertCoursesResultsCount(0);
            SearchResultsPage.Instance.AssertTracksResultsCount(0);
        }
    }
}
