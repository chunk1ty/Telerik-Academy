namespace PriorityQueueImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BinaryHeap<T> where T : IComparable<T>
    {
        const int INITIAL_CAPACITY = 16;

        private int nextIndex = 0;
        private bool isMinHeap;
        private T[] elements;

        public BinaryHeap(bool isMinHeap)
        {
            this.isMinHeap = isMinHeap;
            this.elements = new T[INITIAL_CAPACITY];
        }

        public void Add(T element)
        {
            this.CheckCapacity();

            this.elements[this.nextIndex] = element;

            this.ArrangeElementsOnAdd(this.nextIndex);

            this.nextIndex++;
        }

        public void DeleteFirst()
        {
            var swapper = this.elements[0];
            this.elements[0] = this.elements[this.nextIndex - 1];
            this.elements[this.nextIndex - 1] = swapper;

            this.nextIndex--;

            this.ArrangeElementsOnDelete(0);
        }

        public T First()
        {
            return this.elements[0];
        }

        private void ArrangeElementsOnAdd(int indexToCheck)
        {
            int parentIndex = (indexToCheck - 1) / 2;

            var parentValue = this.elements[parentIndex];
            var valueToCheck = this.elements[indexToCheck];

            var comparison = valueToCheck.CompareTo(parentValue);

            //compararer if default keeps a MAX HEAP by default
            //<0 means that the order is reversed
            if (this.isMinHeap ? comparison < 0 : comparison > 0)
	        {
                var swapper = this.elements[indexToCheck];
                this.elements[indexToCheck] = this.elements[parentIndex];
                this.elements[parentIndex] = swapper;

                this.ArrangeElementsOnAdd(parentIndex);                
            }
        }

        private void ArrangeElementsOnDelete(int indexToCheck)
        {
            var left = indexToCheck * 2 + 1;
            var right = left + 1;

            if (left < this.nextIndex)
            {
                var comparison = this.elements[indexToCheck].CompareTo(this.elements[left]);

                if (this.isMinHeap ? comparison > 0 : comparison < 0)
                {
                    var swapper = this.elements[indexToCheck];
                    this.elements[indexToCheck] = this.elements[left];
                    this.elements[left] = swapper;

                    this.ArrangeElementsOnDelete(left);
                }
                else if (right < this.nextIndex)
                {
                    comparison = this.elements[indexToCheck].CompareTo(this.elements[right]);
                    if (this.isMinHeap ? comparison > 0 : comparison < 0)
                    {
                        var swapper = this.elements[indexToCheck];
                        this.elements[indexToCheck] = this.elements[right];
                        this.elements[right] = swapper;

                        this.ArrangeElementsOnDelete(right);
                    }
                }

            }
        }

        private void CheckCapacity()
        {
            if (this.nextIndex == this.elements.Length)
            {
                var newElement = new T[INITIAL_CAPACITY * 2];

                for (int i = 0; i < this.elements.Length - 1; i++)
                {
                    newElement[i] = this.elements[i];
                }

                this.elements = newElement;
            }
        }

        public override string ToString()
        {
            return string.Join(", ", this.elements);
        }
    }
}
