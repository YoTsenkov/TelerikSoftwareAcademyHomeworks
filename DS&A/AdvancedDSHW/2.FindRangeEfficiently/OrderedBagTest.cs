namespace _2.FindRangeEfficiently
{
    using System;
    using Wintellect.PowerCollections;

    public class OrderedBagTest
    {
        private static void PrintProductsInPriceRange(OrderedBag<Product> collection, int firstNproducts, decimal from, bool fromInclusive, decimal to, bool toInclusive)
        {
            var productsInRange = collection.Range(new Product("randomName", from), fromInclusive, new Product("randomName", to), toInclusive);
            if (productsInRange.Count < firstNproducts)
            {
                firstNproducts = productsInRange.Count;
            }

            for (int i = 0; i < firstNproducts; i++)
            {
                Console.WriteLine(productsInRange[i].Name + " -> " + productsInRange[i].Price);
            }
        }

        static void Main()
        {
            var products = new OrderedBag<Product>();

            for (int i = 0; i < 500000; i++)
            {
                products.Add(new Product("name" + i, i));
            }

            Console.WriteLine("Enter starting price range:");
            decimal startingPriceRange = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending price range:");
            decimal endingPriceRange = decimal.Parse(Console.ReadLine());

            //PrintProductsInPriceRange(products, 20, startingPriceRange, true, endingPriceRange, true);

            //10 000 price searches test
            for (int i = 0; i < 10000; i++)
            {
                PrintProductsInPriceRange(products, 20, startingPriceRange + i, true, endingPriceRange + i, true);
            }
        }
    }
}
