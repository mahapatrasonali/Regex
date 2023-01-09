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
             "5]: For Password validation\n"+
             "6]: For Password  validation atleast 1 uppercase\n"+
             "7]: For Password  validation min 1 number\n"+
            "8]: For Password  validation min 1 special character\n");
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
                case 6:
                    UserName.Passmax1upperchar();
                    break;
                case 7:
                    UserName.Passmin1num();
                    break;
                case 8:
                    UserName.Passmin1specialchar();
                    break;
                default:
                    Console.WriteLine("Choose the valid option");
                    break;
            }
         
        }
    }
}
