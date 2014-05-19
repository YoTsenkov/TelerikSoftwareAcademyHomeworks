using System;
class Bit_Three_Check
{
    static void Main()
    {
        int myInt = 23;
        int pos = 3;
        int bit = myInt >> pos;
        int check = myInt & 1;
        bool result = check == 0;
    }
}

