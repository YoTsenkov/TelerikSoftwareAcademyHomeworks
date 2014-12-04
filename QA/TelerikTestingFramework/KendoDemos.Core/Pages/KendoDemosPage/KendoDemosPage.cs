namespace KendoDemos.Core.Pages.KendoDemosPage
{
    public class KendoDemosPage
    {
        private static KendoDemosPage instance;

        public static KendoDemosPage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KendoDemosPage();
                }

                return instance;
            }
        }

        public KendoDemosPageMap Map
        {
            get
            {
                return new KendoDemosPageMap();
            }
        }

        public void NavigateToGridDemo()
        {
            this.Map.Grid.Click();
        }
    }
}
