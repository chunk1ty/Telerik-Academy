namespace IEnumerableExtensionMethods
{    
    using System.Collections.Generic;
    public static class EnumerableExtension
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            T sum = default(T);
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> collection)
        {
            T sum = (dynamic)1;
            foreach (var item in collection)
            {
                sum *= (dynamic)item;
            }
            return sum;
        }
        public static T Min<T>(this IEnumerable<T> collection)
        {
            T min = default(T);
            bool firstValue = true;
            foreach (var item in collection)
            {
                if (firstValue)
                {
                    min = item;
                    firstValue = false;
                }
                else
                {
                    if (Comparer<T>.Default.Compare(item,min)<0)
                    {
                        min = item;
                    }
                }
                
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> collection)
        {
            T max = default(T);
            bool firstValue = true;
            foreach (var item in collection)
            {
                if (firstValue)
                {
                    max = item;
                    firstValue = false;
                }
                else
                {
                    if (Comparer<T>.Default.Compare(item, max) > 0)
                    {
                        max = item;
                    }
                }

            }
            return max;
        }
        public static T Average<T>(this IEnumerable<T> collection)
        {
            T sum = default(T);
            int count = 0;
            foreach (var item in collection)
            {
                sum += (dynamic)item;
                count++;
            }

            return (dynamic)sum / count;
        }
    }
}
