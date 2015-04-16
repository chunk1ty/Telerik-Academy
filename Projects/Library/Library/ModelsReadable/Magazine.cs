namespace Library
{
    using UserInterface.Interfaces;

    public class Magazine : ReadableItem, IMagazine, IReadable
    {
        private string issue;

        public Magazine(string name, string publisher, int year, Genres genre, Rating rating, string issue)
            : base(name, publisher, year, genre, rating)
        {
            this.Issue = issue;        
        }

        public string Issue
        {
            get { return this.issue; }
            private set { this.issue = value; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("|{0}", this.issue);
        }
    }
}
