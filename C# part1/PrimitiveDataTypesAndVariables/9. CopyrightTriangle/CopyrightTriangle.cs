using System;
class CopyrightTriangle
{
    static void Main()
    {
        char uni = '\u00A9';
        string sign = uni.ToString();
        string triangle = sign + "\n" + sign + sign + "\n" + sign + sign + sign;
        Console.WriteLine(triangle);
    }
}

