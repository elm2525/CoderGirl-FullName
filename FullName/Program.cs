using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            

            // TODO: Ask the user for their first name and then their last name.

            // TODO: Call a method called FullName that returns their full name.

            // TODO: Output their full name.

            FullName();

            Console.ReadLine();
        }

        public static void FullName()
        {
            

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            string message = (firstName) + " " + (lastName);

            Console.Write(message);
            
        }

        // TODO: Create a method call FullName that takes the firstName and lastName as parameters.
    }
}
