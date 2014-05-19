using System;
class Exchange_Many_Bits
{
    static void Main()
    {
        int number = 6857803;
        Console.WriteLine(Convert.ToString(number, 2));
        Console.WriteLine("Vuvedete p");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Vuvedete q");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Vuvedete k");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            int pos = number >> p;
            int bit = pos & 1;
            int posOne = number >> q;
            int bitOne = posOne & 1;

            int maskNew1 = ~(1 << q);
            int maskNew2 = (1 << q);
            int maskNew = bit == 0 ? maskNew1 : maskNew2;
            int result1 = number & maskNew;
            int result2 = number | maskNew;
            number = bit == 0 ? result1 : result2;
            Console.WriteLine(Convert.ToString(number, 2));

            maskNew1 = ~(1 << p);
            maskNew2 = (1 << p);
            maskNew = bitOne == 0 ? maskNew1 : maskNew2;
            result1 = number & maskNew;
            result2 = number | maskNew;
            number = bitOne == 0 ? result1 : result2;
            Console.WriteLine(Convert.ToString(number, 2));

            p++;
            q++;
        }
    }
}

