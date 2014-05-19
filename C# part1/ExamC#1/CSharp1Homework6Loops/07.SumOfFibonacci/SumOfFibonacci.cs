using System;
class SumOfFibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 1;
        int first = 0;
        int second = 1;
        int current;

        for (int i = 0; i < n - 2; i++)
        {
            current = first + second;
            sum += current;
            first = second;
            second = current;            
        }
        Console.WriteLine(sum);
    }
}

