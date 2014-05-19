using System;
class Exchange_Bits
{
    static void Main()
    {
        long myInt = 529996257;
        Console.WriteLine(Convert.ToString(myInt, 2) + "\n");

        int pos3 = 3;
        int mask = 1 << pos3;
        long bit = myInt & mask;
        long result3 = bit >> pos3;

        int pos24 = 24;
        mask = 1 << pos24;
        bit = myInt & mask;
        long result24 = bit >> pos24;

        int pos4 = 4;
        mask = 1 << pos4;
        bit = myInt & mask;
        long result4 = bit >> pos4;

        int pos5 = 5;
        mask = 1 << pos5;
        bit = myInt & mask;
        long result5 = bit >> pos5;

        int pos25 = 25;
        mask = 1 << pos25;
        bit = myInt & mask;
        long result25 = bit >> pos25;

        int pos26 = 26;
        mask = 1 << pos26;
        bit = myInt & mask;
        long result26 = bit >> pos26;

        int maskNew1 = ~(1 << pos24);
        int maskNew2 = (1 << pos24);
        int maskNew = result3 == 0 ? maskNew1 : maskNew2;
        long result1 = myInt & maskNew;
        long result2 = myInt | maskNew;
        myInt = result3 == 0 ? result1 : result2;
        Console.WriteLine(Convert.ToString(myInt, 2));

        maskNew1 = ~(1 << pos3);
        maskNew2 = (1 << pos3);
        maskNew = result24 == 0 ? maskNew1 : maskNew2;
        result1 = myInt & maskNew;
        result2 = myInt | maskNew;
        myInt = result24 == 0 ? result1 : result2;
        Console.WriteLine(Convert.ToString(myInt, 2));

        maskNew1 = ~(1 << pos25);
        maskNew2 = (1 << pos25);
        maskNew = result4 == 0 ? maskNew1 : maskNew2;
        result1 = myInt & maskNew;
        result2 = myInt | maskNew;
        myInt = result4 == 0 ? result1 : result2;
        Console.WriteLine(Convert.ToString(myInt, 2));

        maskNew1 = ~(1 << pos4);
        maskNew2 = (1 << pos4);
        maskNew = result25 == 0 ? maskNew1 : maskNew2;
        result1 = myInt & maskNew;
        result2 = myInt | maskNew;
        myInt = result25 == 0 ? result1 : result2;
        Console.WriteLine(Convert.ToString(myInt, 2));

        maskNew1 = ~(1 << pos26);
        maskNew2 = (1 << pos26);
        maskNew = result5 == 0 ? maskNew1 : maskNew2;
        result1 = myInt & maskNew;
        result2 = myInt | maskNew;
        myInt = result5 == 0 ? result1 : result2;
        Console.WriteLine(Convert.ToString(myInt, 2));

        maskNew1 = ~(1 << pos5);
        maskNew2 = (1 << pos5);
        maskNew = result26 == 0 ? maskNew1 : maskNew2;
        result1 = myInt & maskNew;
        result2 = myInt | maskNew;
        myInt = result26 == 0 ? result1 : result2;
        Console.WriteLine(Convert.ToString(myInt, 2));
    }
}

