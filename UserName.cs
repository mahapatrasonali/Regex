using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    public class UserName
    {

        public static void FirstName()      //UC1
        {
            Console.WriteLine("Enter your FirstName");
            string userInput = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z]{2,}$";
            Iteration(userInput, regexCondition);
        }
        public static void LastName()      //UC2
        {
            Console.WriteLine("Enter your LastName");
            string userInput = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z]{2,}$";
            Iteration(userInput, regexCondition);
        }
        public static void EmailValidating()      //UC3
        {
            Console.WriteLine("Enter your EmailId");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-z]{1}[a-z]{2}(.)[a-z]{3}(@bl.co)$";
            Iteration(userInput, regexCondition);
        }
        public static void PhoneNumberValidating()      //UC4
        {
            Console.WriteLine("Enter your PhoneNumber");
            string userInput = Console.ReadLine();
            string regexCondition = "^[0-9]{2}[ ][0-9]{10}$";
            Iteration(userInput, regexCondition);
        }
        public static void Passmin8char()      //UC5
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-zA-Z0-9]{8,}$"; 
            Iteration(userInput, regexCondition);
        }
        public static void Passmax1upperchar()      //UC6
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z0-9]{7}$";
            Iteration(userInput, regexCondition);
        }
        public static void Passmin1num()      //UC7
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-zA-Z]{7}[0-9]{1}$";
            Iteration(userInput, regexCondition);
        }
        public static void Passmin1specialchar()      //UC8
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-zA-Z]{4}[@,#,&,*,$]{1}[0-9]{3}$";
            Iteration(userInput, regexCondition);
        }
        public static void Iteration(string userInput, string regexCondition)
        {
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
            }
        }
    }
}
