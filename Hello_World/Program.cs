using System;

namespace Hello_World
{
    class Program
    {
        static void Banner()
        {
            Console.WriteLine("");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("");
        }

        static void Spacer()
        {
            Console.WriteLine("");
        }

        static void UserInput()
        {
            Console.Write("> ");
            Console.ReadLine();
        }


        static void StartGame(out string userName)
        {
            Console.WriteLine("Hello there, you may not understand whats going on at the moment, ");
            Console.WriteLine("but you were born into this world just a few moments ago. If your reading this, ");
            Console.WriteLine("your intelligence has far exceeded our expectations!");
            Console.WriteLine("You are learning at an incredible speed. If you are reading this,");
            Console.WriteLine("then I believe it's time to start getting you ready for your adventuring out into");
            Console.WriteLine("this new world.");
            Console.Write("\n");
            Console.WriteLine("Let me ask you, new adventurer, what is your name?");
            Console.Write("> ");
            userName = Console.ReadLine();
        }

        static void Greeting(string name)
        {

            Console.WriteLine($"It's an honor to meet you {name}!");

        }

        static void ChooseRole(string name)
        {
            Console.WriteLine($"Now that we know you name, {name}, We need to know what kind of adventurer");
            Console.WriteLine
                (@"You have 3 choices: 
                1. Warrior
                2. Mage
                3. Thief
                Which would you like to be? 
                (You can choose by typing the word into the input or the number associated)");
        }




















        static void Main(string[] args)
        {
            // seperates last terminal line from the start of the program, as well as add a simple banner
            Spacer();
            Banner();

            // Starts the game, asks for users name, greets user
            string userName;
            StartGame(out userName);
            Spacer();
            Greeting(userName);

            // Make user choose a role
            








            // seperates program from the terminal line when the program terminates
            Banner();
            Spacer();
        }
    }
}
