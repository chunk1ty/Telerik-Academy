namespace BiDictionaryTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    public class BiDictionary<K1, K2, V>
    {
        private MultiDictionary<K1, V> firstDictionary = null;
        private MultiDictionary<K2, V> secondDictionary = null;
        private MultiDictionary<Tuple<K1, K2>, V> bothDictionaries = null;
        private int count;
        
        public BiDictionary()
        {
            firstDictionary = new MultiDictionary<K1, V>(true);
            secondDictionary = new MultiDictionary<K2, V>(true);
            bothDictionaries = new MultiDictionary<Tuple<K1, K2>, V>(true);
        }

        public int Count 
        { 
            get
            {
                return this.count;
            }
        }

        public void Add(K1 firtsKey, K2 secondKey, V value)
        {
            this.firstDictionary.Add(firtsKey, value);
            this.secondDictionary.Add(secondKey, value);
            this.bothDictionaries.Add(new Tuple<K1, K2>(firtsKey, secondKey), value);
            this.count++;
        }

        public ICollection<V> FindByFirstKey(K1 key)
        {
            return this.firstDictionary[key];
        }

        public ICollection<V> FindBySecondKey(K2 key)
        {
            return this.secondDictionary[key];
        }

        public ICollection<V> FindByBothKeys(K1 firstKey, K2 secondKey)
        {
            return this.bothDictionaries[new Tuple<K1, K2>(firstKey, secondKey)];
        }

        public void RemoveByBothKeys(K1 firstKey, K2 secondKey)
        {
            var index = new Tuple<K1, K2>(firstKey, secondKey);
            var entries = this.bothDictionaries[index];

            foreach (var entry in entries)
            {
                this.firstDictionary.Remove(firstKey, entry);
                this.secondDictionary.Remove(secondKey, entry);
            }

            this.bothDictionaries.Remove(index);
            this.count--;
        }
    }
}
