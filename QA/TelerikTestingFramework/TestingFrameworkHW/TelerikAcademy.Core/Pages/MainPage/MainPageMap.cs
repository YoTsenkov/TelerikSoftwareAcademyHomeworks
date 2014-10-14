namespace TelerikAcademy.Core.Pages.MainPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core;

    public class MainPageMap : BaseElementMap
    {
        public HtmlInputText SearchBox
        {
            get
            {
                return this.Find.ById<HtmlInputText>("SearchTerm");
            }
        }

        public HtmlInputSubmit SearchButton
        { 
            get
            {
                return this.Find.ById<HtmlInputSubmit>("SearchButton");
            }
        }

    }
}
