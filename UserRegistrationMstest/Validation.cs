using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static UserRegistrationMstest.UserRegistrationCustomException;

namespace UserRegistrationMstest
{
    public class Validation
    {
        public Regex FirstNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex LastNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex EmailRegex = new Regex("^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public string ValidFirstName(string firstName)
        {
            bool result = false;
            if (FirstNameRegex.IsMatch(firstName)) { result = true; }
            try
            {
                if (result == false)
                {
                    if (firstName.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Empty,
                            "First name should not be empty");
                    else if (firstName.Length < 3)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Less_Than_Three,
                            "First name should contain atleast three character");
                }
                else
                {
                    return "First Name is Valid";
                }
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "First Name is Invalid";
        }
        public string ValidLastName(string lastName)
        {
            bool result = false;
            if (LastNameRegex.IsMatch(lastName)) { result = true; }
            try
            {
                if (result == false)
                {
                    if (lastName.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Empty,
                            "Last name should not be empty");
                    else if (lastName.Length < 3)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Less_Than_Three,
                            "Last name should contain atleast three character");

                    else if (!char.IsUpper(lastName[0]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Start_With_Upper_Case,
                            "Last name should start with upper case");

                }
                else
                {
                    return "Last Name is Valid";
                }
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Last Name is Invalid";
        }
        public string ValidEmail(string email)
        {
            bool result = false;
            if (EmailRegex.IsMatch(email)) { result = true; }
            try
            {
                if (result == false)
                {
                    if (email.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Email_Empty,
                            "Email should not be empty");
                    else if (email.Length < 7)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Email_With_Min_Char,
                            "Email should contain atleast seven character");
                    else if (!email.Any(char.IsLetterOrDigit))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Email_Contains_SpecialChar,
                            "Email should contain special characters");
                    else if (!email.Contains('@'))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Email_Contain_Symbol,
                            "Email should contains @ Symbol");
                }
                else return "Email is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Email is Invalid";
        }

    }
}

