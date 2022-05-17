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
        // Array of all available actions
        public static string[] playerActions = {
            //1
            "look", 

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
            for (int i = 0; i < playerActions.Length; i++){
                if(textPlayerInput.Equals(playerActions[i])){
                    Console.WriteLine($"The input is {playerActions[i]}");

                }
            }

        }
    }
}
