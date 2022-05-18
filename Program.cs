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
            room entrance = new room("entrance");
            // Setting up entrance room
            entrance.leftRoomObject = player.availableObjects[0];
            entrance.rightRoomObject = player.availableObjects[5];
            entrance.forwardViewRoomObject = entrance.roomFeatures[3];
            room currentRoom = entrance;

            // Ask player name
            Console.WriteLine("Welcome to Escape the Tomb. A text based adventure game where your goal is to escape. What is your name?");
            player.askPlayerName();

            // Introduce player to looking
            Console.WriteLine($"Well {player.playerName}, you need to escape this room you are in. Look around by saying 'look'. You will be prompted to enter a direction. Explore the room around you.");

            // Introduce player to giving input
            playerInput = Console.ReadLine();
            player.playerInputResult = player.getPlayerInput(playerInput);
            // If player wants to look
            if (player.playerInputResult.Equals("look"))
            {
                player.look(currentRoom);
            }


            // Introduce player to inventory
            Console.WriteLine($"Items you pick up are stored in your inventory. View it by writing 'inv'");
            playerInput = Console.ReadLine();
            player.playerInputResult = player.getPlayerInput(playerInput);
            if (player.playerInputResult.Equals("look"))
            {
                player.look(currentRoom);
            }
            if (player.playerInputResult.Equals("inv"))
            {
                player.displayInventory();
            }

            // Loop while alive
            while (player.gameState.Equals("alive"))
            {
                Console.WriteLine("What do you want to do?");
                playerInput = Console.ReadLine();
                player.playerInputResult = player.getPlayerInput(playerInput);
                // If player wants to look
                if (player.playerInputResult.Equals("look"))
                {
                    // Look left using current room 
                    player.look(entrance);
                }
            }
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
// AA wuz here help me