namespace SortingAndSearchingAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BubbleSort<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            //Optimized
            //bool swapped = true;

            //while (swapped)
            //{
            //    swapped = false;
            //    for (int i = 0; i < collection.Count - 1; i++)
            //    {
            //        if (collection[i].CompareTo(collection[i + 1]) == 1)
            //        {
            //            swapped = true;
            //            T temp = collection[i];
            //            collection[i] = collection[i + 1];
            //            collection[i + 1] = temp;
            //        }
            //    }
            //}

            for (int i = 1; i < collection.Count; i++)
            {
                for (int j = 0; j < collection.Count - i; j++)
                {
                    if (collection[j].CompareTo(collection[j + 1]) == 1)
                    {
                        T temp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = temp;
                    }
                }
            }
        }        
    }
}
