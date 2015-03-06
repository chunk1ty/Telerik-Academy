using System;
using System.IO;
using System.Text;

namespace TransferDateFromTwoFilesToOne
{
    class DataTransfer
    {
        static void Main()
        {
            string firstFileData = @"..\..\ReadFileTest.txt";
            string dataFromFirstFile = ReadDataFromFile(firstFileData);
            //Console.WriteLine(dataFromFirstFile);

            string secondFileData = @"..\..\ReadFileTestTwo.txt";
            string dataFromSecondFile = ReadDataFromFile(secondFileData);
            //Console.WriteLine(dataFromSecondFile);

            StreamWriter writer = new StreamWriter("outputFile.txt");
            using (writer)
            {
                writer.Write(dataFromFirstFile);
                writer.Write(dataFromSecondFile);
            }
        }

        static string ReadDataFromFile(string file)
        {
            StreamReader read = new StreamReader(file,Encoding.UTF8);
            string data = string.Empty;

            using (read)
            {
                data = read.ReadToEnd();
            }
            return data;
        }
    }
}
