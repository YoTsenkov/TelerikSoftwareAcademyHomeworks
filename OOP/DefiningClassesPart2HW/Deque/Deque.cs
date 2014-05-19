
namespace Deque
{
    using System;
    public class Deque<T>
    {
        private T[] data;
        const uint InitialSize = 16;
        private int frontIndex;
        private int backIndex;
        //private int halfNumberOfEmptyPositions;

        public Deque()
            : this(InitialSize)
        {
        }
        public Deque(uint initialSize)
        {
            if (initialSize < 2)
            {
                throw new IndexOutOfRangeException("Deque must have size bigger than 2");
            }

            this.data = new T[initialSize];
            frontIndex = data.Length / 2 - 1;
            backIndex = data.Length / 2;

        }
        public void AddFront(T element)
        {
            if (frontIndex < 0)
            {
                //if (backIndex <= Capacity)
                //{
                //    for (int i = (Capacity - 1) - (Capacity - backIndex) / 2; i > frontIndex + 1 + (Capacity - backIndex) / 2; i--)
                //    {
                //        this.data[i] = this.data[ ;
                //    }
                //}

                Resize();
            }

            this.data[frontIndex] = element;
            frontIndex--;
        }

        public void AddBack(T element)
        {
            if (backIndex >= Capacity)
            {
                Resize();
            }

            this.data[backIndex] = element;
            backIndex++;

        }

        public void RemoveAt(int index)
        {
            if (index <= frontIndex || index >= backIndex)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            for (int i = index; i < backIndex - 2; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            backIndex--;
        }

        public void InsertAt(int index, T value)
        {
            if (index < 0 || index >= Capacity)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }
            else if (Count == Capacity)
            {
                Resize();

                for (int i = backIndex; i > index; i--)
                {
                    this.data[i] = this.data[i - 1];
                    backIndex++;
                }
            }

            for (int i = backIndex; i > index; i--)
            {
                this.data[i] = this.data[i - 1];
            }

            backIndex++;
            this.data[index] = value;
        }

        public void Clear()
        {
            this.data = new T[InitialSize];
            frontIndex = data.Length / 2 - 1;
            backIndex = data.Length / 2;
        }

        public int Capacity
        {
            get
            {
                return data.Length;
            }
        }

        public int Count
        {
            get
            {
                return backIndex - frontIndex - 1;
            }
        }

        public T this[int index]
        {
            get
            {
                //if (index < 0 || index >= this.Count)
                //{
                //    throw new IndexOutOfRangeException("Index is out of range");
                //}

                return this.data[index];
            }

            set
            {
                //if (index < 0 || index >= this.Count)
                //{
                //    throw new IndexOutOfRangeException("Index is out of range");
                //}

                //this.data[this.frontIndex + index + 1] = value;
                this.data[index] = value;
            }
        }       
        private T[] Resize()
        {
            T[] newData = new T[Capacity * 2];

            data.CopyTo(newData, newData.Length / 4);
            this.frontIndex = newData.Length / 4 - 1;
            this.backIndex = newData.Length / 4 + Count;
            this.data = newData;

            return this.data;
        }

    }
}
