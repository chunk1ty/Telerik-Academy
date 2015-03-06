using System;
using System.Collections.Generic;
using System.IO;

namespace _02.TraverseDirectoryAndFindAllFiles
{
    public class TraverseDirectoryAndFindAllFiles
    {
        public static void Main()
        {
            string startingDirectory = @"C:\Windows";
            string fileExtension = "*.exe";           

            List<string> searchedFiles = new List<string>();
            TraverseDirectories(searchedFiles, startingDirectory, fileExtension);

            StreamWriter writer = new StreamWriter("outputFile.txt");

            using (writer)
            {
                foreach (var item in searchedFiles)
                {
                    writer.WriteLine(item);
                }
            }
        }

        private static void TraverseDirectories(List<string> searchedFiles, string startingDirectory, string fileExtension)
        {
            try
            {
                string[] files = Directory.GetFiles(startingDirectory, fileExtension);
                if (files.Length > 0)
                {
                    searchedFiles.AddRange(files);
                }

                string[] directories = Directory.GetDirectories(startingDirectory);
                foreach (var dir in directories)
                {
                    TraverseDirectories(searchedFiles, dir, fileExtension);
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
        }
    }
}