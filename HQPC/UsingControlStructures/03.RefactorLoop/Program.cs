using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RefactorLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            const int expectedValue = 50; //whatever value
            const int elementsCount = 100;
            int[] array = new int[];
            
            for (int i = 0; i < elementsCount; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0 && array[i] == expectedValue)
                {
                     Console.WriteLine("Value Found");
                     break;                  
                }                
            }
            // More code here           
        }
    }
}
