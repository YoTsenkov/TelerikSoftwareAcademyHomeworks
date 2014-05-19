using System;
using System.Collections.Generic;
class ReverseDigits
{
    static void Reverse(string number)
    {
        List<int> list = new List<int>();
        int buff;
        foreach (char item in number)
        {
            list.Add(item - 48);
        }
        for (int i = number.Length - 1; i >= number.Length / 2; i--)
        {
            buff = list[i];
            list[i] = list[number.Length - 1 - i];
            list[number.Length - 1 - i] = buff;
        }
        foreach (var item in list)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Enter the number you want to reverse.");
        Reverse(Console.ReadLine());
    }
}

