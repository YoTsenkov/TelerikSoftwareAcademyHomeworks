namespace KendoDemos.Tests
{
    using ArtOfTest.WebAii.Core;
    using KendoDemos.Core.Pages;
    using KendoDemos.Core.Pages.GridDemosPage;
    using KendoDemos.Core.Pages.KendoDemosPage;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestingFramework.Core;

    [TestClass]
    public class KendoGridTests : BaseTest
    {
        [TestMethod]
        public void CanNavigateToKendoDemos()
        {
            const string TargetUrl = @"http://demos.telerik.com/kendo-ui/";

            DemosPage.Instance.NavigateToKendoDemos();

            Assert.AreEqual(TargetUrl, Manager.Current.ActiveBrowser.Url);           
        }

        [TestMethod]
        public void VerifyGridFromTableRowsAndColumnsCount()
        {
            const int ExpectedGridRows = 20;
            const int ExpectedGridColumns = 5;

            DemosPage.Instance.NavigateToKendoDemos();

            KendoDemosPage.Instance.NavigateToGridDemo();

            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            var grid = GridDemosPage.Instance.Map.GridFromTable;
            var actualGridRows = grid.DataItems.Count - 1;
            var actualGridColumns = grid.DataItems[0].Cells.Count;

            Assert.AreEqual(true, grid.IsVisible());
            Assert.AreEqual(ExpectedGridRows, actualGridRows);
            Assert.AreEqual(ExpectedGridColumns, actualGridColumns);
        }
    }
}
