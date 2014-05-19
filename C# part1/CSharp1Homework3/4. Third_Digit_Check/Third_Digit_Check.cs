using System;
class Third_Digit_Check
{
    static void Main()
    {
        int myInt = 1234567590;
        int third = (myInt / 100) % 10;
        bool check = (third == 7);
    }
}

