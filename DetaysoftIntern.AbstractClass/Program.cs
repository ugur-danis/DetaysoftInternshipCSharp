namespace DetaysoftIntern.AbstractClass
{

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(0, "Uğur");
            user.Eat();
            user.Eat("Bread");
            int userId = user.GetUserId();

            IUserMethodChaining userExtensionMethod = new UserMethodChaining();
            userExtensionMethod.ChangeUserName(ref user, "Mücahid").WriteUserInfo(user);
        }
    }
}
