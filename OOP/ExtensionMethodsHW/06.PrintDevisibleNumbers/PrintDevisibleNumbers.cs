namespace PrintDevisibleNumbers
{
    using System;
    using System.Linq;
    class PrintDevisibleNumbers
    {
        static void Main()
        {
            var numbers = new[] 
            {
                6, 1, 7, 2, 14, 18, 0, 5
            };

            //LINQ
            var devisibleNumbersWithLINQ =
                from nb in numbers
                where nb % 3 == 0 || nb % 7 == 0 && nb != 0
                select nb;

            foreach (var number in devisibleNumbersWithLINQ)
            {
                Console.WriteLine(number);
            }

            //LAMBDA
            var devisibleNumbers = numbers.Where(nb => (nb % 3 == 0 || nb % 7 == 0) && nb != 0);

            foreach (var number in devisibleNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
