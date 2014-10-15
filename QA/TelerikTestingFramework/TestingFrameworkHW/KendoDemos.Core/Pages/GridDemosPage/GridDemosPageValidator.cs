namespace KendoDemos.Core.Pages.GridDemosPage
{
    using ArtOfTest.Common.UnitTesting;

    public class GridDemosPageValidator
    {
        public void AssertSorting(GridColumnNames columnName, bool ascending)
        {
            string firstValue = null;
            string secondValue = null;
            switch (columnName)
            {
                case GridColumnNames.CarMaker:
                    firstValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][0].TextContent;
                    secondValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[1][0].TextContent;
                    break;
                case GridColumnNames.CarModel:
                    firstValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][1].TextContent;
                    secondValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[1][1].TextContent;
                    break;
                case GridColumnNames.Year:
                    firstValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][2].TextContent;
                    secondValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[1][2].TextContent;
                    break;
                case GridColumnNames.Category:
                    firstValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][3].TextContent;
                    secondValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[1][3].TextContent;
                    break;
                case GridColumnNames.AirConditioner:
                    firstValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[0][0].TextContent;
                    secondValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[1][0].TextContent;
                    break;
                default:
                    break;
            }

            int comparisonResult = firstValue.CompareTo(secondValue);            

            if (ascending)
            {
                bool areAscending = false;
                if (comparisonResult == -1 || comparisonResult == 0)
                {
                    areAscending = true;
                }

                Assert.AreEqual(true, areAscending);
            }
            else
            {
                bool areDescending = false;
                if (comparisonResult == 1 || comparisonResult == 0)
                {
                    areDescending = true;
                }

                Assert.AreEqual(true, areDescending);
            }
        }
    }
}
