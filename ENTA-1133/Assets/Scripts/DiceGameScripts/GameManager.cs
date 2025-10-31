﻿using System;
using System.Data;
using UnityEngine;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class GameManager : MonoBehaviour
    {
        public void Start()
        {
            Debug.Log("GameManager Constructor Start");


            StartGame();

            Debug.Log("GameManager Constructor End");
        }

        public void StartGame()
        {
            Debug.Log("Hello, World!");
            Map gameMap = new Map();
            gameMap.InitializeFlexible();
        }
        public static Player player = new Player();

        //DateOnly today = DateOnly.FromDateTime(DateTime.Now);

        //private Map Map = new Map();
        int x;
        int y;

        //private Room playerCurrentRoom;
        //private Room playerLastRoom;

        // constants
        private const int MapX = 3;
        private const int MapY = 3;

        public static bool gameIsRunning = false;

        public void ProgramStart()
        {
            // What does the game need to do Arlet?
            // Say Hello
            Intro();
            // Get Player Name
            player.User(); //Fixed how the intro is since it was rude to start by asking the player name
            GameExplanation();

            Console.WriteLine("Do you want to wander the world? Type \"yes\" to continue");
            gameIsRunning = Console.ReadLine() == "yes";

            // * GameLoop begins * * Ending on player reaching 0 hp || surrender || win condition

            while (gameIsRunning)
            {
                // At the start of the loop set any variables that will need to reset when the game resets (i.e. play again)
                InitializeNewGame();

                // Enter the first room
                //playerCurrentRoom.OnEnter(player);

                // Setup is complete
                // Begin the player loop
                GameDecisionLoop();

                // Ask the player if they want to play again
                Console.WriteLine("Try again? Input \"yes\"");
                gameIsRunning = Console.ReadLine() == "yes";
            }

            // Final goodbye message REGARDLESS OF WHETHER THEY WON OR LOST, this is just the final goodbye
            Console.Write("The program will now close. Thank you.");
        }

        private void InitializeNewGame()
        {
            // Initialize Map
            //Map.InitializeFlexible(MapX, MapY); //Initialized the map and assigned rooms

            // Set the player current room
            // MUST BE DONE AFTER MAKING THE MAP!
            //playerCurrentRoom = Map.StartRoom(1, 1);

            // TODO
            // Set up the Player, reset player, default equipment, etc etc.
            //player.Reset();
        }

        private void GameDecisionLoop()
        {
            while (gameIsRunning)
            {
                bool validInput;
                string choice;
                // Input validation loop
                do
                {
                    choice = GetPlayerChoiceForCurrentStep();
                    validInput = choice != "Error";
                }
                while (validInput == false);

                ResolveCurrentChoice(choice);
                // What CAN happen based on their choices?
                // 1 Move
                // 2 Inventory
                // 3 Surrender
                // 4 Test fight
                // these will have to resolve however they need to
                // then the game should should come back to this point


                // If the player dies during a combat, then gameIsRunning will be false, and we will not loop.
            }
        }
        private void Intro()
        { //This greats the player and shows the game name
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Hello, hello hello! Uh, welcome to");
            Console.WriteLine(" ___   ___   _     _         ___   ___       ___   _   ____ \r\n| |_) / / \\ | |   | |       / / \\ | |_)     | | \\ | | | |_  \r\n|_| \\ \\_\\_/ |_|__ |_|__     \\_\\_/ |_| \\     |_|_/ |_| |_|__ \r\n                                                            \r\n                                                            \r\n                                                            ");
            Console.WriteLine("A place where your soul is at stake!");
            //Console.WriteLine("Today is: " + today);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine();
        }

        private void Outro()
        { //This is where we say goodbye to the player
            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Thank you for keeping me entertained dear wandering soul~");
            Console.WriteLine("You fought for your soul with great bravery; you can keep it...");
            Console.WriteLine("░        ░░░      ░░░       ░░░░░░░░░   ░░░  ░░░      ░░░  ░░░░  ░\r\n▒  ▒▒▒▒▒▒▒▒  ▒▒▒▒  ▒▒  ▒▒▒▒  ▒▒▒▒▒▒▒▒    ▒▒  ▒▒  ▒▒▒▒  ▒▒  ▒  ▒  ▒\r\n▓      ▓▓▓▓  ▓▓▓▓  ▓▓       ▓▓▓▓▓▓▓▓▓  ▓  ▓  ▓▓  ▓▓▓▓  ▓▓        ▓\r\n█  ████████  ████  ██  ███  █████████  ██    ██  ████  ██   ██   █\r\n█  █████████      ███  ████  ████████  ███   ███      ███  ████  █\r\n                                                                  ");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
        }
        private void GameExplanation()
        { //The rules of the game
            Console.WriteLine();
            Console.WriteLine("You can travel this 3x3 dungeon full of treasure chests!\nBut be careful, there's eyes watching all your movements...\n");
            Console.WriteLine("You will start with a sword and a maze, but you can find potion in the chests, those will be helpful~\n");
            //Console.WriteLine($"Be aware " + player.username + " that once a potion is used it will disappear never to be seen again.\n");
        }

        public string GetPlayerChoiceForCurrentStep()
        {
            // Show the player all their options.
            // Validate their input
            // Get their decision
            Console.WriteLine("=======");
            //Console.WriteLine("Rooms Visited: " + player.NumberOfRoomsVisited + " of " + Map.NumberOfRooms);
            //Console.WriteLine("You are in " + playerCurrentRoom.GetNameRoom() + ", what do you want to do now?\n"); //I give the player its options
            Console.WriteLine("1.-Move\n2.-Check your inventory\n3.-Give up your soul to me\n4.-Search the room");

            string decision = Console.ReadLine();
            switch (decision)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    return decision;
                default:
                    return "Error";
            }
        }

        public void ResolveCurrentChoice(string decision)
        {
            switch (decision)
            {
                case "1":
                    //playerCurrentRoom = Map.MoveDecisionLoop(playerCurrentRoom, player);
                    break;
                case "2":
                    //player.Inventory(); //Here it prints the player inventory
                    Console.WriteLine();
                    break;
                case "3":
                    gameIsRunning = false;
                    Outro(); //Ends the run
                    break;
                case "4":
                    {
                        //playerCurrentRoom.SearchRoom();
                        break;
                    }
                default:
                    Console.WriteLine("I couldn't resolve the input of " + decision);
                    break;
            }
        }
    }
}