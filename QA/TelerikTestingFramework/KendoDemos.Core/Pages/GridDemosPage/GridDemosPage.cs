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

        public GridDemosPageValidator Validator
        {
            get
            {
                return new GridDemosPageValidator();
            }
        }        
    
        public void SortBy(GridColumnNames columnName, bool ascending)
        {
            switch (columnName)
            {
                case GridColumnNames.CarMaker:
                    this.Map.CarMakeColumn.Click();
                    break;
                case GridColumnNames.CarModel:
                    this.Map.CarModelColumn.Click();
                    break;
                case GridColumnNames.Year:
                    this.Map.YearColumn.Click();
                    break;
                case GridColumnNames.Category:
                    this.Map.CategoryColumn.Click();
                    break;
                case GridColumnNames.AirConditioner:
                    this.Map.AirConditionerColumn.Click();
                    break;
                default:
                    break;
            }

            if (!ascending)
            {
                switch (columnName)
                {
                    case GridColumnNames.CarMaker:
                        this.Map.CarMakeColumn.Click();
                        break;
                    case GridColumnNames.CarModel:
                        this.Map.CarModelColumn.Click();
                        break;
                    case GridColumnNames.Year:
                        this.Map.YearColumn.Click();
                        break;
                    case GridColumnNames.Category:
                        this.Map.CategoryColumn.Click();
                        break;
                    case GridColumnNames.AirConditioner:
                        this.Map.AirConditionerColumn.Click();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
