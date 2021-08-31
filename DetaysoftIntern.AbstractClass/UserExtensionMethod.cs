namespace DetaysoftIntern.AbstractClass
{
    static class UserExtensionMethod
    {
        public static int GetUserId(this User user) => user.Id;
        public static string GetUserName(this User user) => user.Name;
    }
}
