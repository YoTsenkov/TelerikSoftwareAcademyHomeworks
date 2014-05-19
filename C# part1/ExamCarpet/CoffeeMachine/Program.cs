using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n1 = int.Parse(input);
        input = Console.ReadLine();
        int n2 = int.Parse(input);
        input = Console.ReadLine();
        int n3 = int.Parse(input);
        input = Console.ReadLine();
        int n4 = int.Parse(input);
        input = Console.ReadLine();
        int n5 = int.Parse(input);
        input = Console.ReadLine();
        float inputMoney = float.Parse(input);
        input = Console.ReadLine();
        float price = float.Parse(input);
        float availableMoney = n1 * 0.05f + n2 * 0.10f + n3 * 0.20f + n4 * 0.50f + n5;
        if (inputMoney == price)
        {
            Console.WriteLine("Yes {0:f2}", availableMoney);
        }
        else if (inputMoney > price)
        {
            if (inputMoney - price <= availableMoney)
            {
                Console.WriteLine("Yes {0:f2}", availableMoney - (inputMoney - price));
            }
            else
            {
                Console.WriteLine("No {0:f2}", (inputMoney - price) - availableMoney);
            }
        }
        else if (inputMoney < price)
        {
            Console.WriteLine("More {0:f2}", price - inputMoney);
        }
    }
}

