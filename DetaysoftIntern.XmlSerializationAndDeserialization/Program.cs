using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DetaysoftIntern.XmlSerializationAndDeserialization
{
    [Serializable]
    public class User
    {
        [XmlElement("Id")]
        public int Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement(typeof(Task))]
        public List<Task> Tasks { get; set; }
    }

    [Serializable]
    public class Task
    {
        [XmlElement("Id", DataType = "int")]
        //[XmlIgnoreAttribute]
        public int Id { get; set; }

        [XmlElement("NameDescription", DataType = "string")]
        public string Description { get; set; }
    }

    class Program
    {
        static string fileName = "users.xml";
        static XmlSerializer mySerializer;
        static User deserializeUser;
        static List<User> deserializeUsers;

        static void Main(string[] args)
        {
            List<User> users = new()
            {
                new User
                {
                    Id = 0,
                    Name = "Uğur",
                    Tasks = new List<Task>
                    {
                        new Task
                        {
                            Id = 0,
                            Description = "Task 1"
                        },
                        new Task
                        {
                            Id = 1,
                            Description = "Task 2"
                        }
                    }
                },
                new User
                {
                    Id = 1,
                    Name = "Mücahid",
                    Tasks = new List<Task>
                    {
                        new Task
                        {
                            Id = 2,
                            Description = "Task 2"
                        },
                        new Task
                        {
                            Id = 3,
                            Description = "Task 3"
                        }
                    }
                },
                new User
                {
                    Id = 2,
                    Name = "Mehmet",
                    Tasks = new List<Task>
                    {
                        new Task
                        {
                            Id = 4,
                            Description = "Task 4"
                        },
                        new Task
                        {
                            Id = 5,
                            Description = "Task 5"
                        }
                    }
                },
            };

            /*
                Serializer(users[0]);
                Deserializer(ref deserializeUser);
                Console.WriteLine($"deserializeUser : Id:{deserializeUser.Id} Name: {deserializeUser.Name}");
            */

            Serializer(users);
            deserializeUsers = users;
            Deserializer(ref deserializeUsers);
            foreach (var user in deserializeUsers)
                Console.WriteLine($"Id:{user.Id} Name: {user.Name}");
        }

        static void Serializer(User user)
        {
            StreamWriter myWriter = new(fileName);
            mySerializer = new(typeof(User));
            mySerializer.Serialize(myWriter, user);
            myWriter.Close();
        }
        static void Serializer(List<User> users)
        {
            StreamWriter myWriter = new(fileName);
            mySerializer = new(typeof(List<User>));
            mySerializer.Serialize(myWriter, users);
            myWriter.Close();
        }

        static void Deserializer(ref User user)
        {
            FileStream fileStream = new(fileName, FileMode.Open);
            mySerializer = new(typeof(User));
            user = (User)mySerializer.Deserialize(fileStream);
            fileStream.Close();
        }

        static void Deserializer(ref List<User> users)
        {
            mySerializer = new(typeof(List<User>));

            StreamReader streamReader = new(fileName);
            users = (List<User>)mySerializer.Deserialize(streamReader);
            streamReader.Close();
        }
    }
}
