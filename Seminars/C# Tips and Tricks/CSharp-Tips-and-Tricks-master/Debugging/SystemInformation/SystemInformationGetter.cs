namespace Debugging.SystemInformation
{
    using System;

    public class SystemInformationGetter
    {
        public void WriteSystemInformationToConsole()
        {
            Console.WriteLine("WinDir: {0}", Environment.GetEnvironmentVariable("windir"));
            Console.WriteLine("Current directory: {0}", Environment.CurrentDirectory);
            Console.WriteLine("System directory: {0}", Environment.SystemDirectory);
            Console.WriteLine("My documents directory: {0}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine("Fonts directory: {0}", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
            Console.WriteLine("Machine name: {0}", Environment.MachineName);
            Console.WriteLine("User name: {0}", Environment.UserName);
            Console.WriteLine("OS version: {0}", Environment.OSVersion);
            Console.WriteLine("CLR version: {0}", Environment.Version);
            Console.WriteLine("Has shutdown started: {0}", Environment.HasShutdownStarted);
            Console.WriteLine("Is 64 bit OS: {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine("Is 64 bit process: {0}", Environment.Is64BitProcess);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine("Page size: {0}", Environment.SystemPageSize);
            Console.WriteLine("Physical memory mapped to the process context: {0}", Environment.WorkingSet);

            Console.WriteLine(new string('-', 60));
            Console.Write("Logical drives: ");
            Array.ForEach(Environment.GetLogicalDrives(), x => Console.Write("{0} ", x));
            Console.WriteLine();

            Console.WriteLine(new string('-', 60));
            Console.WriteLine("Stack trace: {0}", Environment.StackTrace);

            Console.WriteLine(new string('-', 60));
            Console.WriteLine("Path environment variable: {0}", Environment.GetEnvironmentVariable("Path"));
        }
    }
}
