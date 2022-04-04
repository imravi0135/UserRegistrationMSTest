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

            }
            public UserValidationCustomException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        }
    }
}
