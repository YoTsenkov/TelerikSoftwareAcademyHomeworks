using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllInOne
{
    public class Call
    {      
        public Call(string date, string time, string dialedPhone, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        public string Date { get; set; }

        public string Time { get; set; }

        public string DialedPhone { get; set; }

        public int Duration { get; set; }
    }
}
