namespace AttributeTask
{
    using System;
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]
    public class VersionAttribute : System.Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }
        public VersionAttribute (int maj, int min)
        {
            this.Major = maj;
            this.Minor = min;
        }
    }

    [VersionAttribute (1,0)]
    class AttributeT
    {
        static void Main()
        {
            Type type = typeof(AttributeT);
            object[] allAtr = type.GetCustomAttributes(false);
            foreach (VersionAttribute ver in allAtr)
            {
                Console.WriteLine("The version of the class AttributT is {0}.{1}",ver.Major,ver.Minor);                
            }
        }
    }
}
