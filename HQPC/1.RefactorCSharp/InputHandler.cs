namespace _1.RefactorCSharp
{
    using System;   
    using System.Linq;

    public class InputHandler
    {
        private const int MaxCount = 6;
        
        public static void ProcessInput()
        {
            Printer printer = new Printer();
            printer.PrintBoolean(true);
        }
    }
}
