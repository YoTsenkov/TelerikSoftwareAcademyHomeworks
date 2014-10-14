namespace TelerikAcademy.Core.Pages.SearchResultsPage
{
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;    
    using TestingFramework.Core;

    public class SearchResultsPageMap : BaseElementMap
    {
        public HtmlUnorderedList CoursesList
        {
            get
            {
                try
                {
                    return this.Find.AllByAttributes<HtmlDiv>("class=SearchResultsCategory")
                        .Where(d => d.InnerText.Contains("Курсове"))
                        .FirstOrDefault()
                        .Find.AllByAttributes<HtmlUnorderedList>("class=SearchMetroList")
                        .FirstOrDefault();
                }
                catch (System.Exception)
                {
                    return null;
                }                
            }
        }

        public HtmlUnorderedList TracksList
        {
            get
            {
                try
                {
                    return this.Find.AllByAttributes<HtmlDiv>("class=SearchResultsCategory")
                       .Where(d => d.InnerText.Contains("Тракове"))
                       .FirstOrDefault()
                       .Find.AllByAttributes<HtmlUnorderedList>("class=SearchMetroList")
                       .FirstOrDefault();
                }
                catch (System.Exception)
                {

                    return null;
                }               
            }
        }

        public HtmlUnorderedList UsersList
        {
            get
            {
                try
                {
                    return this.Find.AllByAttributes<HtmlDiv>("class=SearchResultsCategory")
                        .Where(d => d.InnerText.Contains("Потребители"))
                        .FirstOrDefault()
                        .Find.AllByAttributes<HtmlUnorderedList>("class=SearchMetroList")
                        .FirstOrDefault();
                }
                catch (System.Exception)
                {

                    return null;
                }               
            }
        }
    }
}
