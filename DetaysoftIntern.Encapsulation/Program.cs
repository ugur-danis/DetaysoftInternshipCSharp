using System;

namespace DetaysoftIntern.Encapsulation
{
    class User
    {
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                if (value < 0) _id = 0;
                else _id = value;
            }
        }
        public string Name { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new(-5, "Uğur");
            Console.WriteLine("User: Id:{0} Name:{1}", user.Id, user.Name);
        }
    }
}
