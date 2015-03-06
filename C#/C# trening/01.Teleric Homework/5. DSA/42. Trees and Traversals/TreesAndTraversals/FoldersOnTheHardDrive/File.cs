namespace FoldersOnTheHardDrive
{
    using System;

    public class File
    {
        private string name;
        private long size;

        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name
        {
            get
            { 
                return this.name; 
            }
            set 
            {
                if (String.IsNullOrEmpty(this.name))
                {
                    throw new ArgumentException("The name of the file cannot be null  or empty!");
                }

                this.name = value;
            }
        }

        public long Size
        {
            get 
            { 
                return this.size; 
            }
            set 
            {
                if (this.size < 0)
                {
                    throw new ArgumentException();
                }
                this.size = value; 
            }
        }
        
    }
}
