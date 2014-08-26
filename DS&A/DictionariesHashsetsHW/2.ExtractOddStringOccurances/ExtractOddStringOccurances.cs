namespace _2.ExtractOddStringOccurances
{
    using System;
    using System.Collections.Generic;

    public class ExtractOddStringOccurances
    {
        static void Main()
        {
            string[] programmingLanguagesNames = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> namesOccurances = new Dictionary<string, int>();
            for (int i = 0; i < programmingLanguagesNames.Length; i++)
            {
                if (namesOccurances.ContainsKey(programmingLanguagesNames[i]))
                {
                    namesOccurances[programmingLanguagesNames[i]]++;
                }
                else
                {
                    namesOccurances[programmingLanguagesNames[i]] = 1;
                }
            }

            foreach (var pair in namesOccurances)
            {
                if (pair.Value % 2 == 1)
                {
                    Console.WriteLine(pair.Key);
                }
            }
        }
    }
}
