using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Program
{
    static string[] numbers = new string[13];

    static void Convert(string input)
    {
        BigInteger dec = 0;
        int power = 0;
        string digit;


        for (int j = input.Length - 1; j >= 2; j -= 3)
        {
            digit = input[j - 2].ToString() + input[j - 1] + input[j];
            for (int z = 0; z < numbers.Length; z++)
            {
                if (numbers[z] == digit)
                {
                    dec += z * (BigInteger)Math.Pow(13, power);
                    power++;
                    break;
                }
            }
        }

        Console.WriteLine(dec);
    }
    static void Main()
    {
        numbers[0] = "CHU";
        numbers[1] = "TEL";
        numbers[2] = "OFT";
        numbers[3] = "IVA";
        numbers[4] = "EMY";
        numbers[5] = "VNB";
        numbers[6] = "POQ";
        numbers[7] = "ERI";
        numbers[8] = "CAD";
        numbers[9] = "K-A";
        numbers[10] = "IIA";
        numbers[11] = "YLO";
        numbers[12] = "PLA";
       

        string input = Console.ReadLine();
        Convert(input);
    }
}

