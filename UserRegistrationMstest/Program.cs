using System;
using UserRegistrationMstest;

namespace UserRegistrationMSTesting
{
    class program
    {
        static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            int options = 0;
            do
            {
                Console.WriteLine("Choose 1: First name validation");
                Console.WriteLine("Choose 2: Last name validation");
                Console.WriteLine("Email Validation");

                try
                {
                    options = int.Parse(Console.ReadLine());
                    switch (options)
                    {
                        case 1:
                            Console.WriteLine("Enter your First Name: ");
                            string input = Console.ReadLine();
                            userRegistration.ValidFirstName(input);
                            break;
                        case 2:
                            Console.WriteLine("Enter your Last Name: ");
                            input = Console.ReadLine();
                            userRegistration.ValidLastName(input);
                            break;
                        case 3:
                            Console.WriteLine("Enter your Email: ");
                            input = Console.ReadLine();
                            userRegistration.ValidEmail(input);
                            break;
                        default:
                            Console.WriteLine("Choose From the Options given above");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Choose a valid option");
                }
            } while (options != 0);
        }
    }
}