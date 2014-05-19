using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        StringBuilder sbInput = new StringBuilder();

        Regex regex = new Regex(@"(\w\s+)|(\w$)");

        sbInput.Append(Console.ReadLine());

        int inputLength = sbInput.Length;

        string[] inputWords = sbInput.ToString().Split(' ');

        int longestWord = 0;

        for (int i = 0; i < inputWords.Length; i++)
        {
            if (inputWords[i].Length > longestWord)
            {
                longestWord = inputWords[i].Length;
            }
        }

        StringBuilder sb = new StringBuilder();

        StringBuilder buffSb = new StringBuilder();

        //MatchCollection matches = new MatchCollection();

        for (int j = 0; j < longestWord; j++)
        {
            MatchCollection matches = Regex.Matches(sbInput.ToString(), @"\w(?=\s+)|(\w$)");
           
            foreach (var item in matches)
            {
                sb.Append(item);
                //sbInput.Replace(item, " ")
                
            }
            //sb.Append(Regex.Matches(sbInput.ToString(), @"(\w\s+)|(\w$)"));
            buffSb.Append(sbInput);
            sbInput.Clear();
            sbInput.Append(Regex.Replace(buffSb.ToString(), @"(\w\s+)|(\w$)", " "));
            buffSb.Clear();
            
            //inputWords[i] = inputWords[i].Remove(inputWords[i].Length - 1);
           

        }

        int newPosition = 0;

        for (int i = 0; i < sb.Length; i++)
        {
            char originalChar = sb[i];

            if (char.IsLower(sb[i]))
            {
                newPosition = i + (sb[i] - 96);
            }
            else
            {
                newPosition = i + (sb[i] - 64);
            }

            while (newPosition > sb.Length - 1)
            {
                newPosition -= sb.Length;
            }
            //ok
            if (newPosition == i)
            {
                continue;
            }
            else if (newPosition > i)
            {
                for (int j = i; j < newPosition; j++)
                {
                    sb[j] = sb[j + 1];
                }
            }
            else if (newPosition < i)
            {
                for (int j = i; j > newPosition; j--)
                {
                    sb[j] = sb[j - 1];
                }
            }

            sb[newPosition] = originalChar;
        }

        Console.WriteLine(sb);
    }
}

