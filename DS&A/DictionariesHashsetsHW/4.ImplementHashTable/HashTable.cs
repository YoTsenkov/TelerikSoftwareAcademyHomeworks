namespace _4.ImplementHashTable
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class HashTable<K, T> : IEnumerable<LinkedList<KeyValuePair<K, T>>>
    {
        private const int ArrayInitialCapacity = 16;
        private LinkedList<KeyValuePair<K, T>>[] data;
        private int count = 0;
        private int freeElements;

        public HashTable()
        {
            data = new LinkedList<KeyValuePair<K, T>>[ArrayInitialCapacity];
            this.freeElements = ArrayInitialCapacity;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(K key, T value)
        {
            if (this.freeElements < 0.25 * data.Length)
            {
                Resize();
            }

            int dataIndex = Math.Abs(key.GetHashCode()) % this.data.Length;
            var pair = new KeyValuePair<K, T>(key, value);
            if (this.data[dataIndex] == null)
            {
                this.data[dataIndex] = new LinkedList<KeyValuePair<K, T>>();
                this.freeElements--;
            }

            this.data[dataIndex].AddLast(pair);
            count++;
        }

        //I could not force the table to resize due to bad hash function i guess (doesnt seem to spread them well)
        //so u can make Resize() public and force resize it for testing. P.S. maybe i didnt add enough random bullshit ;D
        private void Resize()
        {
            LinkedList<KeyValuePair<K, T>>[] newData = new LinkedList<KeyValuePair<K, T>>[data.Length * 2];
            this.freeElements = newData.Length;
            foreach (var element in data)
            {
                if (element != null && element.Count > 0)
                {
                    foreach (var pair in element)
                    {
                        var newDataIndex = Math.Abs(pair.Key.GetHashCode()) % newData.Length;
                        if (newData[newDataIndex] == null)
                        {
                            newData[newDataIndex] = new LinkedList<KeyValuePair<K, T>>();
                            this.freeElements--;
                        }

                        newData[newDataIndex].AddLast(pair);
                    }
                }
            }

            
            this.data = newData;
        }

        public void Remove(K key)
        {
            int keyDataIndex = Math.Abs(key.GetHashCode()) % this.data.Length;
            foreach (var pair in this.data[keyDataIndex])
            {
                if (pair.Key.Equals(key))
                {
                    data[keyDataIndex].Remove(pair);
                    count--;
                    if (data[keyDataIndex].Count == 0)
                    {
                        freeElements++;
                    }

                    return;
                }
            }

            throw new KeyNotFoundException("Key was not found.");
        }

        public T Find(K key)
        {
            int keyDataIndex = Math.Abs(key.GetHashCode()) % this.data.Length;
            foreach (var pair in this.data[keyDataIndex])
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }

            throw new KeyNotFoundException("Key was not found.");
        }

        public void Clear()
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != null)
                {
                    data[i].Clear();
                };
            }

            this.count = 0;
        }

        public LinkedList<KeyValuePair<K, T>> this[int index]
        {
            get
            {
                return this.data[index];
            }

            set
            {
                this.data[index] = value;
            }
        }

        public IEnumerator<LinkedList<KeyValuePair<K, T>>> GetEnumerator()
        {
            foreach (var linkedList in data)
            {
                yield return linkedList;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
