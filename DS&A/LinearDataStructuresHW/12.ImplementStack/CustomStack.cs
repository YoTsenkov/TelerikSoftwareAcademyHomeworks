namespace _12.ImplementStack
{
    using System;
    using System.Collections.Generic;
    using System.Collections;

    public class CustomStack<T>
    {
        private const int InitialSize = 16;
        private T[] data;        
        private int topIntex;

        public CustomStack()
            : this(InitialSize)
        {
        }

        public CustomStack(int capacity)
        {
            this.data = new T[capacity];            
            this.topIntex = capacity - 1;
        }

        public int Count
        {
            get
            {
                int count = this.data.Length - 1 - this.topIntex;
                return count;
            }
        }

        public void Push(T item)
        {
            if (this.topIntex < 0)
            {
                Resize();
            }

            this.data[this.topIntex] = item;
            this.topIntex--;
        }

        public T Pop()
        {
            if (this.topIntex == data.Length)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            T topElement = this.data[this.topIntex + 1];
            this.topIntex++;

            return topElement;
        }

        public T Peek()
        {
            T topElement = this.data[this.topIntex + 1];

            return topElement;
        }

        private T[] Resize()
        {
            T[] newData = new T[this.data.Length * 2];
            for (int i = this.data.Length - 1; i >= 0; i--)
            {
                newData[i + this.data.Length] = this.data[i];
            }

            this.topIntex = this.topIntex + this.data.Length;
            this.data = newData;

            return this.data;
        }
    }
}

