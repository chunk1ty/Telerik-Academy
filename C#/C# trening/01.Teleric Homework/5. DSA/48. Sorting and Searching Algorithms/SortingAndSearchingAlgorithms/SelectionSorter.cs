namespace SortingAndSearchingAlgorithms
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            int iMin = 0;
            for (int i = 0; i < collection.Count - 1; i++)
            {
                iMin = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[iMin]) == -1)
                    {
                        iMin = j;
                    }
                }

                if (iMin != i)
                {
                    T temp = collection[i];
                    collection[i] = collection[iMin];
                    collection[iMin] = temp;
                }
            }
        }
    }
}
