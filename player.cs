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
        public static void askPlayerName() {
            playerName = Console.ReadLine();
            if (String.IsNullOrEmpty(playerName)) {
                Console.WriteLine("That name is not valid. Please try again");
                askPlayerName();
            }
        }
        // Function to parse input and trigger required function
        public static string getPlayerInput(string textPlayerInput) {
            textPlayerInput = textPlayerInput.ToLower();
            for (int Iinput = 0; Iinput < playerActions.Length; Iinput++) {
                if (textPlayerInput.Equals(playerActions[Iinput])) {
                    if (Iinput == 0) {
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
        public static bool isValidObject(string roomSection) {
            for (int IroomObject = 0; IroomObject < player.availableObjects.Length; IroomObject++) {
                if (roomSection.Equals(player.availableObjects[IroomObject])) {
                    return true;
                }
            }
            return false;
        }

        // Function to add object to inventory
        public static void addObject(string objectToAdd) {
            int checkCount = 0;
            for (int IobjectToAdd = 0; IobjectToAdd < player.inventory.Length; IobjectToAdd++) {
                checkCount++;
                if (player.inventory[IobjectToAdd].Equals("n")) {
                    player.inventory[IobjectToAdd] = objectToAdd;
                    Console.WriteLine("Added " + objectToAdd + " to inventory");
                    return;
                }
            }
            if (checkCount == player.inventory.Length) {
                Console.WriteLine("Your inventory is full. Drop or use an item to empty a slot");
            }
        }

        // Function to check where to look
        public static void look(room lookRoomObject) {
            Console.WriteLine("Which direction do you want to look in? You can look 'left', 'right', 'forward', 'back', 'up', 'down'");
            string inputLookDirection = Console.ReadLine();
            bool validLookDirection = false;
            for (int Ilook = 0; Ilook < lookDirections.Length; Ilook++) {
                if (inputLookDirection.Equals(lookDirections[Ilook])) {
                    Console.WriteLine($"You look {lookDirections[Ilook]}");
                    validLookDirection = true;
                    // Annoying if statements for looking, here we go
                    if (lookDirections[Ilook] == "left") {
                        if (isValidObject(lookRoomObject.leftRoomObject)) {
                            Console.WriteLine($"You pick up a {lookRoomObject.leftRoomObject}");
                            addObject(lookRoomObject.leftRoomObject);
                        } else {
                            Console.WriteLine("There is nothing there");
                        }
                    }
                    if (lookDirections[Ilook] == "right") {
                        if (isValidObject(lookRoomObject.rightRoomObject)) {
                            Console.WriteLine($"You pick up a {lookRoomObject.rightRoomObject}");
                            addObject(lookRoomObject.rightRoomObject);
                        } else {
                            Console.WriteLine("There is nothing there");
                        }
                    }
                    if (lookDirections[Ilook] == "up") {
                        if (isValidObject(lookRoomObject.upRoomObject)) {
                            Console.WriteLine($"You pick up a {lookRoomObject.upRoomObject}");
                            addObject(lookRoomObject.upRoomObject);
                        } else {
                            Console.WriteLine("There is nothing there");
                        }
                    }
                    if (lookDirections[Ilook] == "down") {
                        if (isValidObject(lookRoomObject.downRoomObject)) {
                            Console.WriteLine($"You pick up a {lookRoomObject.downRoomObject}");
                            addObject(lookRoomObject.downRoomObject);
                        } else {
                            Console.WriteLine("There is nothing there");
                        }
                    }
                    if (lookDirections[Ilook] == "forward") {
                        if (isValidObject(lookRoomObject.forwardRoomObject)) {
                            Console.WriteLine($"You pick up a {lookRoomObject.forwardRoomObject}");
                            addObject(lookRoomObject.forwardRoomObject);
                        } else {
                            Console.WriteLine("There is nothing there");
                        }
                    }
                    if (lookDirections[Ilook] == "back") {
                        if (isValidObject(lookRoomObject.backRoomObject)) {
                            Console.WriteLine($"You pick up a {lookRoomObject.backRoomObject}");
                            addObject(lookRoomObject.backRoomObject);
                        } else {
                            Console.WriteLine("There is nothing there");
                        }
                    }
                }
            }
            if (!validLookDirection) {
                Console.WriteLine("That is not a valid look direction");
            }
        }
        }
        }