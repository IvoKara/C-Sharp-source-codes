using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class CircularQueue<T>
    {
        static private T[] elements;
        public int startIndex { get; private set; }
        public int endIndex { get; private set; }
        public int Count { get; private set; }

       Func<int,int> next = index => (index + 1) % elements.Length;

        public CircularQueue(int DefaultCapacity = 16, int startIndex = 0)
        {
            elements = new T[DefaultCapacity];           
            this.startIndex = startIndex;
            endIndex = startIndex;
            Count = 0;
        }

        public T Top()
        {
            return elements[startIndex];
        }

        public void Enqueue(T element)
        {           
            if (Count >= elements.Length)
            {
                Grow();
            }
            elements[endIndex] = element;
            endIndex = next(endIndex);
            Count++;
        }

        private void CopyAllElementsTo(T[] dest)
        {
            int newIndex = startIndex;
            for (int i = 0; i < Count; i++)
            {
                dest[i] = elements[newIndex];
                newIndex = next(newIndex);
            }
        }

        private void Grow()
        {
            T[] copy = new T[Count*2];
            CopyAllElementsTo(copy);
            startIndex = 0;
            endIndex = this.Count;
            elements = copy;
        }
        public T Dequeue()
        {
            int index = startIndex;
            startIndex = next(startIndex);
            Count--;
            return elements[index];
        }
        
        public T[] ToArray()
        {
            T[] copy = new T[Count];
            CopyAllElementsTo(copy);
            return copy;
        }
    }
}
