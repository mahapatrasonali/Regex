namespace RegexUserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Program\n");
            Console.WriteLine("Choose a VAlid Option From Below\n" +
                "1]: For User Name validation\n" +
               "2]: For User Name validation\n" +
              "3]: For Email validation\n" +
             "4]: For PhoneNumber validation\n"+
             "5]: For Password validation\n");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    UserName.FirstName();
                    break;
                    case 2:
                        UserName.LastName();
                    break;
                    case 3:
                        UserName.EmailValidating();
                    break;
                    case 4:
                        UserName.PhoneNumberValidating();
                    break;
                case 5:
                    UserName.Passmin8char();
                    break;
                default:
                    Console.WriteLine("Choose the valid option");
                    break;
            }
         
        }
    }
}
