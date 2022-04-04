using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationMstest
{
    internal class UserRegistrationCustomException
    {
        public class UserValidationCustomException : Exception
        {
            ExceptionType type;
            public enum ExceptionType
            {

                Name_Empty,
                Name_Less_Than_Three,
                Name_Start_With_Upper_Case,
                Email_Empty,
                Email_With_Min_Char,
                Email_Contains_SpecialChar,
                Email_Contain_Symbol,
                Mobile_Atleast_TenDigit,
                Mobile_Number_Empty,
                Password_Empty,
                Password_Min_Eight_Char,
                Password_AtLeast_OneUpperCase,
            }
            public UserValidationCustomException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        }
    }
}
