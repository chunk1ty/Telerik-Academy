namespace SortingAndSearchingAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InsertionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int i = 1; i < collection.Count; i++)
            {
                T valueToInsert = collection[i];
                int holePosition = i;               

                while (holePosition > 0 && (valueToInsert.CompareTo(collection[holePosition - 1]) <= 0))
                {                   
                    collection[holePosition] = collection[holePosition - 1];
                    holePosition--;
                    
                }

                collection[holePosition] = valueToInsert;
            }
        }
    }
}
