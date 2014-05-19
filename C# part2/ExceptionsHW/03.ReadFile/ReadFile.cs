using System;
using System.Collections.Generic;
using System.IO;
using System.Security;

class ReadFile
{
    static void Main()
    {
        Console.WriteLine("Enter the full path name of the file you want to read from.");
        string path = Console.ReadLine();
        try
        {
            string[] content = File.ReadAllLines(path);
            foreach (var item in content)
            {
                Console.WriteLine(item);
            }
        }
        catch (Exception ex)
        {
            if (ex is ArgumentException || ex is ArgumentNullException)
            {
                Console.WriteLine("You have entered invalid argument.");
            }
            else if (ex is PathTooLongException)
            {
                 Console.WriteLine("The path of the file you have entered is too long.");
            }
            else if (ex is DirectoryNotFoundException)
            {
                Console.WriteLine("The directory you have entered could not be found.");
            }
            else if (ex is UnauthorizedAccessException)
            {
                Console.WriteLine("The file can't be accessed right now.");
            }
            else if (ex is FileNotFoundException)
            {
                Console.WriteLine("The file you are trying to access does not exist.");
            }
            else if (ex is NotSupportedException)
            {
                Console.WriteLine("The stream you are trying to read from does not support the invoked functionality");
            }
            else if (ex is SecurityException)
            {
                Console.WriteLine("A security error occured converning the file.");
            }
        }
      // catch (PathTooLongException)
      // {
      //     Console.WriteLine("The path of the file you have entered is too long.");
      // }
      // catch (DirectoryNotFoundException)
      // {
      //     Console.WriteLine("The directory you have entered could not be found.");
      // }
       //catch (UnauthorizedAccessException)
       //{
       //    Console.WriteLine("The file can't be accessed right now.");
       //}
      // catch (FileNotFoundException)
      // {
      //     Console.WriteLine("The file you are trying to access does not exist.");
      // }
      //catch (NotSupportedException)
      //{
      //    Console.WriteLine("The stream you are trying to read from does not support the invoked functionality");
      //}
        //catch (SecurityException)
        //{
        //    Console.WriteLine("A security error occured converning the file.");
        //}
    }
}

