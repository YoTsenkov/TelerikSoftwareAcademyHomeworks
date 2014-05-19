using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllInOne
{
    public class Battery
    {
        private string model;

        public Battery()
        {
        }
        public Battery(string model)
        {
            this.Model = model;                 
        }

        public Battery(string model, int hoursIdle)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;                   
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }

        public string Model 
        {
            get
            {
                return model;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    model = value;
                }
                else
                {
                    throw new ArgumentException("The model value of the Battery class is null or empty");
                }
            }
        }

        public int? HoursIdle { get; set; }

        public int? HoursTalk { get; set; }

        public BatteryType Type { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Battery model: " + Model + "\n");
            result.Append("Battery hours idle: " + HoursIdle + "\n");
            result.Append("Battery hours talk: " + HoursTalk + "\n");
            result.Append("Battery type: ");
            switch (Type)
            {
                case BatteryType.LiIon: result.Append("LiLon\n"); break;
                case BatteryType.NiCd: result.Append("NiCD\n"); break;
                case BatteryType.NiMH: result.Append("NiMH\n"); break;
                default: result.Append("unknown\n"); break;
            }

            return result.ToString();
        }
    }
}
