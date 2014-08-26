namespace _1.PriorityQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BinaryHeap<T> : IEnumerable<T> where T : IComparable<T>
    {
        private IList<T> heapList;
        private int currentSize = 0;

        public BinaryHeap()
        {
            this.heapList = new List<T>();
        }

        public int Count 
        {
            get
            {
                return this.currentSize;
            }
        }

        public void Insert(T value)
        {
            this.heapList.Add(value);
            this.PercUp(this.currentSize);
            this.currentSize++;
        }

        public T DeleteMin()
        {
            T deletedElement = this.heapList[0];
            this.heapList[0] = this.heapList[this.currentSize - 1];
            this.currentSize--;
            this.heapList.RemoveAt(this.currentSize);
            this.PercDown(0);

            return deletedElement;
        }

        private void PercUp(int elementIndex)
        {
            int parentIndex = (elementIndex - 1) / 2;
            while (parentIndex >= 0)
            {
                int initialIndex = (elementIndex - 1) / 2;             
                if (this.heapList[elementIndex].CompareTo(this.heapList[parentIndex]) < 0)
                {
                    T exParent = this.heapList[parentIndex];
                    this.heapList[parentIndex] = this.heapList[elementIndex];
                    this.heapList[elementIndex] = exParent;
                    elementIndex = parentIndex;
                    parentIndex = (elementIndex - 1) / 2;
                    if (initialIndex == 0 && elementIndex == 0)
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private int MinChild(int elementIndex)
        {
            if (elementIndex * 2 + 2 > this.currentSize - 1)
            {
                return elementIndex * 2 + 1;
            }
            else
            {
                if (this.heapList[elementIndex * 2 + 1].CompareTo(this.heapList[elementIndex * 2 + 2]) < 0)
                {
                    return elementIndex * 2 + 1;
                }
                else
                {
                    return elementIndex * 2 + 2;
                }
            }
        }

        private void PercDown(int elementIndex)
        {
            while (elementIndex * 2 + 1 < this.currentSize)
            {
                int minChildIndex = this.MinChild(elementIndex);
                if (this.heapList[elementIndex].CompareTo(this.heapList[minChildIndex]) > 0)
                {
                    T exParent = this.heapList[elementIndex];
                    this.heapList[elementIndex] = this.heapList[minChildIndex];
                    this.heapList[minChildIndex] = exParent;
                    elementIndex = minChildIndex;
                }
                else
                {
                    return;
                }
            }
        }

        public T this[int index]
        {
            get
            {
                return this.heapList[index];
            }

            set
            {
                this.heapList[index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.heapList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
