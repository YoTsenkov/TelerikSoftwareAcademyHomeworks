using System;
using System.Collections.Generic;
class ConvFromAnyToAnyNumSys
{

    static void Convert(int firstBase, string firstNumber, int secondBase)
    {
        int dec = 0;
        List<int> outNum = new List<int>();
        for (int i = firstNumber.Length - 1; i >= 0; i--)
        {
            switch (firstNumber[i])
            {
                case '0': dec += 0 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case '1': dec += 1 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case '2': dec += 2 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case '3': dec += 3 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case '4': dec += 4 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case '5': dec += 5 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case '6': dec += 6 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case '7': dec += 7 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case '8': dec += 8 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case '9': dec += 9 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case 'A': dec += 10 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case 'B': dec += 11 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case 'C': dec += 12 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case 'D': dec += 13 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case 'E': dec += 14 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                case 'F': dec += 15 * (int)Math.Pow(firstBase, firstNumber.Length - 1 - i);
                    break;
                default:
                    break;
            }
        }

        while (dec != 0)
        {
            outNum.Add(dec % secondBase);
            dec = dec / secondBase;
        }
        Console.Write("The converted number is ");
        for (int i = outNum.Count - 1; i >= 0; i--)
        {
            if (outNum[i] == 10)
            {
                Console.Write("A");
            }
            else if (outNum[i] == 11)
            {
                Console.Write("B");
            }
            else if (outNum[i] == 12)
            {
                Console.Write("C");
            }
            else if (outNum[i] == 13)
            {
                Console.Write("D");
            }
            else if (outNum[i] == 14)
            {
                Console.Write("E");
            }
            else if (outNum[i] == 15)
            {
                Console.Write("F");
            }
            else
            {
                Console.Write(outNum[i]);
            }
        }
        Console.WriteLine();

    }
    static void Main()
    {
        Console.WriteLine("Enter the base of the numeral system you want to convert from.");
        int firstBase = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter the number with that base.");
        string firstNumber = Console.ReadLine();
        Console.WriteLine("Enter the base of the numeral system you want to convert to.");
        int secondBase = int.Parse(Console.ReadLine());

        Convert(firstBase, firstNumber, secondBase);
    }
}

