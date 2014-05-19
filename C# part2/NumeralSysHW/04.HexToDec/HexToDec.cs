using System;
class HexToDec
{
    static void Convert(string hexNum)
    {
        int dec = 0;
        for (int i = hexNum.Length - 1; i >= 0; i--)
        {
            if (hexNum[i] == 'A')
            {
                dec += 10 * (int)Math.Pow(16,hexNum.Length - 1 - i);
            }
            else if (hexNum[i] == 'B')
            {
                dec += 11 * (int)Math.Pow(16, hexNum.Length - 1 - i); ;
            }
            else if (hexNum[i] == 'C')
            {
                dec += 12 * (int)Math.Pow(16, hexNum.Length - 1 - i); ;
            }
            else if (hexNum[i] == 'D')
            {
                dec += 13 * (int)Math.Pow(16, hexNum.Length - 1 - i); ;
            }
            else if (hexNum[i] == 'E')
            {
                dec += 14 * (int)Math.Pow(16, hexNum.Length - 1 - i); ;
            }
            else if (hexNum[i] == 'F')
            {
                dec += 15 * (int)Math.Pow(16, hexNum.Length - 1 - i); ;
            }
            else
            {
                dec += int.Parse(hexNum[i].ToString()) * (int)Math.Pow(16, hexNum.Length - 1 - i);
            }
        }
        Console.WriteLine(dec);
    }
    static void Main()
    {
        Convert("4D2");     
    }
}

