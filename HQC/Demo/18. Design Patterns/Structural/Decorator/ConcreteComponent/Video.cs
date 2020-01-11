using System;

namespace Decorator.ConcreteComponent
{
    /// <summary>
    /// The 'ConcreteComponent' class - defines an object to which additional responsibilities can be attached.
    /// </summary>
    internal class Video : LibraryItem
    {
        private readonly string director;
        private readonly string title;
        private readonly int playTime;

        public Video(string director, string title, int copiesCount, int playTime)
        {
            this.director = director;
            this.title = title;
            this.CopiesCount = copiesCount;
            this.playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("Video ----- ");
            Console.WriteLine(" Director: {0}", this.director);
            Console.WriteLine(" Title: {0}", this.title);
            Console.WriteLine(" # Copies: {0}", this.CopiesCount);
            Console.WriteLine(" Playtime: {0}", this.playTime);
        }
    }
}
