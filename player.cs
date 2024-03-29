﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventuregame
{
    internal class player
    {
        public int globalInventoryNumber;
        public static string playerName;

        public static string playerInputResult;
        public static string gameState = "alive";

        // Array of all available actions
        public static string[] playerActions = {
            //0      1      2
            "look", "inv", "use"
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
                    if (Iinput == 2)
                    {
                        return "use";
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

        // Function to check if item is in inventory
        public bool isInventory(string item)
        {
            for (int k = 0; k < player.availableObjects.Length; k++)
            {
                if (item.Equals(player.inventory[k]))
                {
                    this.globalInventoryNumber = k;
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
            for (int i = 0; i < player.inventory.Length; i++)
            {
                string itemName = player.inventory[i];
                string slotStatus = itemName != "n" ? itemName : "Empty";
                Console.WriteLine($"Slot {i + 1}: {slotStatus}");
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
                    if (IlookRoomFeature == 6 && lookRoomFeature.leftViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a doorway to walk through");
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
                    if (IlookRoomFeature == 6 && lookRoomFeature.rightViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a doorway to walk through");
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
                    if (IlookRoomFeature == 6 && lookRoomFeature.forwardViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a doorway to walk through");
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
                    if (IlookRoomFeature == 6 && lookRoomFeature.backViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a doorway to walk through");
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
                    if (IlookRoomFeature == 6 && lookRoomFeature.upViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a doorway to walk through");
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
                    if (IlookRoomFeature == 6 && lookRoomFeature.downViewRoomObject.Equals(lookRoomFeature.roomFeatures[IlookRoomFeature]))
                    {
                        Console.WriteLine("You see a doorway to walk through");
                        break;
                    }
                }
            }

        }

        // Function to check if room contains feature

        public static bool isValidFeature(room featureRoom)
        {


            return false;
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
                            lookRoomObject.leftRoomObject = "";
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
                            lookRoomObject.rightRoomObject = "";
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
                            lookRoomObject.upRoomObject = "";
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
                            lookRoomObject.downRoomObject = "";
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
                            lookRoomObject.forwardRoomObject = "";
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
                            lookRoomObject.backRoomObject = "";
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

        // Function to delete an object from the inventory
        public void deleteItem()
        {
            player.inventory[globalInventoryNumber] = "n";

        }
        // Function to use item
        public void useItem(room lookRoomFeature)
        {
            string useItemObject;
            string exitInput;
            Console.WriteLine("What item do you want to use?");
            useItemObject = Console.ReadLine();
            // If the input is null
            if (String.IsNullOrEmpty(useItemObject))
            {
                Console.WriteLine("That is not a valid object. Write 'exit' to cancel or write press enter to use another item.");
                exitInput = Console.ReadLine();
                if (exitInput.Equals("exit"))
                {
                    return;
                }
            }

            // Check if input is a valid object
            if (isInventory(useItemObject))
            {
                // Check if feature exists in room
                if (useItemObject.Equals("key"))
                {
                    bool lockedDoorInRoom = false;
                    if (lookRoomFeature.leftViewRoomObject.Equals("lockeddoor"))
                    {

                        Console.WriteLine("Opening locked door.");
                        lockedDoorInRoom = true;
                        lookRoomFeature.leftViewRoomObject = lookRoomFeature.roomFeatures[6];
                        deleteItem();
                    }
                    if (lookRoomFeature.rightViewRoomObject.Equals("lockeddoor"))
                    {

                        Console.WriteLine("Opening locked door.");
                        lockedDoorInRoom = true;
                        lookRoomFeature.rightViewRoomObject = lookRoomFeature.roomFeatures[6];
                        deleteItem();
                    }
                    if (lookRoomFeature.forwardViewRoomObject.Equals("lockeddoor"))
                    {

                        Console.WriteLine("Opening locked door.");
                        lockedDoorInRoom = true;
                        lookRoomFeature.forwardViewRoomObject = lookRoomFeature.roomFeatures[6];
                        deleteItem();
                    }
                    if (lookRoomFeature.backViewRoomObject.Equals("lockeddoor"))
                    {

                        Console.WriteLine("Opening locked door.");
                        lockedDoorInRoom = true;
                        lookRoomFeature.backViewRoomObject = lookRoomFeature.roomFeatures[6];
                        deleteItem();
                    }
                    if (lookRoomFeature.upViewRoomObject.Equals("lockeddoor"))
                    {

                        Console.WriteLine("Opening locked door.");
                        lockedDoorInRoom = true;
                        lookRoomFeature.upViewRoomObject = lookRoomFeature.roomFeatures[6];
                        deleteItem();
                    }
                    if (lookRoomFeature.downViewRoomObject.Equals("lockeddoor"))
                    {

                        Console.WriteLine("Opening locked door.");
                        lockedDoorInRoom = true;
                        lookRoomFeature.downViewRoomObject = lookRoomFeature.roomFeatures[6];
                        deleteItem();
                    }
                    if (!lockedDoorInRoom)
                    {
                        Console.WriteLine("There is no locked door in the room. Write 'exit' to cancel or write press enter to use another item.");
                        exitInput = Console.ReadLine();
                        if (exitInput.Equals("exit"))
                        {
                            return;
                        }
                        else
                        {
                            this.useItem(lookRoomFeature);
                        }
                    }
                }
                
            }
            else
            {
                Console.WriteLine("That is not a valid object or it isn't in your inventory. Write 'exit' to cancel or write press enter to use another item.");
                exitInput = Console.ReadLine();
                if (exitInput.Equals("exit"))
                {
                    return;
                }
                else
                {
                    this.useItem(lookRoomFeature);
                }

            }


        }
    }
}