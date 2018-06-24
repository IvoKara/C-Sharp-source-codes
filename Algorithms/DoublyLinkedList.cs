using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Node<T>
    {
        public T Value { get; private set; }
        public Node<T> PrevNode { get; set; }
        public Node<T> NextNode { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }
    }

    class DoublyLinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index >= this.Count || index < 0)
                    throw new IndexOutOfRangeException("Index is outside the bound of the List");
                if (index == this.Count - 1)
                    return tail.Value;
                return GetNode(index).Value;
            }
            set
            {
                if (index >= this.Count || index < 0)
                    throw new IndexOutOfRangeException();
                Insert(value, index);
                RemoveAt(index + 1);
            }
        }

        private Node<T> GetNode(int index)
        {
            int mid = (this.Count - 1) / 2;
            Node<T> temp;
            if (index <= mid)
            {
                temp = head;
                int cuurentIndex = 0;
                while (cuurentIndex < index)
                {
                    temp = temp.NextNode;
                    cuurentIndex++;
                }
            }
            else
            {
                temp = tail;
                int cuurentIndex = this.Count - 1;
                while (cuurentIndex > index)
                {
                    temp = temp.PrevNode;
                    cuurentIndex--;
                }
            }
            return temp;
        }

        public void Append(T item)
        {
            if (this.Count == 0)
            {
                AddFirst(item);
            }
            else
            {
                Node<T> addNode = new Node<T>(item);
                addNode.PrevNode = this.tail;
                this.tail.NextNode = addNode;
                this.tail = addNode;
            }
            this.Count++;
        }

        private void AddFirst(T item)
        {
            if (this.Count == 0)
            {
                head = tail = new Node<T>(item);
            }
            else
            {
                Node<T> temp = new Node<T>(item);
                temp.NextNode = this.head;
                this.head.PrevNode = temp;
                this.head = temp;
            }
        }

        public void Insert(T item, int index)
        {
            try
            {
                if (index == 0)
                {
                    AddFirst(item);
                }
                else
                {
                    Node<T> newNode = new Node<T>(item);
                    Node<T> currentNode = GetNode(index);
                    currentNode.PrevNode.NextNode = newNode;
                    newNode.PrevNode = currentNode.PrevNode;
                    currentNode.PrevNode = newNode;
                    newNode.NextNode = currentNode;
                }
                this.Count++;
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException("Index is outside the bound of the List");
            }
        }

        private T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }
            T firstElement = head.Value;
            head = head.NextNode;
            if (head != null)
            {
                head.PrevNode = null;
            }
            else
            {
                this.tail = null;
            }
            this.Count--;
            return firstElement;
        }

        private T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }
            T lastElement = tail.Value;
            this.tail = tail.PrevNode;
            if (tail != null)
            {
                tail.NextNode = null;
            }
            else
            {
                head = null;
            }
            this.Count--;
            return lastElement;
        }

        public T RemoveAt(int index)
        {
            if (index == 0)
            {
                return RemoveFirst();
            }
            else if (index == this.Count - 1)
            {
                return RemoveLast();
            }
            else
            {
                Node<T> currentNode = GetNode(index);
                currentNode.PrevNode.NextNode = currentNode.NextNode;
                currentNode.NextNode.PrevNode = currentNode.PrevNode;
                this.Count--;
                return currentNode.Value;
            }
        }

       public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            for(int i = 0; i < this.Count; i++)
            {
                arr[i] = this[i];
            }
            return arr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> temp = head;
            while (temp != tail)
            {
                yield return temp.Value;
                temp = temp.NextNode;
            }
            yield return tail.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
