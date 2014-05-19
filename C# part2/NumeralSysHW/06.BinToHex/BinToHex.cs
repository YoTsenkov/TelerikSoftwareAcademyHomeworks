using System;
using System.Collections.Generic;
class BinToHex
{
    static void Convert(int bin)
    {
        string binStr = bin.ToString();
        List<int> currentByte = new List<int>();
        List<int> binList = new List<int>();
        for (int i = 0; i < 4 - binStr.Length % 4; i++)
        {
            binList.Add(0);
        }
        for (int i = 0; i < binStr.Length; i++)
        {
            binList.Add(binStr[i] - 48);
        }
        int binLength = binList.Count;
        int counter = 0;

        for (int i = 0; i < binLength / 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                currentByte.Add(binList[counter]);
                counter++;
            }

            string lastByte = string.Join("", currentByte.ToArray());

            switch (lastByte)
            {
                case "0000": Console.Write(0);
                    break;
                case "0001": Console.Write(1);
                    break;
                case "0010": Console.Write(2);
                    break;
                case "0011": Console.Write(3);
                    break;
                case "0100": Console.Write(4);
                    break;
                case "0101": Console.Write(5);
                    break;
                case "0110": Console.Write(6);
                    break;
                case "0111": Console.Write(7);
                    break;
                case "1000": Console.Write(8);
                    break;
                case "1001": Console.Write(9);
                    break;
                case "1010": Console.Write('A');
                    break;
                case "1011": Console.Write('B');
                    break;
                case "1100": Console.Write('C');
                    break;
                case "1101": Console.Write('D');
                    break;
                case "1110": Console.Write('E');
                    break;
                case "1111": Console.Write('F');
                    break;
                default:
                    break;
            }
            currentByte.Clear();
            lastByte = null;
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Convert(111011010);
    }
}

