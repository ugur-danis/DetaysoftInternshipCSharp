using System;

namespace DetaysoftIntern.Types.ReferanceType
{
    class Program
    {
        private class User
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public User(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        static void Main(string[] args)
        {
            User user = new(0, "Uğur");
            User userCopy = user;

            Console.WriteLine("user = Id: {0} Name: {1}\nuserCopy = Id: {2} Name: {3}\n", user.Id, user.Name, userCopy.Id, userCopy.Name);
            userCopy.Name = "Mücahid";
            Console.WriteLine("userCopy name is changed\n");
            Console.WriteLine("user = Id: {0} Name: {1}\nuserCopy = Id: {2} Name: {3}", user.Id, user.Name, userCopy.Id, userCopy.Name);
        }
    }
}
