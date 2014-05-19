using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Program
{
    static string[] numbers = new string[15];

    static void Convert(string input)
    {
        BigInteger dec = 0;
        int power = 0;
        string digit;

        
            for (int j = input.Length - 1; j >= 3; j -= 4)
            {
                digit = input[j - 3].ToString() + input[j - 2] + input[j - 1] + input[j];
                for (int z = 0; z < numbers.Length; z++)
                {
                    if (numbers[z] == digit)
                    {
                        dec += z * (BigInteger)Math.Pow(15, power);
                        power++;
                        break;
                    }
                }
            }
        
        Console.WriteLine(dec);
    }
    static void Main()
    {        
        numbers[0] = "Rawr";
        numbers[1] = "Rrrr";
        numbers[2] = "Hsst";
        numbers[3] = "Ssst";
        numbers[4] = "Grrr";
        numbers[5] = "Rarr";
        numbers[6] = "Mrrr";
        numbers[7] = "Psst";
        numbers[8] = "Uaah";
        numbers[9] = "Uaha";
        numbers[10] = "Zzzz";
        numbers[11] = "Bauu";
        numbers[12] = "Djav";
        numbers[13] = "Myau";
        numbers[14] = "Gruh";

        string input = Console.ReadLine();
        Convert(input);
    }
}

