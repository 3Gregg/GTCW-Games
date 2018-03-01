/*
 * Lost In Space
 * by Gregg Travitz, February 28th, 2018
 * 
 * This work is a derivative of
 * 'C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */
using System;

namespace Lost_in_Space
{
    public static class Game
    {
        //character name
        static string CharacterName = "Gregg";

        //print out game title and overview
        public static void StartGame()
        {
            Console.WriteLine("Lost in Space!");
            Console.WriteLine("Welcome to Lost in Space, an RPG where you'll be faced with decisions that affect you, your crew, and everyone you care for.");
            NameCharacter();
        }

        //ask player for a name, and save it
        static void NameCharacter()
        {
            Console.WriteLine("What is your name?");

            CharacterName = Console.ReadLine();

            Console.WriteLine("Hello, " + CharacterName + ". Good Luck.");
        }
        
    }
    class Item
    {
        
    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
}
