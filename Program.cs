/*
To do:
Doorways for changing rooms
*/
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

            //Introduce player to using items
            Console.WriteLine($"Items in your inventory can be used on different things. You can say 'use' and you will be promted with an item and something to use it on. Try that now.");
            playerInput = Console.ReadLine();
            player.playerInputResult = player.getPlayerInput(playerInput);
            if (player.playerInputResult.Equals("look"))
            {
                // Look using current room 
                player.look(currentRoom);
            }
            // If player wants to view inventory
            if (player.playerInputResult.Equals("inv"))
            {
                player.displayInventory();
            }
            // If player wants to use item
            if (player.playerInputResult.Equals("use"))
            {
                player.useItem(currentRoom);

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
                    // Look using current room 
                    player.look(currentRoom);
                }
                // If player wants to view inventory
                if (player.playerInputResult.Equals("inv"))
                {
                    player.displayInventory();
                }
                // If player wants to use item
                if (player.playerInputResult.Equals("use"))
                {
                    player.useItem(currentRoom);

                }
            }
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
// AA wuz here help me