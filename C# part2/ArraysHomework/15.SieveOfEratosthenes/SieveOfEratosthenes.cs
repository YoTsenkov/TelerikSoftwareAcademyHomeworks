using System;
class SieveOfEratosthenes
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        bool[] array = new bool[length + 1];
        for (int i = 2; i < array.Length; i++)
        {
            array[i] = true;
        }

        for (int i = 2; i <= Math.Sqrt(length); i++)
        {
            if (array[i] == true)
            {
                for (int j = i*i; j <= length; j += i)
                {
                    array[j] = false;
                }
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == true)
            {
                Console.WriteLine(i);
            }
        }
    }
}

