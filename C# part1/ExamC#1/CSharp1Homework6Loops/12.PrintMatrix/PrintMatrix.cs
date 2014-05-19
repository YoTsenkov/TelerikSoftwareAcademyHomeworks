using System;
class PrintMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int add = 1;
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + add);
            }
            add++;
            Console.WriteLine();
        }
    }
}

