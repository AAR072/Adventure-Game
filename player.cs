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
        public static string gameState = "alive";
        // Array of all available actions
        public static string[] playerActions = {
            //0
            "look", 
            };
        public static string[] lookDirections = {
            //0     1          2        3       4       5
            "left", "right", "forward", "back", "up", "down"

        };
        public static string[] availableObjects = {
            //0       1       2        3     4       5
            "key", "note", "knife", "rope", "rock", "flashlight"

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
        public static void getPlayerInput(string textPlayerInput){
            textPlayerInput = textPlayerInput.ToLower();
            for (int Iinput = 0; Iinput < playerActions.Length; Iinput++){
                if(textPlayerInput.Equals(playerActions[Iinput])){
                    Console.WriteLine(Iinput);
                    if(Iinput == 0){
                        look();
                    }

                }
            }

        }
        // Function to check where to look
        public static void look(){
            Console.WriteLine("Which direction do you want to look in? You can look 'left', 'right', 'forward', 'back', 'up', 'down'");
            string inputLookDirection = Console.ReadLine();
            bool validLookDirection = false;
            for (int Ilook = 0; Ilook < lookDirections.Length; Ilook++){
                if(inputLookDirection.Equals(lookDirections[Ilook])){
                    Console.WriteLine($"You look {lookDirections[Ilook]}");
                    validLookDirection = true;
                    break;
                }
                }
            if(!validLookDirection){
                Console.WriteLine("That is not a valid look direction");
            }
            
            }
        }
    }

