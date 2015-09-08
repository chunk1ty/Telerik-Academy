namespace FoldersOnTheHardDrive
{
    using System;
    using System.Collections.Generic;

    public class Folder
    {
        //Folder { string name, File[] files, Folder[] childFolders } 

        private IList<File> files;
        private IList<Folder> childFolders;

        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public string Name { get; set; }

        public IList<File> Files
        {
            get 
            { 
                return this.files; 
            }
            private set 
            { 
                this.files = value; 
            }
        }

        public IList<Folder> ChildFolders
        {
            get 
            {
                return childFolders; 
            }
            set
            { 
                childFolders = value; 
            }
        }

        public long GetFilesSize()
        {
            long size = 0;

            foreach (var file in files)
            {
                size += file.Size;
            }

            foreach (var childFolder in childFolders)
            {
                size += childFolder.GetFilesSize();
            }

            return size;
        }

        public void AddFile(string name, long size)
        {
            File file = new File(name, size);
            files.Add(file);
        }

        public void AddFolder(string name)
        {
            Folder folder = new Folder(name);
            childFolders.Add(folder);
        }
    }
}
