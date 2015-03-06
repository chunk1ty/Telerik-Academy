namespace HumanProject
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;
        public Human (string name,string nameLast)
        {
            this.FirstName = name;
            this.LastName = nameLast;
        }
        public string FirstName 
        { 
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
