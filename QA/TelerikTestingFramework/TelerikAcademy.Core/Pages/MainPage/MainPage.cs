namespace TelerikAcademy.Core.Pages.MainPage
{
    using ArtOfTest.WebAii.Core;

    public class MainPage
    {
        private const string Url = @"http://telerikacademy.com";

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
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            this.Map.SearchBox.Text = text;
            this.Map.SearchButton.Click();
        }
    }
}
