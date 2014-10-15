namespace KendoDemos.Core.Pages.GridDemosPage
{
    public class GridDemosPage
    {
        private static GridDemosPage instance;

        public static GridDemosPage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GridDemosPage();
                }

                return instance;
            }
        }

        public GridDemosPageMap Map
        {
            get
            {
                return new GridDemosPageMap();
            }
        }

        public void SelectInitializeFromTableDemo()
        {
            this.Map.InitializeFromTable.Click();
        }

        public void SortByCarMake(bool ascending)
        {
            this.Map.CarMakeColumn.Click();
            if (!ascending)
            {
                this.Map.CarMakeColumn.Click();
            }
        }

        public void SortByCarModel(bool ascending)
        {
            this.Map.CarModelColumn.Click();
            if (!ascending)
            {
                this.Map.CarModelColumn.Click();
            }
        }

        public void SortByYear(bool ascending)
        {
            this.Map.YearColumn.Click();
            if (!ascending)
            {
                this.Map.YearColumn.Click();
            }
        }

        public void SortByCategory(bool ascending)
        {
            this.Map.CategoryColumn.Click();
            if (!ascending)
            {
                this.Map.CategoryColumn.Click();
            }
        }

        public void SortByAirConditioner(bool ascending)
        {
            this.Map.AirConditionerColumn.Click();
            if (!ascending)
            {
                this.Map.AirConditionerColumn.Click();
            }
        }
    }
}
