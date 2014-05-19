using System;
using System.Linq;
using System.Collections;
using Deque;



namespace Core
{
    class Core
    {
        static void Main()
        {
            Deque<int> deque = new Deque<int>();


            deque.AddFront(6);
            deque.AddBack(5);
            deque.AddBack(7);
            deque.AddBack(8);
            Console.WriteLine(deque.Count); // 4
            Console.WriteLine(deque.Capacity); // 16                        
            deque.RemoveAt(8);
            Console.WriteLine(deque.Count); // 3
            deque.RemoveAt(7);
            Console.WriteLine(deque.Count); // 2
            deque.InsertAt(10, 9);
            Console.WriteLine(deque[10]); // 9
            Console.WriteLine(deque.Count); // 3

            deque.Clear();

            for (int i = 0; i < 20; i++)
            {
                deque.AddBack(i);
            }

            Console.WriteLine(deque.Capacity); // 32
            Console.WriteLine(deque.Count); // 20

            deque.Clear();

            Console.WriteLine(deque.Count); // 0
            Console.WriteLine(deque.Capacity); // 16
            Console.WriteLine(deque[7]); // 0
            deque[5] = 123;
            Console.WriteLine(deque[5]); // 123
        }

        //static T Max<T>(T[] data) where T : struct
        //{
        //
        //    if (data.Length == 0)
        //    {
        //        throw new InvalidOperationException("Invalid operation due to shortage of members");
        //    }
        //
        //    T max = data[0];
        //
        //    for (int i = 1; i < data.Length; i++)
        //    {
        //        if (data[i] > max)
        //        {
        //            max = data[i];
        //        }
        //    }
        //
        //    return max;
        //}
        //
        //static T Min<T>(T[] data) where T : struct
        //{
        //    if (data.Length == 0)
        //    {
        //        throw new InvalidOperationException("Invalid operation due to shortage of members");
        //    }            
        //
        //    T min = data[0];
        //
        //    for (int i = 1; i < data.Length; i++)
        //    {
        //        if (data[i] < min)
        //        {
        //            min = data[i];
        //        }
        //    }
        //
        //    return min;
        //}
    }
}
