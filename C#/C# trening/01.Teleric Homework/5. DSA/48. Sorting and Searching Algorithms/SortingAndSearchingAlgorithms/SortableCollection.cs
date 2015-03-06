namespace SortingAndSearchingAlgorithms
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            int minIndex = 0;
            int maxIndex = this.items.Count;

            while (maxIndex >= minIndex)
            {
                int middleIndex = (minIndex + maxIndex) / 2;

                if (this.items[middleIndex].CompareTo(item) < 0)
                {
                    minIndex = middleIndex + 1;
                }
                else if (this.items[middleIndex].CompareTo(item) > 0)
                {
                    maxIndex = middleIndex - 1;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public void Shuffle()
        {
            var itemsCount = this.Items.Count;

            for (var i = 0; i < itemsCount; i++)
            {
                int r = i + RandomProvider.Instance.Next(0, itemsCount - i);

                var temp = this.Items[i];
                this.Items[i] = this.Items[r];
                this.Items[r] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
