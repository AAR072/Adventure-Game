using System;
namespace adventuregame
{
    internal class Program
    {
        public static string playerInput;

        public static void Main()
        {
            // Create new player
            player player = new player();
            // Ask player name
            Console.WriteLine("Welcome to Escape the Tomb. A text based adventure game where your goal is to escape the tomb. What is your name?");
            player.askPlayerName();
            Console.WriteLine($"Well {player.playerName}, you need to escape this room you are in. Look around by saying 'look'");
            playerInput = Console.ReadLine();
            player.getPlayerInput(playerInput);
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}