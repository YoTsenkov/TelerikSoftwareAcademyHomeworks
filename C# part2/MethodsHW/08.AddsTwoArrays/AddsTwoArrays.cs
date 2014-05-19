using System;
using System.Collections.Generic;
class AddsTwoArrays
{
    static List<int> finalList = new List<int>();
    static List<int> Reverse(string number)
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
        return finalList = list;
    }
    static void Main()
    {
        Console.WriteLine("Enter first number.");
        string firstNumber = Console.ReadLine();
        Console.WriteLine("Enter second number.");
        string secondNumber = Console.ReadLine();

        List<int> listOne = Reverse(firstNumber);
        List<int> listTwo = Reverse(secondNumber);
        List<int> resultList = new List<int>();

        string one = string.Join("", listOne.ToArray());
        string two = string.Join("", listTwo.ToArray());
        one = string.Join("", (Reverse(one).ToArray()));
        two = string.Join("", (Reverse(two).ToArray()));
        int resultNumber = int.Parse(one) + int.Parse(two);

        Console.WriteLine(resultNumber);
    }
}

