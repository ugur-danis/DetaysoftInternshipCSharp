using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DetaysoftIntern.JsonSerializationAndDeserialization
{
    class User
    {
        public int Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("UserName")]
        public string Name { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => $"Id:{Id} Name:{Name}";
    }

    public class UpperCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name) => name.ToUpper();
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new(0, "Uğur");

            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
                PropertyNamingPolicy = new UpperCaseNamingPolicy(),
                PropertyNameCaseInsensitive = true,
                NumberHandling =
                    JsonNumberHandling.AllowReadingFromString |
                    JsonNumberHandling.WriteAsString,
            };

            string jsonSerialize = JsonSerializer.Serialize(user, options);
            Console.WriteLine("jsonSerialize");
            Console.WriteLine(jsonSerialize);

            Console.WriteLine("\njsonDeserialize");
            User jsonDeserialize = JsonSerializer.Deserialize<User>(jsonSerialize, options);
            Console.WriteLine(jsonDeserialize.ToString());
        }
    }
}
