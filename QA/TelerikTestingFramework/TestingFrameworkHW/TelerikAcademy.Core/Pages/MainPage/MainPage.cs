namespace TelerikAcademy.Core.Pages.MainPage
{
    using ArtOfTest.WebAii.Core;

    public class MainPage
    {
        private const string url = @"http://telerikacademy.com";

        private static MainPage instance;

        public static MainPage Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new MainPage();
                }

                return instance;
            }
        }

        public MainPageMap Map
        { 
           get
            {
                return new MainPageMap();
            }
        }

        public void SearchFor(string text)
        {
            Manager.Current.ActiveBrowser.NavigateTo(url);
            this.Map.SearchBox.Text = text;
            this.Map.SearchButton.Click();
        }
    }
}
