namespace MegaCollections
{
    using System;

    [Author("Ivaylo Kenov")]
    public class Deque<T>
    {
        private const int InitialSize = 16;

        private T[] data;
        private int frontIndex;
        private int backIndex;

        public Deque()
            : this(InitialSize)
        {
        }

        public Deque(uint initialSize)
        {
            if (initialSize < 2)
            {
                throw new IndexOutOfRangeException("Initial size of Deque must be bigger than 2");
            }

            this.data = new T[initialSize];
            this.frontIndex = this.Capacity / 2 - 1;
            this.backIndex = this.Capacity / 2;
        }

        public int Count
        {
            get
            {
                return this.backIndex - this.frontIndex - 1;
            }
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public void AddFront(T element)
        {
            if (this.frontIndex < 0)
            {
                this.ResizeData();
            }

            this.data[this.frontIndex] = element;
            this.frontIndex--;
        }

        public void AddBack(T element)
        {
            if (this.backIndex == this.Capacity)
            {
                this.ResizeData();
            }

            this.data[this.backIndex] = element;
            this.backIndex++;
        }

        public T RemoveBack()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            this.backIndex--;
            return this.data[backIndex];
        }

        public T RemoveFront()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            this.frontIndex++;
            return this.data[frontIndex];
        }

        public T PeekFront()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            return this.data[frontIndex + 1];
        }

        public T PeekBack()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            return this.data[backIndex - 1];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                return this.data[this.frontIndex + index + 1];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                this.data[this.frontIndex + index + 1] = value;
            }
        }

        public static Deque<T> operator +(Deque<T> first, Deque<T> second)
        {
            Deque<T> result = new Deque<T>();

            for (int i = 0; i < first.Count; i++)
            {
                result.AddBack(first[i]);
            }

            for (int i = 0; i < second.Count; i++)
            {
                result.AddBack(second[i]);
            }

            return result;
        }

        private void ResizeData()
        {
            int newSize = this.Capacity * 2;
            T[] newData = new T[newSize];

            int currentFrontIndex = this.Capacity / 2 - 1;
            int currentBackIndex = this.Capacity / 2;

            int newFrontIndex = newSize / 2 - 1;
            int newBackIndex = newSize / 2;

            while (true)
            {
                if (currentFrontIndex <= this.frontIndex
                    && currentBackIndex >= this.backIndex)
                {
                    break;
                }

                if (currentFrontIndex > this.frontIndex)
                {
                    newData[newFrontIndex] = this.data[currentFrontIndex];
                    newFrontIndex--;
                }

                if (currentBackIndex < this.backIndex)
                {
                    newData[newBackIndex] = this.data[currentBackIndex];
                    newBackIndex++;
                }

                currentBackIndex++;
                currentFrontIndex--;
            }

            this.data = newData;
            this.frontIndex = newFrontIndex;
            this.backIndex = newBackIndex;
        }
    }
}
