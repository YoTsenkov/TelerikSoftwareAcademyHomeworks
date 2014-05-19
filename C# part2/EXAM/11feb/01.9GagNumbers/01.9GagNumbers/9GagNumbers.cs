using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Program
{
    static void Convert(string input)
    {
        BigInteger dec = 0;
        string gag = input;
        string digit;
        int power = 0;

        for (int i = gag.Length - 1; i >= 1; )
        {
            digit = gag[i - 1].ToString() + gag[i];

            if (digit == "-!")
            {
                dec += 0 * (BigInteger)Math.Pow(9, power);
                power++;
                i -= 2;
            }
            else if (digit == "**")
            {
                dec += 1 * (BigInteger)Math.Pow(9, power);
                power++;
                i -= 2;
            }
            else if (digit == "!!")
            {
                if (i > 2 && input[i - 3] == '*')
                {
                    if (i > 3 && input[i - 4] != '*')
                    {
                        dec += 6 * (BigInteger)Math.Pow(9, power);
                        power++;
                        i -= 4;
                    }
                    else if (i - 2 > 0)
                    {
                        dec += 6 * (BigInteger)Math.Pow(9, power);
                        power++;
                        i -= 4;
                    }
                }
                else
                {
                    dec += 2 * (BigInteger)Math.Pow(9, power);
                    power++;
                    i -= 3;
                }
            }
            else if (digit == "&&")
            {
                dec += 3 * (BigInteger)Math.Pow(9, power);
                power++;
                i -= 2;
            }
            else if (digit == "&-")
            {
                dec += 4 * (BigInteger)Math.Pow(9, power);
                power++;
                i -= 2;
            }
            else if (digit == "!-")
            {
                if (i > 4 && input[i - 2] == '*') // && input[i - 6] == '!' && input[i - 7] == '!' && input[i - 8] == '*'
                {
                    if (i > 5 && input[i - 5] == '!' && input[i - 6] != '!')
                    {
                        //if (i > 7 && input[i - 7] == '*' && input[i - 8] != '*')
                        //{
                        //    
                        //}
                        dec += 8 * (BigInteger)Math.Pow(9, power);
                        power++;
                        i -= 6;
                    }
                    else if (i - 4 > 0)
                    {
                        dec += 8 * (BigInteger)Math.Pow(9, power);
                        power++;
                        i -= 6;
                    }
                }
                else
                {
                    dec += 5 * (BigInteger)Math.Pow(9, power);
                    power++;
                    i -= 2;
                }
            }
            else if (digit == "*!")
            {
                dec += 7 * (BigInteger)Math.Pow(9, power);
                power++;
                i -= 3;
            }
        }
        Console.WriteLine(dec);
    }
    static void Main()
    {
        //string[] numbers = new string[9];
        //numbers[0] = "-!";
        //numbers[1] = "**";
        //numbers[2] = "!!!";
        //numbers[3] = "&&";
        //numbers[4] = "&-";
        //numbers[5] = "!-";
        //numbers[6] = "*!!!";
        //numbers[7] = "&*!";
        //numbers[8] = "!!**!-";

        string input = Console.ReadLine();
        Convert(input);



    }
}

