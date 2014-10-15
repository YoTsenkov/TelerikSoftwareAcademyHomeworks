namespace KendoDemos.Tests
{
    using ArtOfTest.WebAii.Core;
    using KendoDemos.Core.Pages;
    using KendoDemos.Core.Pages.GridDemosPage;
    using KendoDemos.Core.Pages.KendoDemosPage;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Telerik.TestingFramework.Controls.KendoUI;
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
            const int ExpectedGridRows = 21;
            const int ExpectedGridColumns = 5;

            DemosPage.Instance.NavigateToKendoDemos();

            KendoDemosPage.Instance.NavigateToGridDemo();

            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            var grid = GridDemosPage.Instance.Map.CurrentGrid;
            var actualGridRows = grid.DataItems.Count;
            var actualGridColumns = grid.DataItems[0].Cells.Count;

            Assert.AreEqual(true, grid.IsVisible());
            Assert.AreEqual(ExpectedGridRows, actualGridRows);
            Assert.AreEqual(ExpectedGridColumns, actualGridColumns);
        }

        [TestMethod]
        public void CanSortByCarMakeAscending()
        {
            const string ExpectedCarMaker = "Alfa Romeo";
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortByCarMake(true);
            var firstCarMaker = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][0].TextContent;

            Assert.AreEqual(ExpectedCarMaker, firstCarMaker);

        }

        [TestMethod]
        public void CanSortByCarMakeDescending()
        {
            const string ExpectedCarMaker = "VW";
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortByCarMake(false);
            var firstCarMaker = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][0].TextContent;

            Assert.AreEqual(ExpectedCarMaker, firstCarMaker);
        }

        [TestMethod]
        public void CanSortByCarModelAscending()
        {
            const string ExpectedCarModel = "159";
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortByCarModel(true);
            var firstCarModel = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][1].TextContent;

            Assert.AreEqual(ExpectedCarModel, firstCarModel);
        }

        [TestMethod]
        public void CanSortByCarModelDescending()
        {
            const string ExpectedCarModel = "Ypsilon";
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortByCarModel(false);
            var firstCarModel = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][1].TextContent;

            Assert.AreEqual(ExpectedCarModel, firstCarModel);
        }

        [TestMethod]
        public void CanSortByYearAscending()
        {
            const string ExpectedYear = "2001";
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortByYear(true);
            var firstYear = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][2].TextContent;

            Assert.AreEqual(ExpectedYear, firstYear);
        }

        [TestMethod]
        public void CanSortByYearDescending()
        {
            const string ExpectedYear = "2013";
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortByYear(false);
            var firstYear = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][2].TextContent;

            Assert.AreEqual(ExpectedYear, firstYear);
        }

        [TestMethod]
        public void CanSortByCategoryAscending()
        {
            const string ExpectedCategory = "Hatchback";
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortByCategory(true);
            var firstCategory = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][3].TextContent;

            Assert.AreEqual(ExpectedCategory, firstCategory);
        }

        [TestMethod]
        public void CanSortByCategoryDescending()
        {
            const string ExpectedCategory = "SUV";
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortByCategory(false);
            var firstCategory = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][3].TextContent;

            Assert.AreEqual(ExpectedCategory, firstCategory);
        }

        [TestMethod]
        public void CanSortByAirConditionerAscending()
        {
            const string ExpectedAirConditioner = "No";
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortByAirConditioner(true);
            var firstAirConditioner = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][4].TextContent;

            Assert.AreEqual(ExpectedAirConditioner, firstAirConditioner);
        }

        [TestMethod]
        public void CanSortByAirConditionerDescending()
        {
            const string ExpectedAirConditioner = "Yes";
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortByAirConditioner(false);
            var firstAirConditioner = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][4].TextContent;

            Assert.AreEqual(ExpectedAirConditioner, firstAirConditioner);
        }
    }
}
