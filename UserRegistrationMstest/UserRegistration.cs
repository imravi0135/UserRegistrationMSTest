using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMstest
{
    internal class UserRegistration
    {
        public Regex FirstNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");

        public void ValidFirstName(string firstName)
        {
            Console.WriteLine("First name - " + firstName);
            if (FirstNameRegex.IsMatch(firstName))
                Console.WriteLine($"{firstName} is valid");
            else
                Console.WriteLine($"{firstName} is Invalid");

        }
    }
}
