namespace PhoneBookTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class PhoneBook
    {
        private const string phoneEntryNotFound = "No such phone entry found!";

        private Dictionary<string, List<PhoneBookEntry>> entries;
        private Dictionary<string, HashSet<string>> names;

        public PhoneBook()
        {
            this.entries = new Dictionary<string, List<PhoneBookEntry>>();
            this.names = new Dictionary<string, HashSet<string>>();
        }

        public void Add(string name, string town, string phone)
        {
            var entry = new PhoneBookEntry(name, town, phone);

            if (this.entries.ContainsKey(name))
            {
                this.entries[name].Add(entry);
            }
            else
            {
                this.entries.Add(name, new List<PhoneBookEntry>() { entry });
            }

            string[] namesToken = name.Split();

            foreach (var subname in namesToken)
            {
                if (this.names.ContainsKey(subname))
                {
                    this.names[subname].Add(name);
                }
                else
                {
                    this.names.Add(subname, new HashSet<string>() { name });
                }
            }
        }

        public string Find(string subname)
        {
            return this.FindInner(subname, x => true);
        }

        public string Find(string subname, string town)
        {
            return this.FindInner(subname, x => x.Town == town);
        }

        private string FindInner(string subname, Func<PhoneBookEntry, bool> funct)
        {
            if (!this.names.ContainsKey(subname))
            {
                return phoneEntryNotFound;
            }

            StringBuilder sb = new StringBuilder();

            foreach (var fullname in this.names[subname])
            {
                foreach (var entry in this.entries[fullname])
                {
                    if (funct(entry))
                    {
                        sb.AppendLine(entry.ToString());
                    }
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
