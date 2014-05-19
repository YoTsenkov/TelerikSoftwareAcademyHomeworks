using System;
class Program
{
    static void Main()
    {
        //Input data
        long numberOne = int.Parse(Console.ReadLine());
        long numberTwo = int.Parse(Console.ReadLine());
        long numberThree = int.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());

        long numberN = numberOne + numberTwo + numberThree;


        Console.WriteLine(numberOne);
        Console.WriteLine(numberTwo + " " + numberThree);

        for (int i = 3; i <= lines; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (j < i - 1)
                {
                    Console.Write(numberN + " ");
                    numberOne = numberTwo;
                    numberTwo = numberThree;
                    numberThree = numberN;
                    numberN = numberOne + numberTwo + numberThree;
                }
                else
                {
                    Console.WriteLine(numberN);
                    numberOne = numberTwo;
                    numberTwo = numberThree;
                    numberThree = numberN;
                    numberN = numberOne + numberTwo + numberThree;
                }
            }

            //Console.WriteLine(numberTwo + " " + numberThree);
            //
            //numberN += numberOne + numberTwo + numberThree;
            //numberOne = numberTwo;
            //numberTwo = numberThree;
            //numberThree = numberN;
        }
    }
}

