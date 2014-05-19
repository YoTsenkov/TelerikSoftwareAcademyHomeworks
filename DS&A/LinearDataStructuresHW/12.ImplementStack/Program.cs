using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace _12.ImplementStack
{
    class Program
    {
        static void Main(string[] args)
        {                                  
            CustomStack<int> stackz = new CustomStack<int>();

            //Console.WriteLine(stackz.Count);
            //stackz.Push(15);
            //stackz.Push(-56);
            //Console.WriteLine(stackz.Count);
            //Console.WriteLine(stackz.Pop());
            //Console.WriteLine(stackz.Count);
            //stackz.Push(999);
            //Console.WriteLine(stackz.Peek());
            
            for (int i = 0; i < 50; i++)
            {
                stackz.Push(i);
            }

            Console.WriteLine(stackz.Count);

            
        }
    }
}
