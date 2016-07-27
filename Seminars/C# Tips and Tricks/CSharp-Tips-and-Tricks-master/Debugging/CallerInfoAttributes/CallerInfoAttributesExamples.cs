namespace Debugging.CallerInfoAttributes
{
    using System.Runtime.CompilerServices;

    public static class CallerInfoAttributesExamples
    {
        public static string GetCallerMemberName([CallerMemberName]string memberName = null)
        {
            return string.Format("My caller member name is: {0}", memberName);
        }

        public static string GetCallerFilePath([CallerFilePath]string filePath = null)
        {
            return string.Format("My caller file path is: {0}", filePath);
        }

        public static string GetCallerLineNumber([CallerLineNumber]int lineNumber = 0)
        {
            return string.Format("My caller line number is: {0}", lineNumber);
        }
    }
}
