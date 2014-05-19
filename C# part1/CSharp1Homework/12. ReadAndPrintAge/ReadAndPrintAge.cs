using System;

class ReadAndPrintAge
{
    static void Main()
    {
        string age;
        int convertedAge;
        age = (string)Console.ReadLine();
        convertedAge = Convert.ToInt32(age);
        Console.WriteLine(convertedAge + 10);
    }
}

