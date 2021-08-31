using System;

namespace DetaysoftIntern.AbstractClass
{
    public class UserMethodChaining : IUserMethodChaining
    {
        IUserMethodChaining IUserMethodChaining.WriteUserInfo(User user)
        {
            Console.WriteLine("{0} {1}", user.Id, user.Name);
            return this;
        }

        IUserMethodChaining IUserMethodChaining.ChangeUserName(ref User user, string name)
        {
            user.Name = name;
            return this;
        }
    }
}
