using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

class Program
{
    static int cycleNumber = 1;
    static int s = 0;
    static List<int> Method(List<int> input)
    {
        s = 0;

        for (int i = 0; i < cycleNumber; i++)
        {
            s += input[i];
        }

        if (input.Count - cycleNumber < s)
        {
            s = 9999999;
            return input;
        }

        int sum = 0;
        BigInteger product = 1;


        for (int j = cycleNumber; j < cycleNumber + s; j++)
        {
            sum += input[j];
            product *= input[j];
        }

        string result = sum.ToString() + product.ToString();

        for (int i = cycleNumber + s; i < input.Count; i++)
        {
            result += input[i].ToString();
        }
        //ok

        string clearResult = null;

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] != '0' && result[i] != '1')
            {
                clearResult += result[i];
            }
        }

        input.Clear();

        for (int i = 0; i < clearResult.Length; i++)
        {
            input.Add(int.Parse(clearResult[i].ToString()));
        }

        cycleNumber++;
        return input;
    }
    static void Main()
    {
        //input
        List<int> input = new List<int>();

        while (true)
        {
            string inputNumber = Console.ReadLine();
            if (inputNumber == "END")
            {
                break;
            }
            input.Add(int.Parse(inputNumber));
        }

        for (int i = 0; i < cycleNumber; i++)
        {
            s += input[i];
        }
        //input ends
        while (true)
        {
            if (input.Count < cycleNumber || input.Count - cycleNumber < s)
            {
                break;
            }
            Method(input);
        }


        for (int i = 0; i < input.Count - 1; i++)
        {
            Console.Write(input[i] + " ");
        }
        Console.WriteLine(input[input.Count - 1]);



        
    }
}

