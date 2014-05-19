using System;
class RandomNum
{
    static void Main()
    {
        Random rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            int randNum = rand.Next(100) + 100;
            Console.Write(randNum + " ");
        }
    }
}

