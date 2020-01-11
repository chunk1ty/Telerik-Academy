using System;
using System.Collections.Generic;

namespace Decorator.Decorators
{
    /// <summary>
    /// The 'ConcreteDecorator' class - adds responsibilities to the component
    /// </summary>
    internal class Borrowable : Decorator
    {
        private readonly List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem)
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            LibraryItem.CopiesCount--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            LibraryItem.CopiesCount++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in this.borrowers)
            {
                Console.WriteLine("  borrower: " + borrower);
            }
        }
    }
}
