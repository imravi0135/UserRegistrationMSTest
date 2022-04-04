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
        public Regex LastNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex EmailRegex = new Regex("^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public Regex MobileNoRegex = new Regex("^[0-9]{2}[ ][5-9]{1}[0-9]{9}$");
        public Regex PasswordRegex = new Regex("^[a-zA-Z0-9]{8,}$");

        public void ValidFirstName(string firstName)
        {
            Console.WriteLine("First name - " + firstName);
            if (FirstNameRegex.IsMatch(firstName))
                Console.WriteLine($"{firstName} is valid");
            else
                Console.WriteLine($"{firstName} is Invalid");

        }
        public void ValidLastName(string lastName)
        {
            Console.WriteLine("Last name - " + lastName);
            if (LastNameRegex.IsMatch(lastName))
                Console.WriteLine($"{lastName} is valid");
            else
                Console.WriteLine($"{lastName} is Invalid");

        }
        public void ValidEmail(string email)
        {
            Console.WriteLine("Email - " + email);
            if (EmailRegex.IsMatch(email))
                Console.WriteLine($"{email} is valid");
            else
                Console.WriteLine($"{email} is Invalid");
        }
        public void ValidMobile(string mobile)
        {
            Console.WriteLine("Mobile number - " + mobile);
            if (MobileNoRegex.IsMatch(mobile))
                Console.WriteLine($"{mobile} is valid");
            else
                Console.WriteLine($"{mobile} is Invalid");
        }
        public void ValidPasswordRuleOne(string password)
        {
            Console.WriteLine("Password - " + password);
            if (PasswordRegex.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
    }
}
