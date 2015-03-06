namespace PhoneBookTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PhoneBookEntry
    {
        private string name;
        private string town;
        private string phone;

        public PhoneBookEntry(string name, string town, string phone)
        {
            this.Name = name;
            this.Town = town;
            this.Phone = phone;
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can not be null or empty");
                }

                this.name = value;
            }
        }

        public string Town 
        { 
            get
            {
                return this.town;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The town can not be null or empty");
                }

                this.town = value;
            }
        }

        public string Phone 
        { 
            get
            {
                return this.phone;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The phone number can not be null or empty");
                }

                this.phone = value;
            }
        }

        public override string ToString()
        {
            return string.Format(this.name.PadLeft(17) + "|" + this.town.PadLeft(17) + "|" + this.phone.PadLeft(17));
        }
    }
}
