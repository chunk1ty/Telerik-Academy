namespace ExtensionSubstring
{
    using System;
    using System.Text;
    
    public class SubstringExt
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Andriyan");
            sb.Append(21);
            sb = sb.BuilderSubstring(8, 2);
            Console.WriteLine(sb);
        }
    }
}
