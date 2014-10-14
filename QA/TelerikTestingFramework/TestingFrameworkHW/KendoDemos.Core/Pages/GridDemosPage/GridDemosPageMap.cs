namespace KendoDemos.Core.Pages.GridDemosPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core;
    using Telerik.TestingFramework.Controls.KendoUI;

    public class GridDemosPageMap : BaseElementMap
    {
        public HtmlAnchor InitializeFromTable
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                    .Where(a => a.InnerText.Equals("Initialization from table"))
                    .FirstOrDefault();
            }
        }

        public KendoGrid GridFromTable
        {
            get
            {
                return this.Find.ById<KendoGrid>("grid");
            }
        }
    }
}
