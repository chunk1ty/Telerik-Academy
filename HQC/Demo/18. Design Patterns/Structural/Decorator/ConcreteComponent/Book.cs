using System;

namespace Decorator.ConcreteComponent
{
    /// <summary>
    /// The 'ConcreteComponent' class - defines an object to which additional responsibilities can be attached.
    /// </summary>
    internal class Book : LibraryItem
    {
        private readonly string author;
        private readonly string title;

        public Book(string author, string title, int copiesCount)
        {
            this.author = author;
            this.title = title;
            this.CopiesCount = copiesCount;
        }

        public override void Display()
        {
            Console.WriteLine("Book ------ ");
            Console.WriteLine(" Author: {0}", this.author);
            Console.WriteLine(" Title: {0}", this.title);
            Console.WriteLine(" # Copies: {0}", this.CopiesCount);
        }
    }
}
