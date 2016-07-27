namespace Traps.ExceptionsInStaticConstructors
{
    using System;

    // http://stackoverflow.com/a/4737910/1862812
    public sealed class Bang
    {
        static Bang()
        {
            Console.WriteLine("In static constructor");
            throw new Exception("Bang!");
        }

        public Bang()
        {
            Console.WriteLine("In instance Bang constructor.");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("In StaticMethod()");
        }
    }
}
