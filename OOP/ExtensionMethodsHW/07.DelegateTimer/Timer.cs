namespace DelegateTimer
{
    using System;
    using System.Threading;
    public class Timer
    {
        public void PrintSecond(DateTime time, int interval)
        {
            Console.WriteLine("The interval between the executions is " + interval + " seconds."); 

            while (true)
            {
                Thread.Sleep(interval * 1000);
                Console.WriteLine("The interval between the executions is " + interval + " seconds."); 
            }            
        }
    }
}
