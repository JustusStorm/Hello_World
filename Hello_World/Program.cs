using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            // Talk to the user, ask them if they are ready to code
            // take their input
            // if input is "yes", continue program, if not, then exit code

            Console.WriteLine("Hello user, are you ready to try some coding? yes/no");
            Console.Write("> ");
            string userAnswer = Console.ReadLine().ToLower().Trim();
            char firstInputIndex = userAnswer[0];


            if (firstInputIndex == 'y')
            {
                Console.WriteLine("Here we go then.\n");
            }
            else
            {
                Console.WriteLine("You aren't ready. Come back later when you're ready to become a developer.");
            }

            Console.WriteLine("");





        }
    }
}
