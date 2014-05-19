using System;
class PrintCards
{
    static void Main()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 2; j <= 14; j++)
            {
                switch (j)
                {
                    case 2: Console.Write("2 of ");
                        break;
                    case 3: Console.Write("3 of ");
                        break;
                    case 4: Console.Write("4 of ");
                        break;
                    case 5: Console.Write("5 of ");
                        break;
                    case 6: Console.Write("6 of ");
                        break;
                    case 7: Console.Write("7 of ");
                        break;
                    case 8: Console.Write("8 of ");
                        break;
                    case 9: Console.Write("9 of ");
                        break;
                    case 10: Console.Write("10 of ");
                        break;
                    case 11: Console.Write("Jack of ");
                        break;
                    case 12: Console.Write("Queen of ");
                        break;
                    case 13: Console.Write("King of ");
                        break;
                    case 14: Console.Write("Ace of ");
                        break;
                    default:
                        break;
                }

                switch (i)
                {
                    case 0: Console.WriteLine("clubs");
                        break;
                    case 1: Console.WriteLine("diamonds");
                        break;
                    case 2: Console.WriteLine("hearts");
                        break;
                    case 3: Console.WriteLine("spades");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

