using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Program
{
    static List<string> numbers = new List<string>();
    static BigInteger Convert(string input)
    {
        string digit;
        BigInteger decNumber = 0;
        int power = 0;


        if (input.Length % 2 == 0)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {                
                if (i > 0 && char.IsLower(input[i - 1]) == true)
                {
                    digit = input[i - 1].ToString() + input[i];
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[j] == digit)
                        {
                            decNumber += j * (BigInteger)Math.Pow(168, power);
                            power++;
                        }
                    }
                    i--;
                }
                else
                {
                    digit = input[i].ToString();
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[j] == digit)
                        {
                            decNumber += j * (BigInteger)Math.Pow(168, power);
                            power++;
                        }
                    }
                }
            }
            return decNumber;
        }



        if (input.Length % 2 == 1)
        {
            for (int i = input.Length - 1; i >= 1; i--)
            {
                if (char.IsLower(input[i - 1]) == true)
                {
                    digit = input[i - 1].ToString() + input[i];
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[j] == digit)
                        {
                            decNumber += j * (BigInteger)Math.Pow(168, power);
                            power++;
                        }
                    }
                    i--;
                }
                else
                {
                    digit = input[i].ToString();
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[j] == digit)
                        {
                            decNumber += j * (BigInteger)Math.Pow(168, power);
                            power++;
                        }
                    }
                }
            }
            digit = input[0].ToString();
            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] == digit)
                {
                    decNumber += j * (BigInteger)Math.Pow(168, power);
                    power++;
                }
            }
            return decNumber;
        }


        return decNumber;
    }
    static void Main()
    {

        numbers.Capacity = 168;
        int index = 97;
        int secondIndex = 0;
        for (int i = 0; i < 26; i++)
        {
            numbers.Add(((char)(i + 65)).ToString());
        }
        for (int i = 0; i < 142; i++, secondIndex++)
        {
            if (secondIndex == 26)
            {
                secondIndex = 0;
            }
            if (i % 26 == 0 && i != 0)
            {
                index++;

            }
            numbers.Add((char)index + numbers[secondIndex]);
        }
        string input = Console.ReadLine();
        Console.WriteLine(Convert(input));
    }
}

