namespace KendoDemos.Core.Pages
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core;

    public class DemosPageMap : BaseElementMap
    {
        public HtmlAnchor KendoDemosLink
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                    .Where(a => a.InnerText.Contains("Launch Kendo UI demos"))
                    .FirstOrDefault();
            }
        }
    }
}
