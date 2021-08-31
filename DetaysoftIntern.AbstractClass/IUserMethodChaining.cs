namespace DetaysoftIntern.AbstractClass
{
    interface IUserMethodChaining
    {
        IUserMethodChaining WriteUserInfo(User user);
        IUserMethodChaining ChangeUserName(ref User user, string name);
    }
}
