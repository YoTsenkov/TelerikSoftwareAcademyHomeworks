using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllInOne
{
    class GSMTest
    {
        private const double costPerMinute = 0.37;
        static void Main()
        {
            
            //******GSM TEST******

            //testing/printing array of GSMs
            GSM[] gsmArray = new GSM[] { new GSM("Model1", "Manufacturer1"), new GSM("Model2", "Manufacturer2") };

            foreach (var device in gsmArray)
            {
                Console.WriteLine(device.ToString());
            }

            //printing Iphone4S info
            Console.WriteLine(GSM.Iphone4S);

            //******CallHistoryTest*******

            GSM gsm = new GSM();

            //adding calls
            gsm.AddCall(new Call("13.01.2013", "12:45", "0889989618", 123));
            gsm.AddCall(new Call("27.05.2014", "02:45", "0789911618", 54));

            //displaying call history info 
            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine("Call date: " + call.Date);
                Console.WriteLine("Call time: " + call.Time);
                Console.WriteLine("Dialed phone number: " + call.DialedPhone);
                Console.WriteLine("Call duration: " + call.Duration);
                Console.Write("\n");
            }

            //displaying the total price of the calls in the call history
            Console.WriteLine("The total price of the calls in the history is " + gsm.TotalPrice(costPerMinute));

            //finding the longest call
            int longestCallDuration = 0;
            int longestCallIndex = 0;

            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {                
                if (gsm.CallHistory[i].Duration > longestCallDuration)
                {
                    longestCallDuration = gsm.CallHistory[i].Duration;
                    longestCallIndex = i;
                }
            }

            //removing the longest call from the history
            gsm.DeleteCall(longestCallIndex);

            //printing the total call cost after removing the longest one
            Console.WriteLine("The total price of the calls after removing the longest one is " + gsm.TotalPrice(costPerMinute));

            //clearing and printing the call history
            gsm.ClearCallHistory();

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine("Call date: " + call.Date);
                Console.WriteLine("Call time: " + call.Time);
                Console.WriteLine("Dialed phone number: " + call.DialedPhone);
                Console.WriteLine("Call duration: " + call.Duration);
                Console.Write("\n");
            }
        }
    }
}
