namespace StackImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyStack<T> : IEnumerable<T>
    {
        private const int INITIAL_SIZE = 16;

        private T[] elements = null;
        private int pointer = 0;
        
        public MyStack() : this(INITIAL_SIZE) { }

        public MyStack(int initialSize)
        {
            this.elements = new T[initialSize];
            this.pointer = 0;
        }

        public int Count
        {
            get
            {
                return this.pointer;
            }
        }

        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }
        }

        public void Push(T element)
        {
            if (this.elements.Length == this.pointer)
            {
                this.ResizeInnerArray();
            }

            elements[pointer] = element;
            pointer++;
        }

        public T Peek()
        {
            if (this.pointer <= 0)
            {
                throw new ArgumentNullException("The MyStack is empty!");
            }

            T value = this.elements[this.pointer - 1];

            return value;
        }
        
        public T Pop()
        {
            T value = this.Peek();
            this.pointer--;
            return value;
        }

        private void ResizeInnerArray()
        {
            T[] temp = new T[elements.Length * 2];

            for (int index = 0; index < elements.Length; index++)
            {
                temp[index] = elements[index];
            }

            this.elements = temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
