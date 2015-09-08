namespace Profiler
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            UserProfile profile = new UserProfile();
            profile.FirstName = "Ivaylo";
            profile.LastName = "Kenov";
            profile.Age = 10;

            UserProfile loadedProfile = Load();
        }

        static void Save(UserProfile profile)
        {
            StreamWriter writer = new StreamWriter("data.txt");

            // FirstName Ivaylo
            // LastName Kenov

            using (writer)
            {
                Type profileType = typeof(UserProfile);
                var profileProperties = profileType.GetProperties();

                foreach (var property in profileProperties)
                {
                    var attributes = property.GetCustomAttributes(typeof(SaveAttribute), false);

                    if (attributes.Length >= 1)
                    {
                        writer.WriteLine(property.Name + " " + property.GetValue(profile));
                    }
                }
            }
        }

        static UserProfile Load()
        {
            StreamReader reader = new StreamReader("data.txt");

            UserProfile profile = new UserProfile();

            using (reader)
            {
                Type profileType = typeof(UserProfile);

                string currentData = reader.ReadLine();

                while (!string.IsNullOrEmpty(currentData))
                {
                    string[] values = currentData.Split(' ');

                    string propertyName = values[0];
                    string propertyValue = values[1];

                    var property = profileType.GetProperty(propertyName);
                    property.SetValue(profile, propertyValue);

                    currentData = reader.ReadLine();
                }
            }

            return profile;
        }
    }
}
