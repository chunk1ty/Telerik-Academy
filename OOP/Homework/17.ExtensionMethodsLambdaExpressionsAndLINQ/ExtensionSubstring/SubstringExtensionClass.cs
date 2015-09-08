namespace ExtensionSubstring
{    
    using System.Text;
    public static class SubstringExtensionClass
    {
        public static StringBuilder BuilderSubstring (this StringBuilder originalSB, int index, int length)
        {
            var sb = new StringBuilder();
            int len = 0;
            while (length > len)
            {
                sb.Append(originalSB[index]);
                index++;
                len++;
            }
            return sb;
        }       
    }
}
