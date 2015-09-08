namespace GenericListNamespace
{
    using System;
    using System.Linq;
    using System.Text;
    public class GenericList <T>
    {
        //Fields
        const int DEFAULT_CAPACITY = 8;
        private T[] array;
        private int count;

        //Constructors
        public GenericList() : this(DEFAULT_CAPACITY)
        {

        }
        public GenericList(int capacity)
        {
            array = new T[capacity];
        }

        //Propertie
        public int Count 
        {
            get { return this.count; } 
        }
        public T this[int index]
        {
            get
            {
                return this.array[index];
            }
            set
            {
                this.array[index] = value;
            }
        }       //Indexer

        //Methods
        public void AddElement(T element)
        {
            if (this.Count == this.array.Length)
            {
                Resize();
            }
            this.array[count] = element;
            count++;
        }        
        public void RemoveElementAt(int index)
        {
            if (index >= 0 && index <= this.Count)
            {
                T[] tempArray = new T[array.Length];

                for (int startIndex = 0; startIndex < index ; startIndex++)
                {
                    tempArray[startIndex] = this.array[startIndex];
                }

                int nextIndex = index;
                for (int endIndex = index + 1; endIndex < this.array.Length; endIndex++)
                {
                    tempArray[nextIndex] = this.array[endIndex];
                    nextIndex++;
                }
                Array.Copy(tempArray, 0, this.array, 0, this.array.Length);
                this.count--;
            }
            else
            {
                throw new IndexOutOfRangeException("The index is out of range !");
            }
        }
        public void InsertAt(int position, T item)
        {            
            this.count++;
            if (this.count >= this.array.Length)
            {
                Resize();
            }            
            Array.Copy(this.array, position, this.array, position + 1, this.array.Length - position -1);
            this.array[position] = item;
            
        }
        public void Clear ()
        {
            this.array = new T[DEFAULT_CAPACITY];
            this.count = 0;
        }
        public int FindElement(T value)
        {
            int index = Array.BinarySearch(this.array, value);
            //int index = Array.IndexOf(this.array, value); 
            return index;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.array.Length; i++)
            {
                sb.Append(this.array[i] + ", ");
            }
            return sb.ToString();
        }
        private void Resize()
        {
            T[] tempArray = new T[this.array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            this.array = tempArray;
        }
     

        //min and max don't work corect
        public T Min<T> () where T : IComparable<T>,IComparable  
        {           
            return (dynamic)array.Min();
        }
        public T Max<T>() where T : IComparable<T>, IComparable
        {
            return (dynamic)array.Max();
        }
    }
}
