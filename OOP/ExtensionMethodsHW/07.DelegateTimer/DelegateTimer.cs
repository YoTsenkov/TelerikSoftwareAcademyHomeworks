namespace DelegateTimer
{
    using System;
    public class DelegateTimer
    {
      
        static void Main()
        {
            Timer timer = new Timer();

            Console.WriteLine("Enter the interval between the executions of the method.");

            int interval = int.Parse(Console.ReadLine());

            Action<DateTime, int> action = timer.PrintSecond;

            action(DateTime.Now, interval);
        }
    }
}
