using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
       
        int numberOfRounds = int.Parse(input);
        int m = 0;
        int v = 0;


        for (int i = 1; i <= numberOfRounds; i++)
        {
            Console.WriteLine("enter drunken number for round {0}", i);
            input = Console.ReadLine();
            int drunkenNumber = int.Parse(input);
            int digitNumber = (int)Math.Log10(drunkenNumber) + 1;

            if (drunkenNumber > 0)
            {


                if (digitNumber % 2 == 0)
                {
                    for (int j = digitNumber; j > digitNumber / 2; j--)
                    {
                        m += ((int)(drunkenNumber / Math.Pow(10, j - 1)) % 10);
                    }
                    for (int a = 0; a < digitNumber / 2; a++)
                    {
                        v += ((((int)(drunkenNumber / Math.Pow(10, a)) % 10)));
                    }
                }
                else
                {
                    v += ((int)(drunkenNumber / Math.Pow(10, (digitNumber / 2))) % 10);
                    m += ((int)(drunkenNumber / Math.Pow(10, (digitNumber / 2))) % 10);
                    for (int j = digitNumber; j > (digitNumber / 2) + 1; j--)
                    {
                        m += ((int)(drunkenNumber / Math.Pow(10, j - 1)) % 10);
                    }
                    for (int a = 0; a < digitNumber / 2; a++)
                    {
                        v += ((((int)(drunkenNumber / Math.Pow(10, a)) % 10)));
                    }
                }
            }
            else if (drunkenNumber < 0)
            {
                
                m = ((int)(-(drunkenNumber / Math.Pow(10, digitNumber - 1))) % 10);
                if (digitNumber % 2 == 0)
                {
                    for (int j = digitNumber - 1; j > digitNumber / 2; j--)
                    {
                        m += ((int)(drunkenNumber / Math.Pow(10, j - 1)) % 10);
                    }
                    for (int a = 0; a < digitNumber / 2; a++)
                    {
                        v += ((((int)(drunkenNumber / Math.Pow(10, a)) % 10)));
                    }
                }
                else
                {
                    v += ((int)(drunkenNumber / Math.Pow(10, (digitNumber / 2))) % 10);
                    m += ((int)(drunkenNumber / Math.Pow(10, (digitNumber / 2))) % 10);
                    for (int j = digitNumber - 1; j > (digitNumber / 2) + 1; j--)
                    {
                        m += ((int)(drunkenNumber / Math.Pow(10, j - 1)) % 10);
                    }
                    for (int a = 0; a < digitNumber / 2; a++)
                    {
                        v += ((((int)(drunkenNumber / Math.Pow(10, a)) % 10)));
                    }
                }
            }
            if (m > v)
            {
                Console.WriteLine("M {0}", m - v);
            }
            else if (m == v)
            {
                Console.WriteLine("No {0}", m + v);
            }
            else if (m < v)
            {
                Console.WriteLine("V {0}", v - m);
            }
        }
    }
}

