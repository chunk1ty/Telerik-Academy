namespace Library
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class DataManager
    {
        public List<string> ReadProfiles()
        {
            using (StreamReader reader = new StreamReader(@"..\..\Database\Users\Profiles.txt"))
            {
                string line = string.Empty;
                List<string> allLines = new List<string>();

                StringBuilder result = new StringBuilder();

                while ((line = reader.ReadLine()) != null)
                {
                    allLines.Add(line);
                }

                return allLines;
            }
        }

        public List<string> ReadReadables()
        {
            using (StreamReader reader = new StreamReader(@"..\..\Database\Books\Readables.txt"))
            {
                string line = string.Empty;
                List<string> allLines = new List<string>();

                StringBuilder result = new StringBuilder();

                while ((line = reader.ReadLine()) != null)
                {
                    allLines.Add(line);
                }

                return allLines;
            }
        }

        public void SerializeProfiles(IProfile profile)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\Database\Users\Profiles.txt", true))
            {
                writer.WriteLine();
                writer.Write(profile);
            }
        }

        public void SerializeReadables(IReadable readableItem)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\Database\Books\Readables.txt", true))
            {
                writer.WriteLine();
                writer.Write(readableItem);
            }
        }
    }
}
