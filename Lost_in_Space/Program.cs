using System;

namespace Lost_in_Space
{
    class Program
    {
        static void Main()
        {
            string CharacterName = "Gregg";

            Console.WriteLine("Lost in Space!");
            Console.WriteLine("Welcome to Lost in Space, an RPG where you'll be faced with decisions that affect you, your crew, and everyone you care for.");
            Console.WriteLine("What is your name?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Hello, " + CharacterName + ". Good Luck.");
            Console.ReadKey();

           
        }
    }
}
