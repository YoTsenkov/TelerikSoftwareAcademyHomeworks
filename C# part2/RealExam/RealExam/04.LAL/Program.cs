using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<int> binary = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            binary.Add(int.Parse(Convert.ToString(int.Parse(input[i]), 2)));
            
        }

        int numberOfLines = int.Parse(Console.ReadLine());

        char[] table = new char[1000];

        //string trash = Console.ReadLine();



        for (int i = 0; i < numberOfLines; i++)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Console.ReadLine());
            string reader = sb.ToString();
            sb.Remove(0, 1);
            int index = int.Parse(sb.ToString());
            table[index] = reader[0];

        }









        string binaryConcatenated = null;

        for (int i = 0; i < binary.Count; i++)
        {
            binaryConcatenated += binary[i];
        }
       

        //Console.WriteLine(binaryConcatenated);

        int startPosition = 0;

        int counter = 0;

        // string cut = null;

        for (int i = startPosition; i < binaryConcatenated.Length; i++)
        {
            if (binaryConcatenated[i] == '0' && binaryConcatenated[i - 1] == '0')
            {
                break;
            }
            else
            {
                if (binaryConcatenated[i] != '0')
                {
                    //cut += binaryConcatenated[i];
                    counter++;
                }
                else
                {
                    Console.Write(table[counter]);
                    //cut = null;
                    counter = 0;
                }
            }
        }

        Console.WriteLine();
    }
}

