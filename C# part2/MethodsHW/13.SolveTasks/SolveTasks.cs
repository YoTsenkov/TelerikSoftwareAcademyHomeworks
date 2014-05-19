using System;
using System.Collections.Generic;
class Program
{
    static void Reverse()
    {
        Console.WriteLine("Enter the non-negative number you want to reverse.");
        string number = Console.ReadLine();
        while (int.Parse(number) < 0)
        {
            Console.WriteLine("This is not a valid number. Enter new one.");
            number = Console.ReadLine();
        }

        List<int> array = new List<int>();
        int buff;

        foreach (char item in number)
        {
            array.Add(item - 48);
        }
        for (int i = 0; i < number.Length / 2; i++)
        {
            buff = array[i];
            array[i] = array[number.Length - 1 - i];
            array[number.Length - 1 - i] = buff;
        }
        Console.WriteLine("The reversed number is " + string.Join("", array));
    }

    static void Avarage()
    {
        Console.WriteLine("Enter the sequence of integers you want to calculate the avarage of then type END.");
        List<decimal> list = new List<decimal>();
        do
        {
            list.Add(decimal.Parse(Console.ReadLine()));
        } while (Console.ReadLine() != "end");

        decimal sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        Console.WriteLine("Avarage -> {0}", sum / list.Count);
    }

    static void Linear()
    {
        Console.WriteLine("You have chosen to solve A * X + B = 0");
        Console.WriteLine("Enter A which is NOT equal to 0.");
        int a = int.Parse(Console.ReadLine());
        while (a == 0)
        {
            Console.WriteLine("You have entered invalid value for A. Enter new one.");
            a = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter B.");
        int b = int.Parse(Console.ReadLine());
        double x = (double)(-b) / (double)a;
        Console.WriteLine("X = {0}", x);
    }
    static void Main()
    {
        Console.WriteLine("Press 1 if you want to reverse the digits if a number.");
        Console.WriteLine("Press 2 if you want to calculate the avarage of a sequence of numbers.");
        Console.WriteLine("Press 3 if you want to solve a linear equation.");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": Reverse();
                break;
            case "2": Avarage();
                break;
            case "3": Linear();
                break;
            default:
                break;
        }
    }
}

