using System;
class  Calc_Nsum
{
    static void Main()
    {
        Console.WriteLine("Vuvedete broi chisla koito jelaete da sumirate");
        int amount = int.Parse(Console.ReadLine());
        int n;
        int sum = 0;
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine("Vuvedete n");
            n = int.Parse(Console.ReadLine());
            sum += n;
            Console.WriteLine("Sumata do momenta e -> {0}", sum);
        }
    }
}
