using System;
class Program
{
    static void Main()
    {
        int number;
        int subset = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("vuvedete chislo");
            number = int.Parse(Console.ReadLine());
            subset += number;
            if (subset == 0)
            {
                Console.WriteLine("ima pone edin subset = 0");
                break;
            }
        }
    }
}

