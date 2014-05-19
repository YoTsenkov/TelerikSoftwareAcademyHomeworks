using System;
class Program
{
    static void Main()
    {
        long firstNumber = int.Parse(Console.ReadLine());
        long secondNumber = int.Parse(Console.ReadLine());
        long thirdNumber = int.Parse(Console.ReadLine());
        long fourthNumber = int.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        Console.Write(firstNumber + " ");
        Console.Write(secondNumber + " ");
        Console.Write(thirdNumber + " ");
        Console.Write(fourthNumber + " ");


        for (int j = 0; j < columns - 4; j++)
        {
            long nextNumber = firstNumber + secondNumber + thirdNumber + fourthNumber;
            Console.Write(nextNumber + " ");
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = fourthNumber;
            fourthNumber = nextNumber;
        }
        Console.WriteLine();
        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                long nextNumber = firstNumber + secondNumber + thirdNumber + fourthNumber;
                Console.Write(nextNumber + " ");
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = fourthNumber;
                fourthNumber = nextNumber;
            }
            Console.WriteLine();
        }

    }
}

