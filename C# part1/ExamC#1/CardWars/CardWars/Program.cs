using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        int games = int.Parse(Console.ReadLine());
        BigInteger firstScore = 0;
        BigInteger secondScore = 0;
        int firstGamesWon = 0;
        int secondGamesWon = 0;
        int currentScoreOne = 0;
        int currentScoreTwo = 0;
        int flagOne = 0;
        int flagTwo = 0;
        string input;

        for (int j = 0; j < games; j++)
        {
            currentScoreOne = 0;
            currentScoreTwo = 0;
            flagOne = 0;
            flagTwo = 0;
            //first player
            for (int i = 0; i < 3; i++)
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "2": currentScoreOne += 10;
                        break;
                    case "3": currentScoreOne += 9;
                        break;
                    case "4": currentScoreOne += 8;
                        break;
                    case "5": currentScoreOne += 7;
                        break;
                    case "6": currentScoreOne += 6;
                        break;
                    case "7": currentScoreOne += 5;
                        break;
                    case "8": currentScoreOne += 4;
                        break;
                    case "9": currentScoreOne += 3;
                        break;
                    case "10": currentScoreOne += 2;
                        break;
                    case "A": currentScoreOne += 1;
                        break;
                    case "J": currentScoreOne += 11;
                        break;
                    case "Q": currentScoreOne += 12;
                        break;
                    case "K": currentScoreOne += 13;
                        break;
                    case "Z": firstScore = firstScore * 2;
                        break;
                    case "Y": firstScore -= 200;
                        break;
                    case "X": flagOne = 1;
                        break;
                    default:
                        break;
                }
            }
            //second player
            for (int i = 0; i < 3; i++)
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "2": currentScoreTwo += 10;
                        break;
                    case "3": currentScoreTwo += 9;
                        break;
                    case "4": currentScoreTwo += 8;
                        break;
                    case "5": currentScoreTwo += 7;
                        break;
                    case "6": currentScoreTwo += 6;
                        break;
                    case "7": currentScoreTwo += 5;
                        break;
                    case "8": currentScoreTwo += 4;
                        break;
                    case "9": currentScoreTwo += 3;
                        break;
                    case "10": currentScoreTwo += 2;
                        break;
                    case "A": currentScoreTwo += 1;
                        break;
                    case "J": currentScoreTwo += 11;
                        break;
                    case "Q": currentScoreTwo += 12;
                        break;
                    case "K": currentScoreTwo += 13;
                        break;
                    case "Z": secondScore = secondScore * 2;
                        break;
                    case "Y": secondScore -= 200;
                        break;
                    case "X": flagTwo = 1;
                        break;
                    default:
                        break;
                }
            }

            if (currentScoreOne > currentScoreTwo && flagOne == 0 && flagTwo == 0)
            {
                firstGamesWon++;
                firstScore += currentScoreOne;
            }
            else if (currentScoreTwo > currentScoreOne && flagOne == 0 && flagTwo == 0)
            {
                secondGamesWon++;
                secondScore += currentScoreTwo;
            }
            else if (currentScoreOne == currentScoreTwo && flagOne == 0 && flagTwo == 0)
            {
                continue;
            }
            else if (flagOne == 1 && flagTwo == 0)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                break;
            }
            else if (flagOne == 0 && flagTwo == 1)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                break;
            }
            else if (flagOne == 1 && flagTwo == 1)
            {
                firstScore += 50;
                secondScore += 50;
            }
        }

        if (firstScore > secondScore && flagOne == flagTwo)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", firstScore);
            Console.WriteLine("Games won: {0}", firstGamesWon);
        }
        else if (firstScore < secondScore && flagOne == flagTwo)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", secondScore);
            Console.WriteLine("Games won: {0}", secondGamesWon);
        }
        else if (firstScore == secondScore && flagOne == flagTwo)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", firstScore);
        }
    }
}