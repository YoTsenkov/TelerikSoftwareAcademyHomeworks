using System;
class CompareLexico
{
    static void Main()
    {
        int flag = 0;
        //first array
        int el = int.Parse(Console.ReadLine());
        char[] array = new char[el];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = char.Parse(Console.ReadLine());
        }
        //second array
        el = int.Parse(Console.ReadLine());
        char[] arrayTwo = new char[el];
        for (int i = 0; i < arrayTwo.Length; i++)
        {
            arrayTwo[i] = char.Parse(Console.ReadLine());
        }
        //check
        if (array.Length < arrayTwo.Length)
        {
            Console.WriteLine("the first array is first in lexi order");
            flag = 1;
        }
        else if (array.Length > arrayTwo.Length)
        {
            Console.WriteLine("the second array is first in lexi order");
            flag = 1;
        }
        else if (array.Length == arrayTwo.Length)
        {
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                if (array[i] > arrayTwo[i])
                {
                    Console.WriteLine("the second array is first in lexi order");
                    flag = 1;
                    break;
                }
                else if (array[i] < arrayTwo[i])
                {
                    Console.WriteLine("the first array is first in lexi order");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("the arrays  are equal");
            }
        }
    }
}

