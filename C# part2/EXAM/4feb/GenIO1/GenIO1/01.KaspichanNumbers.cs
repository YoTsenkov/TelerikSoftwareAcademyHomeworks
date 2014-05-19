using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


class KaspichanNumbers
{
    static List<BigInteger> Convert(BigInteger dec)
    {
        string decNumber = dec.ToString();
        BigInteger reminder;
        List<BigInteger> result = new List<BigInteger>();
        if (dec == 0)
        {
            result.Add(0);
            return result;
        }
        else
        {
            while (dec != 0)
            {
                result.Add(dec % 256);
                dec = dec / 256;
            }
            return result;
        }
    }
    static void Main()
    {
        List<string> numbers = new List<string>();
        numbers.Capacity = 256;
        int index = 97;
        int secondIndex = 0;
        for (int i = 0; i < 26; i++)
        {
            numbers.Add(((char)(i + 65)).ToString());
        }
        for (int i = 0; i < 230; i++, secondIndex++)
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
        BigInteger input = BigInteger.Parse(Console.ReadLine());
        Convert(1000);
        for (int i = 0; i < Convert(input).Count; i++)
        {
            Console.Write(numbers[(int)Convert(input)[Convert(input).Count - 1 - i]]);
        }
        Console.WriteLine();
    }
}

