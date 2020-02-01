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
            Console.WriteLine("Hi, this is Marcus Crowley! What is your name? Type below and hit enter:");

            // Store whatever is typed into the user's input variable
            name = Console.ReadLine();

            // Show what the user entered
            Console.WriteLine("Nice to meet you {0}!", name);
        }
    }
}
