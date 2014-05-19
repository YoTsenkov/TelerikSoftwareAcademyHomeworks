using System;
class Program
{
    static void Main()
    {
        int tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoSeeds = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageSeeds = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansSeeds = int.Parse(Console.ReadLine());
        int insufArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;

        int totalArea = 250;
        int beansArea = totalArea - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);
        float totalCost = (tomatoSeeds * 0.5f) + (cucumberSeeds * 0.4f) + (potatoSeeds * 0.25f) + (carrotSeeds * 0.6f) + (cabbageSeeds * 0.3f) + (beansSeeds * 0.4f);

        Console.WriteLine("Total costs: {0:f2}", totalCost);
        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (beansArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else if (insufArea > 250)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}

