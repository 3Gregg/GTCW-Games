using System;
namespace Lost_in_Space
{
    class Program
    {
        static void Main();
        {
            Dialog(CharacterName + "..." + CharacterName "! Wake up!");
        }
        //change the color of text when a character talks
        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
            Console.ResetColor();        
        }

    }
}
