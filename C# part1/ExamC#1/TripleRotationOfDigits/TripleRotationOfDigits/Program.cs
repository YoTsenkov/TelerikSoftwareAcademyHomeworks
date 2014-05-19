using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int digitNumber = (int)(Math.Log10(number) + 1);
        for (int i = 0; i < 3; i++)
        {
            int lastDigit = number % 10;
            number -= lastDigit;
            number /= 10;
            if (lastDigit == 0)
            {
                digitNumber -= 1;
            }
            else
            {
                number += (int)(lastDigit * Math.Pow(10, digitNumber - 1));
            }        
        }
        Console.WriteLine(number);
    }
}

