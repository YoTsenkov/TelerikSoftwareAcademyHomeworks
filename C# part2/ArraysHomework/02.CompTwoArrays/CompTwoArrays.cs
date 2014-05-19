using System;
class CompTwoArrays
{
    static void Main()
    {
        int flag = 0;

        Console.WriteLine("vuvedete broi elementi na purviq masiv : ");
        int el = int.Parse(Console.ReadLine());
        int[] array = new int[el];
        Console.WriteLine("vuvedete elementite na masiv 1 : ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("vuvedete broi elementi za vtoriq masiv : ");
        el = int.Parse(Console.ReadLine());
        int[] arrayTwo = new int[el];
        Console.WriteLine("vuvedete elementite na vtoriq masiv: ");
        for (int i = 0; i < arrayTwo.Length; i++)
        {
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }

        if (arrayTwo.Length == array.Length)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != arrayTwo[i])
                {
                    flag = 1;
                }
            }
        }
        else
        {
            flag = 1;
        }

        if (flag == 0)
        {
            Console.WriteLine("the arrays are equal");
        }
        else
        {
            Console.WriteLine("the arrays are NOT equal");
        }
    }
}

