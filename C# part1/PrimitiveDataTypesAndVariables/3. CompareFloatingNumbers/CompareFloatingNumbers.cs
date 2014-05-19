using System;
class CompareFloatingNumbers
{
    static void Main()
    {
        float number = 5.3f;
        float number2 = 6.01f;
        float number3 = 5.00000001f;
        float number4 = 5.00000003f;
        bool compare = number == number2;
        bool compare2 = number3 == number4;
    }
}

