namespace SortingAndSearchingAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HeapSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            //Build-Max-Heap
            int heapSize = collection.Count;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                MaxHeapify(collection, heapSize, p);

            for (int i = collection.Count - 1; i > 0; i--)
            {
                //Swap
                T temp = collection[i];
                collection[i] = collection[0];
                collection[0] = temp;

                heapSize--;
                MaxHeapify(collection, heapSize, 0);
            }
        }

        private void MaxHeapify(IList<T> input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && (input[left].CompareTo(input[index]) > 0))
                largest = left;
            else
                largest = index;

            if (right < heapSize && (input[right].CompareTo(input[largest]) > 0 ))
                largest = right;

            if (largest != index)
            {
                T temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;

                MaxHeapify(input, heapSize, largest);
            }
        }
    }
}
