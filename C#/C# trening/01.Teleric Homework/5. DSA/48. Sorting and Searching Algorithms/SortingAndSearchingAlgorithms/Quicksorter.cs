namespace SortingAndSearchingAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection.Count <= 1)
            {
                return;
            }
            var newCollection = this.QuickSort(collection);

            collection.Clear();

            for (int i = 0; i < newCollection.Count; i++)
            {
                collection.Add(newCollection[i]);
            }
        }

        private IList<T> QuickSort(IList<T> collection)
        {
            //bottom of recursion
            if (collection.Count <= 1)
            {
                return collection;
            }

            int pivotPosition = (collection.Count - 1) / 2;
            T pivotValue = collection[pivotPosition];
            collection.RemoveAt(pivotPosition);

            IList<T> lesser = new List<T>();
            IList<T> greater = new List<T>();

            for (int index = 0; index < collection.Count; index++)
            {
                if (collection[index].CompareTo(pivotValue) <= 0 )
                {
                    lesser.Add(collection[index]);
                }
                else
                {
                    greater.Add(collection[index]);
                }
            }

            lesser = this.QuickSort(lesser);
            greater = this.QuickSort(greater);

            List<T> answer = new List<T>();
            answer.AddRange(lesser);
            answer.Add(pivotValue);
            answer.AddRange(greater);

            return answer;
        }
    }
}
