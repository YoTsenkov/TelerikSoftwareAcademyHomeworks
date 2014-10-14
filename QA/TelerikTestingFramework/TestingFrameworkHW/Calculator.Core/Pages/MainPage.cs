namespace Calculator.Core.Pages
{
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public class MainPage
    {
        private const string Url = @"http://www.webestools.com/ftp/ybouane/scripts_tutorials/javascript/calculator/calculator.html";
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

        public HtmlInputText ResultBox
        {
            get
            {
                return this.Map.ResultBox;
            }
        }

        public MainPage ExecuteExpression(string expression)
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            var inputs = expression.Split(' ');
            foreach (var input in inputs)
            {
                this.ExecuteInput(input);
            }

            return instance;
        }

        public void AssertResultEquals(decimal expected)
        {
            Assert.AreEqual(expected, int.Parse(this.Map.ResultBox.Text));
        }

        public void AssertResultNotEquals(decimal expected)
        {
            Assert.AreNotEqual(expected, int.Parse(this.Map.ResultBox.Text));
        }

        private void ExecuteInput(string input)
        {            
            decimal number;
            if (decimal.TryParse(input, out number))
            {
                foreach (var digit in input)
                {
                    switch (digit)
                    {
                        case '0': this.Map.Zero.Click();
                            break;
                        case '1': this.Map.One.Click();
                            break;
                        case '2': this.Map.Two.Click();
                            break;
                        case '3': this.Map.Three.Click();
                            break;
                        case '4': this.Map.Four.Click();
                            break;
                        case '5': this.Map.Five.Click();
                            break;
                        case '6': this.Map.Six.Click();
                            break;
                        case '7': this.Map.Seven.Click();
                            break;
                        case '8': this.Map.Eight.Click();
                            break;
                        case '9': this.Map.Nine.Click();
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                switch (input)
                {
                    case "%": this.Map.DivisionReminder.Click();
                        break;
                    case "+": this.Map.Sum.Click();
                        break;
                    case "-": this.Map.Subtract.Click();
                        break;
                    case "*": this.Map.Multiply.Click();
                        break;
                    case "/": this.Map.Divide.Click();
                        break;
                    case "=": this.Map.Calculate.Click();
                        break;
                    case ",": this.Map.Comma.Click();
                        break;
                    default:
                        break;
                }
            }            
        }
    }
}
