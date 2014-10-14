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
    }
}
