using System;

namespace DetaysoftIntern.AbstractClass
{
    abstract class PeopleAbstractClass
    {
        public void Death() => Console.WriteLine("Death");
        public virtual void Eat() => Console.WriteLine("Eat");
        public virtual void Eat(string food) => Console.WriteLine("Eat {0}", food);
        public abstract void Work();
    }
}
