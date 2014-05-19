namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    class IEnumerableExtensionMethods
    {
        static void Main()
        {
            var list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            Console.WriteLine(list.Sum()); // 10
            Console.WriteLine(list.Product()); // -10
            Console.WriteLine(list.Max()); // 4
            Console.WriteLine(list.Min()); // 0
            Console.WriteLine(list.Avarage()); // 2

        }
    }
}
