using System;
using System.Collections.Generic;
using System.IO;

class SqrException
{
    static void Main()
    {
        Console.WriteLine("Enter a number.");
        
        try
        {
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("The square root is "+ Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");            
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");          
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

