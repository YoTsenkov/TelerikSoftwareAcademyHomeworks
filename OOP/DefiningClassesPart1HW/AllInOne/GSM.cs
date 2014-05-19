using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllInOne
{
    public class GSM
    {

        private string model;
        private string manufacturer;
        private string owner;
        private List<Call> callHistory = new List<Call>();

        public static GSM Iphone4S = new GSM("Iphone4S", "Apple", 1275, "Ivan Ivanov", new Battery("BatteryModel", 48, 5, BatteryType.NiCd), new Display(4.8, 1300000));



        public GSM()
        {
        }
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, double price, string owner, Battery batteryInfo, Display displayInfo)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Price = price;
            this.Owner = owner;
            this.BatteryInfo = batteryInfo;
            this.DisplayInfo = displayInfo;
        }

        public double Price { get; private set; }

        public Battery BatteryInfo { get; set; }

        public Display DisplayInfo { get; set; }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }


        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException("Invalid owner input format.");
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("Invalid manufacturer.");
                }
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("Invalid model.");
                }
            }
        }

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }
        public void DeleteCall(int callIndex)
        {
            if (callIndex >= 0 && callIndex < CallHistory.Count)
            {
                CallHistory.RemoveAt(callIndex);
            }
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public double TotalPrice(double pricePerMinute)
        {
            long sumOfCallsDuration = 0;
            double totalPrice = 0;
            double pricePerSecond = pricePerMinute / 60;

            foreach (var call in CallHistory)
            {
                sumOfCallsDuration += call.Duration;
            }

            totalPrice = sumOfCallsDuration * pricePerSecond;

            return totalPrice;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("GSM model: " + Model + "\n");
            sb.Append("GSM manufacturer: " + Manufacturer + "\n");
            sb.Append("GSM price: " + Price + "\n");
            sb.Append("GSM owner: " + Owner + "\n");
            if (BatteryInfo != null)
            {
                sb.Append(BatteryInfo.ToString());
            }
            if (DisplayInfo != null)
            {
                sb.Append(DisplayInfo.ToString());
            }

            return sb.ToString();
        }
    }
}
