using ArtOfTest.WebAii.Core;
namespace KendoDemos.Core.Pages
{
    public class DemosPage
    {
        private const string Url = @"http://www.telerik.com/support/demos";
        private static DemosPage instance;

        public static DemosPage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DemosPage();
                }

                return instance;
            }
        }

        public DemosPageMap Map 
        {
            get
            {
                return new DemosPageMap();
            }
        }

        public void NavigateToKendoDemos()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            this.Map.KendoDemosLink.Click();
        }
    }
}
