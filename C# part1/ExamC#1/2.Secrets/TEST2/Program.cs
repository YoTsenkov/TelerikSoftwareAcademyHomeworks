using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        if (number < 0)
        {
            number = -number;
        }
        BigInteger specialSum = 0;
        int digitNumber = (int)BigInteger.Log10(number) + 1;
        //int digitPos = 1;
        BigInteger digit;

        //Calculating special sum
        for (int i = 1; i <= digitNumber; i++)
        {
            digit = (number / BigInteger.Pow(10, i - 1)) % 10;
            specialSum +=  (i % 2) == 1 ? digit * i * i : digit * digit * i;
/*            if (i % 2 != 0)
            {
                specialSum += digit * i * i;
                //specialSum += (((BigInteger)(number / (BigInteger)Math.Pow(10, i - 1)) % 10)) * (i * i);
            }
            else
            {
                specialSum += digit * digit * i;
                //specialSum += ((BigInteger)(number / (BigInteger)Math.Pow(10, i - 1)) % 10) * ((BigInteger)(number / (BigInteger)Math.Pow(10, i - 1)) % 10) * i;
            }
 */
        }
     
        //Calculating alpha-sequence
        BigInteger seqLength = specialSum % 10;
        BigInteger r = specialSum % 26;
        string alphaSeq = null;

        if (seqLength == 0)
        {
            Console.WriteLine(specialSum);
            Console.WriteLine("{0} has no secret alpha-sequence", number);
        }
        else
        {
            for (int i = 0; i < seqLength; i++)
            {
                if (65 + r > 90)
                {
                    r = r - 26;
                }
                char Letter = (char)(65 + r);
                alphaSeq += Letter;
                r++;
            }

            //Printing final results
            Console.WriteLine(specialSum);
            Console.WriteLine(alphaSeq);
        }

    }
}