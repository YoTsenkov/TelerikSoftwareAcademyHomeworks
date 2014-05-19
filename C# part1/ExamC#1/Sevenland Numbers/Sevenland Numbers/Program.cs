using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine("1");
        }
        else
        {


            int digitNumber = (int)Math.Log10(number) + 1;

            if (digitNumber == 1)
            {
                if (number < 6)
                {
                    Console.WriteLine(number + 1);
                }
                else
                {
                    Console.WriteLine(number + 4);
                }
            }
            else if (digitNumber == 2)
            {
                if (number % 10 == 6 && (number / 10) % 10 == 6)
                {
                    Console.WriteLine(number + 34);
                }
                else if (number % 10 == 6)
                {
                    Console.WriteLine(number + 4);
                }
                else
                {
                    Console.WriteLine(number + 1);
                }
            }
            else if (digitNumber == 3)
            {
                if (number == 666)
                {
                    Console.WriteLine(number + 334);
                }
                else if ((number / 10) % 10 == 6 && number % 10 == 6)
                {
                    Console.WriteLine(number + 34);
                }
                else if (number % 10 == 6)
                {
                    Console.WriteLine(number + 4);
                }
                else
                {
                    Console.WriteLine(number + 1);
                }


            }
        }
    }
}

