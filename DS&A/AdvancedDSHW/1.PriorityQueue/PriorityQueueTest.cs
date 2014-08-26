namespace _1.PriorityQueue
{
    using System;

    public class PriorityQueueTest
    {
        static void Main()
        {
            //binary heap test
            /*var heap = new BinaryHeap<int>();
            heap.Insert(5);
            heap.Insert(9);
            heap.Insert(11);
            heap.Insert(14);
            heap.Insert(18);
            heap.Insert(21);
            heap.Insert(33);
            heap.Insert(19);
            heap.Insert(27);
            heap.Insert(17);

            Console.WriteLine(heap.DeleteMin());
            Console.WriteLine(heap.DeleteMin());
            Console.WriteLine();*/

            var priorityQueue = new PriorityQueue<Student>();

            Student e1 = new Student("Aiden", 1.0);
            Student e2 = new Student("Baker", 2.0);
            Student e3 = new Student("Chung", 3.0);
            Student e4 = new Student("Dunne", 4.0);
            Student e5 = new Student("Eason", 5.0);
            Student e6 = new Student("Flynn", 6.0);

            Console.WriteLine("Adding " + e5.ToString() + " to priority queue");
            priorityQueue.Enqueue(e5);
            Console.WriteLine("Adding " + e3.ToString() + " to priority queue");
            priorityQueue.Enqueue(e3);
            Console.WriteLine("Adding " + e6.ToString() + " to priority queue");
            priorityQueue.Enqueue(e6);
            Console.WriteLine("Adding " + e4.ToString() + " to priority queue");
            priorityQueue.Enqueue(e4);
            Console.WriteLine("Adding " + e1.ToString() + " to priority queue");
            priorityQueue.Enqueue(e1);
            Console.WriteLine("Adding " + e2.ToString() + " to priority queue");
            priorityQueue.Enqueue(e2);

            Console.WriteLine("\nPriory queue is: ");
            Console.WriteLine(priorityQueue.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Removing an Student from priority queue");
            Student e = priorityQueue.Dequeue();
            Console.WriteLine("Removed Student is " + e.ToString());
            Console.WriteLine("\nPriory queue is now: ");
            Console.WriteLine(priorityQueue.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Removing a second Student from queue");
            e = priorityQueue.Dequeue();
            Console.WriteLine("\nPriory queue is now: ");
            Console.WriteLine(priorityQueue.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Testing the priority queue");
        }
    }
}
