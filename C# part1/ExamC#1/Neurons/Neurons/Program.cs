using System;
class Program
{
    static void Main()
    {
        long number;
        int bitPos = 0;
        long bit = 0;
        int bitPosTwo = 0;

        while (true)
        {
            number = long.Parse(Console.ReadLine());
            bitPos = 0;
            bitPosTwo = 0;

            if (number == -1)
            {
                break;
            }
            //calculating the positions of the two 1s
            for (int i = 0; i < 32; i++)
            {
                bit = (number >> i) & 1;
                if (bit == 1 && ((number >> (i + 1)) & 1) != 1)
                {
                    bitPos = i;
                    break;
                }
            }
            for (int j = bitPos + 1; j < 32; j++)
            {
                bit = (number >> j) & 1;
                if (bit == 1)
                {
                    bitPosTwo = j;
                    break;
                }
            }
            //filling the space between the two 1s with 1s
            for (int i = bitPos + 1; i < bitPosTwo; i++)
            {
                uint mask = (uint)1 << i;
                number = number | mask;
            }
            //Turning rest bits into 0s
            uint maskZero;

            for (int i = 0; i <= bitPos; i++)
            {
                maskZero = ~((uint)1 << i);
                number = number & maskZero;
            }
            for (int i = (int)bitPosTwo; i < 32; i++)
            {
                maskZero = ~((uint)1 << i);
                number = number & maskZero;
            }
            Console.WriteLine(number);
        }
    }
}


