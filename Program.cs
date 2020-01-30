using System;

namespace UserInputFirstNameLastName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable
            string name;
            
            // Introduce yourself
            Console.WriteLine("Hi, this is Marcus Crowley!");

            // Ask user to type user's name
            Console.Write("What is your name?: ");

            // Store whatever is typed into the user's input variable
            name = Console.ReadLine();

            // Print blank line
            Console.WriteLine();

            // Show what the user entered
            Console.WriteLine("Nice to meet you {0}!", name);
        }
    }
}
