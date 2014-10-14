namespace KendoDemos.Core.Pages.KendoDemosPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core;

    public class KendoDemosPageMap : BaseElementMap
    {
        public HtmlAnchor Grid
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                    .Where(a => a.InnerText.Equals("Grid"))
                    .FirstOrDefault();
            }
        }
    }
}
