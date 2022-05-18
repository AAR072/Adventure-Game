using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventuregame
{
    internal class player
    {
        public static string playerName;

        public static string playerInputResult;
        public static string gameState = "alive";
        // Array of all available actions
        public static string[] playerActions = {
            //0      1
            "look", "inv"
            };
        public static string[] lookDirections = {
            //0     1          2        3       4       5
            "left", "right", "forward", "back", "up", "down"

        };
        public static string[] availableObjects = {
            //0       1       2        3     4       5
            "key", "note", "knife", "rope", "rock", "flashlight"
        };
        public static string[] inventory = {
            //0   1    2     3   4    5   6  
            "n", "n", "n", "n", "n", "n", "n"
        };
        // Function to ask the player's name
        public static void askPlayerName()
        {
            playerName = Console.ReadLine();
            if (String.IsNullOrEmpty(playerName))
            {
                Console.WriteLine("That name is not valid. Please try again");
                askPlayerName();
            }
        }
        // Function to parse input and trigger required function
        public static string getPlayerInput(string textPlayerInput)
        {
            textPlayerInput = textPlayerInput.ToLower();
            for (int Iinput = 0; Iinput < playerActions.Length; Iinput++)
            {
                if (textPlayerInput.Equals(playerActions[Iinput]))
                {
                    if (Iinput == 0)
                    {
                        return "look";
                    }
                    if (Iinput == 1)
                    {
                        return "inv";
                    }
                }
            }
            return "";
        }

        // Function to loop through all objects and test if object exists
        public static bool isValidObject(string roomSection)
        {
            for (int IroomObject = 0; IroomObject < player.availableObjects.Length; IroomObject++)
            {
                if (roomSection.Equals(player.availableObjects[IroomObject]))
                {
                    return true;
                }
            }
            return false;
        }

        // Function to add object to inventory
        public static void addObject(string objectToAdd)
        {
            int checkCount = 0;
            for (int IobjectToAdd = 0; IobjectToAdd < player.inventory.Length; IobjectToAdd++)
            {
                checkCount++;
                if (player.inventory[IobjectToAdd].Equals("n"))
                {
                    player.inventory[IobjectToAdd] = objectToAdd;
                    Console.WriteLine("Added " + objectToAdd + " to inventory");
                    return;
                }
            }
            if (checkCount == player.inventory.Length)
            {
                Console.WriteLine("Your inventory is full. Drop or use an item to empty a slot");
            }
        }

        // Function to display inventory
        public static void displayInventory()
        {
            if (!player.inventory[0].Equals("n"))
            {
                Console.WriteLine($"Slot 1: {player.inventory[0]}");
            }
            else
            {
                Console.WriteLine($"Slot 1: Empty");
            }
            if (!player.inventory[1].Equals("n"))
            {
                Console.WriteLine($"Slot 2: {player.inventory[1]}");
            }
            else
            {
                Console.WriteLine($"Slot 2: Empty");
            }
            if (!player.inventory[2].Equals("n"))
            {
                Console.WriteLine($"Slot 3: {player.inventory[2]}");
            }
            else
            {
                Console.WriteLine($"Slot 3: Empty");
            }
            if (!player.inventory[3].Equals("n"))
            {
                Console.WriteLine($"Slot 4: {player.inventory[3]}");
            }
            else
            {
                Console.WriteLine($"Slot 4: Empty");
            }
            if (!player.inventory[4].Equals("n"))
            {
                Console.WriteLine($"Slot 5: {player.inventory[4]}");
            }
            else
            {
                Console.WriteLine($"Slot 5: Empty");
            }
            if (!player.inventory[5].Equals("n"))
            {
                Console.WriteLine($"Slot 6: {player.inventory[5]}");
            }
            else
            {
                Console.WriteLine($"Slot 6: Empty");
            }
            if (!player.inventory[6].Equals("n"))
            {
                Console.WriteLine($"Slot 7: {player.inventory[6]}");
            }
            else
            {
                Console.WriteLine($"Slot 7: Empty");
            }
        }

        // Function to check if room feature is there
        public static void showRoomFeature(room lookRoomFeature, string direction)
        {
            int lookRoomFeatureCounter = 0;
            // Yay more if statements!!!!!!!!
            for (int IlookRoomFeature = 0; IlookRoomFeature < lookRoomFeature.roomFeatures.Length; IlookRoomFeature++)
            {
                // If there is a room feature on the left of the room
                if (!lookRoomFeature.leftViewRoomObject.Equals("") && direction.Equals("left"))
                {
                    if (IlookRoomFeature == 0 && lookRoomFeature.leftViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a bookshelf");
                        break;
                    }
                    if (IlookRoomFeature == 1 && lookRoomFeature.leftViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a large chasm");
                        break;
                    }
                    if (IlookRoomFeature == 2 && lookRoomFeature.leftViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see large sharp spikes");
                        break;
                    }
                    if (IlookRoomFeature == 3 && lookRoomFeature.leftViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a door. It is locked");
                        break;
                    }
                    if (IlookRoomFeature == 4 && lookRoomFeature.leftViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a old dusty door");
                        break;
                    }
                    if (IlookRoomFeature == 5 && lookRoomFeature.leftViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a dirty small pool of water");
                        break;
                    }
                }
                // If there is a room feature on the right side of the room
                if (!lookRoomFeature.rightViewRoomObject.Equals("") && direction.Equals("right"))
                {
                    if (IlookRoomFeature == 0 && lookRoomFeature.rightViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a bookshelf");
                        break;
                    }
                    if (IlookRoomFeature == 1 && lookRoomFeature.rightViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a large chasm");
                        break;
                    }
                    if (IlookRoomFeature == 2 && lookRoomFeature.rightViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see large sharp spikes");
                        break;
                    }
                    if (IlookRoomFeature == 3 && lookRoomFeature.rightViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a door. It is locked");
                        break;
                    }
                    if (IlookRoomFeature == 4 && lookRoomFeature.rightViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a old dusty door");
                        break;
                    }
                    if (IlookRoomFeature == 5 && lookRoomFeature.rightViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a dirty small pool of water");
                        break;
                    }
                }
                // If there is a room feature on the front of the room
                if (!lookRoomFeature.forwardViewRoomObject.Equals("") && direction.Equals("forward"))
                {
                    if (IlookRoomFeature == 0 && lookRoomFeature.forwardViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a bookshelf");
                        break;
                    }
                    if (IlookRoomFeature == 1 && lookRoomFeature.forwardViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a large chasm");
                        break;
                    }
                    if (IlookRoomFeature == 2 && lookRoomFeature.forwardViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see large sharp spikes");
                        break;
                    }
                    if (IlookRoomFeature == 3 && lookRoomFeature.forwardViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a door. It is locked");
                        break;
                    }
                    if (IlookRoomFeature == 4 && lookRoomFeature.forwardViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a old dusty door");
                        break;
                    }
                    if (IlookRoomFeature == 5 && lookRoomFeature.forwardViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a dirty small pool of water");
                        break;
                    }
                }
                // If there is a room feature in the back of the room
                if (!lookRoomFeature.backViewRoomObject.Equals("") && direction.Equals("back"))
                {
                    if (IlookRoomFeature == 0 && lookRoomFeature.backViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a bookshelf");
                        break;
                    }
                    if (IlookRoomFeature == 1 && lookRoomFeature.backViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a large chasm");
                        break;
                    }
                    if (IlookRoomFeature == 2 && lookRoomFeature.backViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see large sharp spikes");
                        break;
                    }
                    if (IlookRoomFeature == 3 && lookRoomFeature.backViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a door. It is locked");
                        break;
                    }
                    if (IlookRoomFeature == 4 && lookRoomFeature.backViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a old dusty door");
                        break;
                    }
                    if (IlookRoomFeature == 5 && lookRoomFeature.backViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a dirty small pool of water");
                        break;
                    }

                }
            if (!lookRoomFeature.upViewRoomObject.Equals("") && direction.Equals("up"))
            {
                if (IlookRoomFeature == 0 && lookRoomFeature.upViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a bookshelf");
                        break;
                    }
                    if (IlookRoomFeature == 1 && lookRoomFeature.upViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a large chasm");
                        break;
                    }
                    if (IlookRoomFeature == 2 && lookRoomFeature.upViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see large sharp spikes");
                        break;
                    }
                    if (IlookRoomFeature == 3 && lookRoomFeature.upViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a door. It is locked");
                        break;
                    }
                    if (IlookRoomFeature == 4 && lookRoomFeature.upViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a old dusty door");
                        break;
                    }
                    if (IlookRoomFeature == 5 && lookRoomFeature.upViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a dirty small pool of water");
                        break;
                    }
            }
            if (!lookRoomFeature.downViewRoomObject.Equals("") && direction.Equals("down"))
            {
                if (IlookRoomFeature == 0 && lookRoomFeature.downViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a bookshelf");
                        break;
                    }
                    if (IlookRoomFeature == 1 && lookRoomFeature.downViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a large chasm");
                        break;
                    }
                    if (IlookRoomFeature == 2 && lookRoomFeature.downViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see large sharp spikes");
                        break;
                    }
                    if (IlookRoomFeature == 3 && lookRoomFeature.downViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a door. It is locked");
                        break;
                    }
                    if (IlookRoomFeature == 4 && lookRoomFeature.downViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a old dusty door");
                        break;
                    }
                    if (IlookRoomFeature == 5 && lookRoomFeature.downViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a dirty small pool of water");
                        break;
                    }
            }
            }

        }

        // Function to check where to look
        public static void look(room lookRoomObject)
        {
            Console.WriteLine("Which direction do you want to look in? You can look 'left', 'right', 'forward', 'back', 'up', 'down'");
            string inputLookDirection = Console.ReadLine();
            bool validLookDirection = false;
            for (int Ilook = 0; Ilook < lookDirections.Length; Ilook++)
            {
                if (inputLookDirection.Equals(lookDirections[Ilook]))
                {
                    Console.WriteLine($"You look {lookDirections[Ilook]}");
                    validLookDirection = true;
                    // Annoying if statements for looking, here we go
                    if (lookDirections[Ilook] == "left")
                    {
                        showRoomFeature(lookRoomObject, inputLookDirection);
                        if (isValidObject(lookRoomObject.leftRoomObject))
                        {
                            Console.WriteLine($"You pick up a {lookRoomObject.leftRoomObject}");
                            addObject(lookRoomObject.leftRoomObject);
                        }
                        else
                        {
                            Console.WriteLine("There is no item there");
                        }
                    }
                    if (lookDirections[Ilook] == "right")
                    {
                        showRoomFeature(lookRoomObject, inputLookDirection);
                        if (isValidObject(lookRoomObject.rightRoomObject))
                        {
                            Console.WriteLine($"You pick up a {lookRoomObject.rightRoomObject}");
                            addObject(lookRoomObject.rightRoomObject);
                        }
                        else
                        {
                            Console.WriteLine("There is no item there");
                        }
                    }
                    if (lookDirections[Ilook] == "up")
                    {
                        showRoomFeature(lookRoomObject, inputLookDirection);
                        if (isValidObject(lookRoomObject.upRoomObject))
                        {
                            Console.WriteLine($"You pick up a {lookRoomObject.upRoomObject}");
                            addObject(lookRoomObject.upRoomObject);
                        }
                        else
                        {
                            Console.WriteLine("There is no item there");
                        }
                    }
                    if (lookDirections[Ilook] == "down")
                    {
                        showRoomFeature(lookRoomObject, inputLookDirection);
                        if (isValidObject(lookRoomObject.downRoomObject))
                        {
                            Console.WriteLine($"You pick up a {lookRoomObject.downRoomObject}");
                            addObject(lookRoomObject.downRoomObject);
                        }
                        else
                        {
                            Console.WriteLine("There is no item there");
                        }
                    }
                    if (lookDirections[Ilook] == "forward")
                    {
                        showRoomFeature(lookRoomObject, inputLookDirection);
                        if (isValidObject(lookRoomObject.forwardRoomObject))
                        {
                            Console.WriteLine($"You pick up a {lookRoomObject.forwardRoomObject}");
                            addObject(lookRoomObject.forwardRoomObject);
                        }
                        else
                        {
                            Console.WriteLine("There is no item there");
                        }
                    }
                    if (lookDirections[Ilook] == "back")
                    {
                        showRoomFeature(lookRoomObject, inputLookDirection);
                        if (isValidObject(lookRoomObject.backRoomObject))
                        {
                            Console.WriteLine($"You pick up a {lookRoomObject.backRoomObject}");
                            addObject(lookRoomObject.backRoomObject);
                        }
                        else
                        {
                            Console.WriteLine("There is no item there");
                        }
                    }
                }
            }
            if (!validLookDirection)
            {
                Console.WriteLine("That is not a valid look direction");
            }
        }
    }
}