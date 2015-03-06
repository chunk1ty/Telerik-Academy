namespace MegaCollections
{
    using System;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
