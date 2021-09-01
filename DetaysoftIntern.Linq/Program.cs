using System;
using System.Collections.Generic;
using System.Linq;

namespace DetaysoftIntern.Linq
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region evenNumQuery
            Console.WriteLine("evenNumQuery");

            List<int> nums = new() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evenNumQuery =
                from num in nums
                where (num % 2 == 0)
                select num;

            foreach (int item in evenNumQuery)
                Console.Write(item + ", ");
            #endregion

            #region reverseNumsQuery
            Console.WriteLine("\n\nreverseNumsQuery");

            var reverseNumsQuery =
                from num in nums
                orderby num descending
                select num;

            foreach (int item in reverseNumsQuery)
                Console.Write(item + ", ");
            #endregion

            #region usersByAgeQuery
            Console.WriteLine("\n\nusersByAgeQuery");

            List<User> users = new()
            {
                new User("Uğur", 18),
                new User("Mücahid", 25),
                new User("Emre", 23),
                new User("Mehmet", 18)
            };

            var usersByAgeQuery =
                from user in users
                group user by user.Age;

            foreach (var userByAgeQuery in usersByAgeQuery)
                foreach (var user in userByAgeQuery)
                    Console.WriteLine($"{user.Name} {user.Age}");
            #endregion
        }
    }
}
