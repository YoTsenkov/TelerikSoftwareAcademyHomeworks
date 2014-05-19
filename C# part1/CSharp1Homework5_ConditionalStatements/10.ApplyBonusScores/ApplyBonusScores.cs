using System;
class ApplyBonusScores
{
    static void Main()
    {
        int digit;
        bool result = int.TryParse(Console.ReadLine(), out digit);
        if (result == false || digit == 0)
        {
            Console.WriteLine("error");
        }
        switch (digit)
        {
            case 1:
            case 2:
            case 3: Console.WriteLine(digit * 10);
                break;
            case 4:
            case 5:
            case 6: Console.WriteLine(digit * 100);
                break;
            case 7:
            case 8:
            case 9: Console.WriteLine(digit * 1000);
                break;
            default:
                break;
        }

    }
}

