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

        public KendoGrid CurrentGrid
        {
            get
            {
                return this.Find.ById<KendoGrid>("grid");
            }
        }

        public HtmlAnchor CarMakeColumn
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                    .Where(a => a.InnerText.Equals("Car Make"))                    
                    .FirstOrDefault();
            }
        }

        public HtmlAnchor CarModelColumn
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                    .Where(a => a.InnerText.Equals("Car Model"))
                    .FirstOrDefault();
            }
        }

        public HtmlAnchor YearColumn
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                    .Where(a => a.InnerText.Equals("Year"))
                    .FirstOrDefault();
            }
        }

        public HtmlAnchor CategoryColumn
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                    .Where(a => a.InnerText.Equals("Category"))
                    .FirstOrDefault();
            }
        }

        public HtmlAnchor AirConditionerColumn
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                    .Where(a => a.InnerText.Equals("Air Conditioner"))
                    .FirstOrDefault();
            }
        }
    }
}
