
using System;
using System.Collections.Generic;
class Program
{
    static int naUm = 0;
    static string number = Console.ReadLine();
    static int multiplier = int.Parse(number) - 1;
    static List<int> listEnter = new List<int>();
    static List<int> output = new List<int>();
    static List<int> Multiply(List<int> list)
    {
        

        naUm = 0;
        List<int> result = new List<int>();
        
            for (int i = list.Count - 1; i >= 1; i--)
            {
                result.Add((naUm + (list[i] * multiplier)) % 10);
                naUm = (naUm + (list[i] * multiplier)) / 10;
                //result.Add((list[i] * multiplier) / 10 + (list[i + 1] * multiplier) % 10);
            }
            result.Add((naUm + (list[0] * multiplier)) % 10);
            if ((naUm + (list[0] * multiplier) > 9))
            {                           
            result.Add((naUm + (list[0] * multiplier)) / 10);
            }
        return listEnter = result;
    }
    static void Main()
    {
        foreach (char item in number)
        {
            listEnter.Add(item - 48);
        }

        for (int i = 0; i < int.Parse(number) - 2; i++)
        {
            Multiply(listEnter);
            multiplier--;
            for (int j = 0; j < listEnter.Count / 2; j++)
            {
                int buff = listEnter[j];
                listEnter[j] = listEnter[listEnter.Count - 1 - j];
                listEnter[listEnter.Count - 1 - j] = buff;
            }
        }

        foreach (var item in listEnter)
        {
            Console.Write(item);
        }
    }
}

