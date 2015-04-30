namespace Library
{
    using System.Collections.Generic;

    public abstract class ReadableItem : IReadable
    {
        private string name;
        private string publisher;
        private int year;
        private Genres genre;
        private Rating rating;
        private IEnumerable<Comment> comment;

        public ReadableItem(string name, string publisher, int year, Genres genre, Rating rating)
        {
            this.Name = name;
            this.Publisher = publisher;
            this.Year = year;
            this.Genre = genre;
            this.rating = rating;
            this.comment = new List<Comment>();
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Publisher
        {
            get { return this.publisher; }
            private set { this.publisher = value; }
        }

        public int Year
        {
            get { return this.year; }
            private set { this.year = value; }
        }

        public Genres Genre
        {
            get { return this.genre; }
            private set { this.genre = value; }
        }

        public Rating Rating
        {
            get { return this.rating; }
        }

        public IEnumerable<Comment> Comment
        {
            get 
            { 
                return new List<Comment>(this.comment); 
            }            
        }

        public override string ToString()
        {
            string result = string.Empty;

            result = string.Format("{0}|{1}|{2}|{3}|{4}", this.GetType().Name, this.name, this.publisher, this.year, this.genre) + this.rating.ToString();

            return result;
        }
        
    }
}
