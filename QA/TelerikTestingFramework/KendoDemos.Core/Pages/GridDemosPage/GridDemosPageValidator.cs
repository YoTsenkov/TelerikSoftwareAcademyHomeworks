namespace KendoDemos.Core.Pages.GridDemosPage
{
    using ArtOfTest.Common.UnitTesting;
    using System;

    public class GridDemosPageValidator
    {
        public void AssertSorting(GridColumnNames columnName, bool ascending)
        {
            string firstValue = null;
            string secondValue = null;
            int comparisonResult = 0;
            int dataRowsCount = GridDemosPage.Instance.Map.CurrentGrid.DataItems.Count;

            //if the grid is empty
            if (dataRowsCount == 0)
            {
                throw new MissingMemberException("The grid is empty and the sorting can't be checked");
            }

            //if theres only one item in the grid
            if (dataRowsCount == 1)
            {
                Assert.IsTrue(true);
                return;
            }

            for (int i = 0; i < dataRowsCount - 1; i++)
            {
                switch (columnName)
                {
                    case GridColumnNames.CarMaker:
                        firstValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[i][0].TextContent;
                        secondValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[i + 1][0].TextContent;
                        break;
                    case GridColumnNames.CarModel:
                        firstValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[i][1].TextContent;
                        secondValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[i + 1][1].TextContent;
                        break;
                    case GridColumnNames.Year:
                        firstValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[i][2].TextContent;
                        secondValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[i + 1][2].TextContent;
                        break;
                    case GridColumnNames.Category:
                        firstValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[i][3].TextContent;
                        secondValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[i + 1][3].TextContent;
                        break;
                    case GridColumnNames.AirConditioner:
                        firstValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[i][4].TextContent;
                        secondValue = GridDemosPage.Instance.Map.CurrentGrid.DataItems[i + 1][4].TextContent;
                        break;
                    default:
                        break;
                }

                comparisonResult = firstValue.CompareTo(secondValue);
                if (comparisonResult != 0)
                {
                    break;
                }

                //if all items are completely identical
                if (i == dataRowsCount - 2 && comparisonResult == 0)
                {
                    Assert.IsTrue(true);
                    return;
                }
            }                

            if (ascending)
            {
                bool areAscending = false;
                if (comparisonResult == -1)
                {
                    areAscending = true;
                }

                Assert.AreEqual(true, areAscending);
            }
            else
            {
                bool areDescending = false;
                if (comparisonResult == 1)
                {
                    areDescending = true;
                }

                Assert.AreEqual(true, areDescending);
            }
        }
    }
}
