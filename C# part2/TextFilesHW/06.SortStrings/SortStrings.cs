using System;
using System.Collections.Generic;
using System.IO;

class SortStrings
{
    static void Main()
    {
        string[] unsorted = File.ReadAllLines("unsorted.txt");
        for (int i = 0; i < unsorted.Length; i++)
        {
            for (int k = i + 1; k < unsorted.Length; k++)
            {
                string one = unsorted[i];
                string two = unsorted[k];
                string buff;
                int stringLength;
                if (one.Length < two.Length)
                {
                    stringLength = one.Length;
                }
                else
                {
                    stringLength = two.Length;
                }
                for (int j = 0; j < stringLength; j++)
                {
                    if (one[j] == two[j])
                    {
                        continue;
                    }
                    else if (one[j] > two[j])
                    {
                        buff = unsorted[i];
                        unsorted[i] = unsorted[k];
                        unsorted[k] = buff;
                        break;
                    }
                    else if (one[j] < two[j])
                    {
                        break;
                    }
                }
            }
        }
        File.WriteAllLines("sortedStrings.txt", unsorted);
        Console.WriteLine("The strings from the file have been sorted and saved at sortedStrings.txt");
    }
}

