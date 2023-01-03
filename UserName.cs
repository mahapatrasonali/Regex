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
        public static string REGEX_USERNAME = "^[A-Z]{1}[a-z]{2}$";

        public bool validateUserName(string userName)
        {
            return Regex.IsMatch(userName, REGEX_USERNAME);
        }
    }
}
