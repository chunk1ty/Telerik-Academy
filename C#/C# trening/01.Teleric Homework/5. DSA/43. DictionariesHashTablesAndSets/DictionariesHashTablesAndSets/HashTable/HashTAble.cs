namespace HashTable
{
    using System;
    using System.Collections.Generic;    
    using System.Text;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// HashTable collection develop by Ankk
    /// </summary>
    /// <typeparam name="K">The type of keys</typeparam>
    /// <typeparam name="T">The type of values</typeparam>
    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private const string CapacityZeroOrNegative = "Initial HashTable size can not be less than or equal to 0!";
        private const int InitialCapacity = 16;
        private const double LoadFactor = 0.75;

        private LinkedList<KeyValuePair<K, T>>[] buckets;
        private int occupiedBucketsCounter;
        private int elementsCounter;

        #region Constructors
        public HashTable() : this(InitialCapacity) { }

        public HashTable(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException(CapacityZeroOrNegative);
            }

            this.buckets = new LinkedList<KeyValuePair<K, T>>[capacity];
            this.occupiedBucketsCounter = 0;
            this.elementsCounter = 0;
        }

        public HashTable(int capacity, HashTable<K,T> hashTable) : this(capacity)
        {
            foreach (var pair in hashTable)
            {
                this.Add(pair.Key, pair.Value);
            }
        }
        #endregion

        public void Add(K key, T value)
        {
            this.CheckAndGrow();

            var elementToAdd = new KeyValuePair<K, T>(key, value);
            int position = GetPosition(key);

            if (this.buckets[position] == null)
            {
                this.buckets[position] = new LinkedList<KeyValuePair<K, T>>();
                this.buckets[position].AddFirst(elementToAdd);
                this.occupiedBucketsCounter++;
            }
            else
            {
                this.Remove(key);

                if (this.buckets[position].Count == 0)
                {
                    this.occupiedBucketsCounter++;
                }

                this.buckets[position].AddLast(elementToAdd);
            }

            this.elementsCounter++;
        }

        public bool Find(K key, out T value)
        {
            int position = GetPosition(key);

            if (this.buckets[position] != null && this.buckets[position].Count != 0)
            {
                foreach (var pair in this.buckets[position])
                {
                    if (pair.Key.Equals(key))
                    {
                        value = pair.Value;
                        return true;
                    }
                }
            }

            value = default(T);
            return false;
        }

        public void Remove(K key)
        {
            int position = this.GetPosition(key);

            if (this.buckets[position] != null && this.buckets[position].Count != 0)
            {
                T valueToRemove;

                if (Find(key, out valueToRemove))
                {
                    var nodeToRemove = this.buckets[position].First(x => x.Key.Equals(key));

                    this.buckets[position].Remove(nodeToRemove);

                    this.elementsCounter--;

                    if (this.buckets[position].Count == 0)
                    {
                        this.occupiedBucketsCounter--;
                    }
                }
            }
        }

        private void CheckAndGrow()
        {
            if (this.occupiedBucketsCounter >= this.buckets.Length * LoadFactor)
            {
                var newHashTable = new HashTable<K, T>(this.buckets.Length * 2);

                foreach (var pair in this)
                {
                    newHashTable.Add(pair.Key, pair.Value);
                }

                this.buckets = newHashTable.buckets;
            }
        }

        private int GetPosition(K key)
        {
            int position = key.GetHashCode() % this.buckets.Length;
            if (position < 0)
            {
                position = position * (-1);
            }

            return position;
        }

        public void Clear()
        {
            this.buckets = new LinkedList<KeyValuePair<K, T>>[this.buckets.Length];
            this.occupiedBucketsCounter = 0;
            this.elementsCounter = 0;
        }

        public T this[K key]
        {
            get
            {
                T valueToReturn = default(T);

                this.Find(key, out valueToReturn);

                return valueToReturn;
            }

            set
            {
                this.Add(key, value);
            }
        }

        /// <summary>
        /// The number of elements in the JHash Table
        /// </summary>
        /// <returns><typeparamref name="int"/>The total elements in the JHash Table</returns>
        public int Count
        {
            get
            {
                return this.elementsCounter;
            }
        }

        /// <summary>
        /// A collection of all the keys in the JHash Table
        /// </summary>
        /// <returns>An array of <typeparamref name="K"/> elements</returns>
        public K[] Keys
        {
            get
            {
                var listOfKeys = new List<K>(this.elementsCounter);

                foreach (var pair in this)
                {
                    listOfKeys.Add(pair.Key);
                }

                return listOfKeys.ToArray();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var pair in this)
            {
                sb.AppendFormat("({0}->{1}) ; ", pair.Key, pair.Value);
            }

            return sb.ToString().TrimEnd(new char[] { ';', ' ' });
        }


        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var list in this.buckets)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                    {
                        yield return pair;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private int GetBucketPosition(K key)
        {
            var position = key.GetHashCode() % this.buckets.Length;

            if (position < 0)
            {
                position = position * (-1);
            }

            return position;
        }
    }
}
