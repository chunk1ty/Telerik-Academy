namespace Library
{
    using System;
    using System.Collections.Generic;

    public sealed class Library
    {
        //Creating single instance
        private static readonly Library SingleInstance = new Library("Online library");

        private string name;
        private ICollection<IReadable> readableItems;
        private ICollection<IProfile> users;

        public readonly ProfilesFactory profilesFactory;
        public readonly ReadableItemsFactory readableItemsFactory;
        public readonly Search search;
        public readonly DataManager dataManager;

        private Library(string name)
        {
            this.Name = name;
            this.readableItems = new List<IReadable>();
            this.users = new List<IProfile>();
            this.profilesFactory = new ProfilesFactory();
            this.readableItemsFactory = new ReadableItemsFactory();
            this.search = new Search();
            this.dataManager = new DataManager();
        }

        public static Library Instance
        {
            get
            {
                return SingleInstance;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {                
                LibraryUserException.CheckIfNameIsNullOrEmpty(value, LibraryUserException.NullNameException);
                this.name = value;
            }
        }

        public ICollection<IReadable> ReadableItems
        {
            get
            {
                return new List<IReadable>(this.readableItems);
            }
        }

        public ICollection<IProfile> Users
        {
            get
            {
                return new List<IProfile>(this.users);
            }
        }

        public void Start()
        {
            this.InitializeProfiles();
            this.InitializeReadableItems();            
        }

        public void InitializeReadableItems()
        {
            var allReadables = dataManager.ReadReadables();

            foreach (var line in allReadables)
            {
                string[] data = new string[9];
                data = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                var readableItem = readableItemsFactory.CreateReadableItem(data);
                this.AddReadableItem(readableItem);
            }
        }

        public void InitializeProfiles()
        {
            var allProfiles = dataManager.ReadProfiles();

            foreach (var line in allProfiles)
            {
                string[] data = new string[3];
                data = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                var profile = profilesFactory.CreateProfile(data);
                this.AddUser(profile);
            }
        }

        public void AddReadableItem(IReadable readable)
        {
            if (this.readableItems.Contains(readable))
            {
                throw new ArgumentException(LibraryItemException.ExistingItemException);
            }
            else
            {
                this.readableItems.Add(readable);
            }
        }

        public void RemoveReadableItem(IReadable readable)
        {
            if (!this.readableItems.Contains(readable))
            {
                throw new ArgumentException(LibraryItemException.NotExistingItemException);
            }

            else
            {
                this.readableItems.Remove(readable);
            }
        }

        public void AddUser(IProfile user)
        {
            if (this.users.Contains(user))
            {
                throw new ArgumentException(LibraryUserException.ExistingUserException);
            }

            else
            {
                this.users.Add(user);
            }
        }

        public bool isAlreadyInTheLibrary(IProfile profile)
        {
            foreach (var profileItem in this.Users)
            {
                if (profile.Name == profileItem.Name)
                {
                    return true;
                }
            }

            return false;
        }

        public bool isAlreadyInTheLibrary(IReadable readableItem)
        {
            foreach (var readable in this.ReadableItems)
            {
                if (readable.Name == readableItem.Name)
                {
                    return true;
                }
            }

            return false;
        }

        public void SaveReadableItem(IReadable readable)
        {
            if (!this.isAlreadyInTheLibrary(readable))
            {
                this.dataManager.SerializeReadables(readable);
            }
        }

        public void SaveProfile(IProfile profile)
        {
            if (!this.isAlreadyInTheLibrary(profile))
            {
                this.dataManager.SerializeProfiles(profile);
            }
        }
    }
}