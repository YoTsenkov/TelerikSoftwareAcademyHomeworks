namespace Calculator.Core.Pages
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core;

    public class MainPageMap : BaseElementMap
    {
        public HtmlInputButton Clear 
        { 
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=CE");
            }
        }
        public HtmlInputButton Delete
        {

            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=←");
            }
        }

        public HtmlInputButton DivisionReminder
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=%");
            }
        }

        public HtmlInputButton Sum
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=+");
            }
        }

        public HtmlInputButton Subtract
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=-");
            }
        }

        public HtmlInputButton Multiply
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=x");
            }
        }

        public HtmlInputButton Divide
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=÷");
            }
        }

        public HtmlInputButton Equals
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value==");
            }
        }

        public HtmlInputButton Comma
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=,");
            }
        }

        public HtmlInputButton ChangeSign
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=±");
            }
        }

        public HtmlInputButton Zero
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=0");
            }
        }

        public HtmlInputButton One
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=1");
            }
        }

        public HtmlInputButton Two
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=2");
            }
        }

        public HtmlInputButton Three
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=3");
            }
        }

        public HtmlInputButton Four
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=4");
            }
        }

        public HtmlInputButton Five
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=5");
            }
        }

        public HtmlInputButton Six
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=6");
            }
        }

        public HtmlInputButton Seven
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=7");
            }
        }

        public HtmlInputButton Eight
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=8");
            }
        }

        public HtmlInputButton Nine
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputButton>("value=9");
            }
        }

        public HtmlInputText ResultBox
        {
            get
            {
                return this.Find.ById<HtmlInputText>("calc_result");
            }
        }
    }
}
