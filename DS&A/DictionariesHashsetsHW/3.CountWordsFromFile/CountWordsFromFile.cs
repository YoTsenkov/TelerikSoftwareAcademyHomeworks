namespace _3.CountWordsFromFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    public class CountWordsFromFile
    {
        static void Main()
        {
            Dictionary<string, int> wordsOccurances = new Dictionary<string, int>();
            List<string> words = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader("Words.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string pattern = @"\b\w+";
                        foreach (Match match in Regex.Matches(line, pattern))
                        {
                            words.Add(match.Value);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            foreach (var word in words)
            {
                if (wordsOccurances.ContainsKey(word.ToLower()))
                {
                    wordsOccurances[word.ToLower()]++;
                }
                else
                {
                    wordsOccurances[word.ToLower()] = 1;
                }
            }

            foreach (var pair in wordsOccurances)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value + " times");
            }
        }
    }
}
