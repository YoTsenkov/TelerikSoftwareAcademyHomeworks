namespace _1.CountValuesOccurances
{
    using System;
    using System.Collections.Generic;

    public class CountValuesOcuurances
    {
        static void Main()
        {
            double[] values = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> valuesOccurances = new Dictionary<double, int>();
            for (int i = 0; i < values.Length; i++)
            {
                if (valuesOccurances.ContainsKey(values[i]))
                {
                    valuesOccurances[values[i]]++;
                }
                else
                {
                    valuesOccurances[values[i]] = 1;
                }
            }

            foreach (var pair in valuesOccurances)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value + " times");
            }
        }
    }
}
