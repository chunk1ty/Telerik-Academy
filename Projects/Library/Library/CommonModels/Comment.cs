namespace Library
{
    using System;

    public class Comment
    {
        public string Author { get; private set; }
        public DateTime PublishingDate { get; private set; }
        public string Text { get; private set; }

        public Comment(string author, string text)
        {
            this.Author = author;
            this.Text = text;
            this.PublishingDate = DateTime.Now;
        }
    }
}
