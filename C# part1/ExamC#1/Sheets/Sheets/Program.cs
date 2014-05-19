using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int a10 = 1;
        int a9 = 2;
        int a8 = 4;
        int a7 = 8;
        int a6 = 16;
        int a5 = 32;
        int a4 = 64;
        int a3 = 128;
        int a2 = 256;
        int a1 = 512;
        int a0 = 1024;

        if (number == 0)
        {
            Console.WriteLine("A10");
            Console.WriteLine("A9");
            Console.WriteLine("A8");
            Console.WriteLine("A7");
            Console.WriteLine("A6");
        }
    }
}

