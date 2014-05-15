namespace _01.RefactorCSharp
{
    using System;
    using System.Linq;

    public class Printer
    {
        public void PrintBoolean(bool boolVariable)
        {
            string boolAsString = boolVariable.ToString();
            Console.WriteLine(boolAsString);
        }
    }
}
