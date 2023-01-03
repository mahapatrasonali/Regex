namespace RegexUserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your FirstName: ");
            string username = Console.ReadLine();
            UserName userName = new UserName();
            bool name = userName.validateUserName(username);
            if (name)
            {
                Console.WriteLine("UserName is Valid");
            }
            else
            {
                Console.WriteLine("UserName is not Valid");
            }
        }
    }
}
