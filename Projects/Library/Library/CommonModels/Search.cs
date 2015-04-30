namespace Library
{    
    using System;
    using System.Collections.Generic;

    public class Search
    {        
        public ICollection<IReadable> SearchReadableItem(string keyword)
        {
            if (keyword.Length < 3)
            {
                throw new LibraryCommonException(LibraryCommonException.ExceptionMessageForKeywordsLength);
            }

            var searchResult = new List<IReadable>();

            foreach (var readable in Library.Instance.ReadableItems)
            {
                if (readable.Name.ToLower().Contains(keyword.ToLower()))
                {
                    searchResult.Add(readable);
                }
            }

            return searchResult;
        }
    }
}
