using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class ReversedList<T>: IEnumerable<T>
    {
                
        private T[] reversedList;
        private Func<T, T> keySelector;
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index >= this.Count || index < 0)
                    throw new IndexOutOfRangeException();
                return reversedList[index];
            }
            set
            {
                if (index >= this.Count || index < 0)
                    throw new IndexOutOfRangeException();
                reversedList[index] = value;
            }
        }

        public ReversedList(int capacity, Func<T, T> keySelector)
        {
            reversedList = new T[capacity];
            this.Capacity = capacity;
            this.Count = 0;
            this.keySelector = keySelector;
        }
        public ReversedList() : this(2, x => x) { }

        public void Add(T item)
        {
            
            if(this.Count == Capacity)
            {
                Grow();
            }
            reversedList[this.Count++] = item;
            if (this.Count > 1)
            {
                reversedList = reversedList.OrderByDescending(this.keySelector).ToArray();
            }
        }

        private void Grow()
        {
            T[] copy = new T[this.Capacity * 2];
            for (int i = 0; i < this.Capacity; i++)
            {
                copy[i] = reversedList[i];
            }
            this.Capacity *= 2;
            reversedList = copy;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < this.Count; i++)
            {
                yield return reversedList[i];
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
