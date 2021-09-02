using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DetaysoftIntern.XmlSerializationAndDeserialization
{
    [XmlRoot("User")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static string fileName = "users.xml";
        static XmlSerializer mySerializer = new XmlSerializer(typeof(User));
        static User deserializeUser;

        static void Main(string[] args)
        {
            List<User> users = new()
            {
                new User
                {
                    Id = 0,
                    Name = "Uğur"
                },
                new User
                {
                    Id = 1,
                    Name = "Mücahid"
                },
                new User
                {
                    Id = 2,
                    Name = "Mehmet"
                },
            };

            Serializer(users[0]);
            Deserializer(ref deserializeUser);
            Console.WriteLine($"deserializeUser : Id:{deserializeUser.Id} Name: {deserializeUser.Name}");
            Serializer(users);
            Environment.Exit(0);
        }

        static void Serializer(User user)
        {
            StreamWriter myWriter = new StreamWriter(fileName);
            mySerializer.Serialize(myWriter, user);
            myWriter.Close();
        }
        static void Serializer(List<User> users)
        {
            StreamWriter myWriter = new StreamWriter(fileName);
            foreach (var user in users)
                mySerializer.Serialize(myWriter, user);

            myWriter.Close();
        }

        static void Deserializer(ref User user)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            user = (User)mySerializer.Deserialize(fileStream);
            fileStream.Close();
        }
    }
}
