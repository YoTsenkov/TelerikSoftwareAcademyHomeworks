namespace _1.PriorityQueue
{
    using System;

    public class PriorityQueue<T> where T : IComparable<T>
    {

        private BinaryHeap<T> data;

        public PriorityQueue()
        {
            this.data = new BinaryHeap<T>();
        }

        public void Enqueue(T item)
        {
            data.Insert(item);
        }

        public T Dequeue()
        {
            return this.data.DeleteMin();
        }

        public T Peek()
        {
            return this.data[0];
        }

        public int Count()
        {
            return data.Count;
        }

        //sloppy implementation i know..its just for easier testing :)
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < data.Count; ++i)
                s += data[i].ToString() + " ";
            s += "count = " + data.Count;
            return s;
        }
    }
}
