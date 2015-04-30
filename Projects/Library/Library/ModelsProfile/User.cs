namespace Library
{
    using System;
    using System.Collections.Generic;

    public abstract class User : Profile, IUser, IProfile
    {
        public ICollection<IReadable> readItems;
        public ICollection<IReadable> currentlyReadItems;
        public ICollection<IReadable> wishedToReadItems; 

        public User(string name, string password, ProfileType profileType) 
            :base(name, password, profileType)
        {
            this.readItems = new List<IReadable>();
            this.currentlyReadItems = new List<IReadable>();
            this.wishedToReadItems = new List<IReadable>();
        }

        public ICollection<IReadable> ReadItems
        {
            get
            {
                return new List<IReadable>(readItems);
            }            
        }

        public ICollection<IReadable> CurrentlyReadItems
        {
            get
            {
                return new List<IReadable>(currentlyReadItems);
            }
        }

        public ICollection<IReadable> WishedToReadItems
        {
            get
            {
                return new List<IReadable>(wishedToReadItems);
            }
        }

        public void AddReadItem(IReadable readableItem)
        {
            if (this.ReadItems.Contains(readableItem))
            {
                throw new LibraryUserException(LibraryUserException.ExistingReadableItemInListMsg);
            }
            else
            {
                this.ReadItems.Add(readableItem);
            }            
        }

        public void AddToCurrentReadable(IReadable readableItem)
        {
            if (this.ReadItems.Contains(readableItem))
            {
                throw new LibraryUserException(LibraryUserException.ExistingReadableItemInListMsg);
            }
            else
            {
                this.ReadItems.Add(readableItem);
            }
        }

        public void RemoveCurrentReadable(IReadable readableItem)
        {
            if (this.ReadItems.Contains(readableItem))
            {
                throw new LibraryUserException(LibraryUserException.ExistingReadableItemInListMsg);
            }
            else
            {
                this.ReadItems.Remove(readableItem);
            }
        }

        public void AddToWishedReadable(IReadable readableItem)
        {
            if (this.ReadItems.Contains(readableItem))
            {
                throw new LibraryUserException(LibraryUserException.ExistingReadableItemInListMsg);
            }
            else
            {
                this.ReadItems.Add(readableItem);
            }
        }

        public void RemoveWishedReadable(IReadable readableItem)
        {
            if (this.ReadItems.Contains(readableItem))
            {
                throw new LibraryUserException(LibraryUserException.ExistingReadableItemInListMsg);
            }
            else
            {
                this.ReadItems.Remove(readableItem);
            }
        }

        public void FinishReadable(IReadable readableItem)
        {
            RemoveCurrentReadable(readableItem);
            AddReadItem(readableItem);
        }
    }
}
