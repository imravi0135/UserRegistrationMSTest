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