namespace ADTStack
{
    using System;

    public class MyStack<T>
    {
        private T[] stackStorage;
        public int Count { get; private set; }

        public MyStack()
        {
            this.stackStorage = new T[4];
            this.Count = 0;
        }

        public void Push(T value)
        {
            if (this.Count == this.stackStorage.Length)
            {
                Resize();
            }

            this.stackStorage[this.Count] = value;
            this.Count += 1;
        }

        public void Pop()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("Stack is empty");
            }

            T[] currentStorage = new T[this.stackStorage.Length];
            Array.Copy(stackStorage, currentStorage, this.Count - 1);
            this.stackStorage = currentStorage;
            this.Count -= 1;
        }

        //public int Peek()
        //{
        //    return this.stackStorage[this.Count - 1];
        //}

        public void Clear()
        {
            this.stackStorage = new T[4];
            this.Count = 0;
        }

        public void TrimExcess()
        {
            T[] newStorage = new T[this.Count];
            for (int i = 0; i < newStorage.Length; i++)
            {
                newStorage[i] = this.stackStorage[i];
            }

            stackStorage = newStorage;
        }

        private void Resize()
        {
            T[] newStorage = new T[this.stackStorage.Length * 2];

            for (int i = 0; i < stackStorage.Length; i++)
            {
                newStorage[i] = this.stackStorage[i];
            }

            this.stackStorage = newStorage;
        }
    }
}
