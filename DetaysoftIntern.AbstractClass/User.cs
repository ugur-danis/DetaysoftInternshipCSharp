using System;

namespace DetaysoftIntern.AbstractClass
{
    class User : PeopleAbstractClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override void Work() => Console.WriteLine("Work");
    }
}
