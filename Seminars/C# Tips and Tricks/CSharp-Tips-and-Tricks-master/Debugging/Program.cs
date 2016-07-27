namespace Debugging
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using Debugging.CallerInfoAttributes;
    using Debugging.DebuggerVariableDisplay;
    using Debugging.SystemInformation;

    public static class Program
    {
        public static void Main()
        {
            DebuggerVariableDisplay();
            Console.WriteLine(new string('=', 75));
            CallerInfoAttributes();
            Console.WriteLine(new string('=', 75));
            PreprocessorSymbols();
            Console.WriteLine(new string('=', 75));
            CurrentSystemInformation();
            Console.WriteLine(new string('=', 75));
        }

        private static void DebuggerVariableDisplay()
        {
            // Set breakpoints and observe debugging info of the following variables
            var student = new Student("John", "Doe");

            var studentWithToStringMethod = new StudentWithToStringMethod("John", "Doe");

            var studentWithDebuggerDisplayAttribute = new StudentWithDebuggerDisplayAttribute("John", "Doe");

            var studentWithDebuggerBrowsableAttribute = new StudentWithDebuggerBrowsableAttribute(
                "John",
                "Doe",
                new List<int> { 3, 3, 6, 6 });
        }

        private static void CallerInfoAttributes()
        {
            Console.WriteLine(CallerInfoAttributesExamples.GetCallerMemberName());
            Console.WriteLine(CallerInfoAttributesExamples.GetCallerFilePath());
            Console.WriteLine(CallerInfoAttributesExamples.GetCallerLineNumber());
        }

        private static void PreprocessorSymbols()
        {
#if DEBUG
            Console.WriteLine("DEBUG");
#elif CI_BUILD
            Console.WriteLine("CI_BUILD");
#else
            Console.WriteLine("Neither DEBUG nor CI_BUILD");
// #error Neither DEBUG nor CI_BUILD
#warning Neither DEBUG nor CI_BUILD
#endif
            CallOnlyInDebug();
        }

        [Conditional("DEBUG")]
        private static void CallOnlyInDebug()
        {
            Console.WriteLine("CallOnlyInDebug() called");
        }

        private static void CurrentSystemInformation()
        {
            var systemInformationGetter = new SystemInformationGetter();
            systemInformationGetter.WriteSystemInformationToConsole();
        }
    }
}
