namespace Library
{
    using UserInterface.Interfaces;

    public class Book : ReadableItem, IBook, IReadable
    {
        private string author;

        public Book(string name, string publisher, int year, Genres genre, Rating rating, string author) 
            : base(name, publisher, year, genre, rating)
        {
            this.Author = author;
        }   

        public string Author
        {
            get { return this.author; }
            private set { this.author = value; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("|{0}", this.author);
        }
    }
}
