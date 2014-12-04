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
        public void CanSortByCarMakerAscending()
        {
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortBy(GridColumnNames.CarMaker, true);

            GridDemosPage.Instance.Validator.AssertSorting(GridColumnNames.CarMaker, true);
        }

        [TestMethod]
        public void CanSortByCarMakerDescending()
        {
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortBy(GridColumnNames.CarMaker, false);

            GridDemosPage.Instance.Validator.AssertSorting(GridColumnNames.CarMaker, false);
        }

        [TestMethod]
        public void CanSortByCarModelAscending()
        {
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortBy(GridColumnNames.CarModel, true);

            GridDemosPage.Instance.Validator.AssertSorting(GridColumnNames.CarModel, true);
        }

        [TestMethod]
        public void CanSortByCarModelDescending()
        {
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortBy(GridColumnNames.CarModel, false);

            GridDemosPage.Instance.Validator.AssertSorting(GridColumnNames.CarModel, false);
        }

        [TestMethod]
        public void CanSortByYearAscending()
        {
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortBy(GridColumnNames.Year, true);

            GridDemosPage.Instance.Validator.AssertSorting(GridColumnNames.Year, true);
        }

        [TestMethod]
        public void CanSortByYearDescending()
        {
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortBy(GridColumnNames.Year, false);

            GridDemosPage.Instance.Validator.AssertSorting(GridColumnNames.Year, false);
        }

        [TestMethod]
        public void CanSortByCategoryAscending()
        {
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortBy(GridColumnNames.Category, true);

            GridDemosPage.Instance.Validator.AssertSorting(GridColumnNames.Category, true);
        }

        [TestMethod]
        public void CanSortByCategoryDescending()
        {
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortBy(GridColumnNames.Category, false);

            GridDemosPage.Instance.Validator.AssertSorting(GridColumnNames.Category, false);
        }

        [TestMethod]
        public void CanSortByAirConditionerAscending()
        {
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortBy(GridColumnNames.AirConditioner, true);

            GridDemosPage.Instance.Validator.AssertSorting(GridColumnNames.AirConditioner, true);
        }

        [TestMethod]
        public void CanSortByAirConditionerDescending()
        {
            DemosPage.Instance.NavigateToKendoDemos();
            KendoDemosPage.Instance.NavigateToGridDemo();
            GridDemosPage.Instance.SelectInitializeFromTableDemo();
            GridDemosPage.Instance.SortBy(GridColumnNames.AirConditioner, false);

            GridDemosPage.Instance.Validator.AssertSorting(GridColumnNames.AirConditioner, false);
        }
    }
}
