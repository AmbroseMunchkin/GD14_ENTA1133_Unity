using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class DieRoller
    {
        public void PlayerStart()
        {
            System.Random random = new System.Random();
            int die4 = random.Next(1, 5);
            int die6 = random.Next(1, 7);
            int die8 = random.Next(1, 9); 
            int die12 = random.Next(1, 13);
            int die20 = random.Next(1, 21);
            
            int computerOneTotal = 0;
            int computerTwoTotal = 0;
            int playerscore = 0;
            int computerscore = 0;

            Debug.Log("Pick your dice!");
            Debug.Log("1.- D4 , 2.- D6, 3.- D8 , 4.- D12, 5.- D20");
            Debug.Log("Type your option");
            int optionOne = random.Next(1, 6);
            if (optionOne == 1)
            {
                Debug.Log("You choose a D4");
                Debug.Log("It landed in a " + die4 + "!");
                computerOneTotal = die4;
            }
            else if (optionOne == 2)
            {
                Debug.Log("You choose a D6");
                Debug.Log("It landed in a " + die6 + "!");
                computerOneTotal = die6;
            }
            else if (optionOne == 3)
            {
                Debug.Log("You choose a D8");
                Debug.Log("It landed in a " + die8 + "!");
                computerOneTotal = die8;
            }
            else if (optionOne == 4)
            {
                Debug.Log("You choose a D12");
                Debug.Log("It landed in a " + die12 + "!");
                computerOneTotal = die12;
            }
            else if (optionOne == 5)
            {
                Debug.Log("You choose a D20");
                Debug.Log("It landed in a " + die20 + "!");
                computerOneTotal = die20;
            }
            else
            {
                Debug.Log("Invalid choice, using the d6 as default");
                Debug.Log("It landed in a " + die6 + "!");
                computerOneTotal = die6;
            }
            Debug.Log("It's the computer 2 turn!");
            System.Random random1 = new System.Random();
            int randomdice = random1.Next(1, 6);
            if (randomdice == 1)
            {
                Debug.Log("Computer choose a D4 and got " + die4);
                computerTwoTotal = die4;
            }
            else if (randomdice == 2)
            {
                Debug.Log("Computer choose a D6 and got " + die6);
                computerTwoTotal = die6;
            }
            else if (randomdice == 3)
            {
                Debug.Log("Computer choose a D8 and got " + die8);
                computerTwoTotal = die8;
            }
            else if (randomdice == 4)
            {
                Debug.Log("Computer choose a D12 and got " + die12);
                computerTwoTotal = die12;
            }
            else if (randomdice == 5)
            {
                Debug.Log("Computer choose a D20 and got " + die20);
                computerTwoTotal = die20;
            }
            Console.WriteLine();
            if (computerTwoTotal > computerOneTotal)
            {
                Debug.Log("The computer wins!!!");
                computerscore = +1;
            }
            else if (computerTwoTotal < computerOneTotal)
            {
                Debug.Log("You won!!!");
                playerscore = +1;
            }
            else if (computerTwoTotal == computerOneTotal)
            {
                Debug.Log("It's a tie! Re-rolling time it is!");
                PlayerStart();
            }
            Console.WriteLine();
            Debug.Log("The score is--> Player: " + playerscore + " Computer: " + computerscore);
        }
        public static void ComputerRolls() //It was easier for me to have the dice rolling for the player and the computer in different public voids
        {
            System.Random random = new System.Random();
            int die4 = random.Next(1, 5);
            int die6 = random.Next(1, 7);
            int die8 = random.Next(1, 9);
            int die12 = random.Next(1, 13);
            int die20 = random.Next(1, 21);
            int computerOneTotal = 0;
            int computerTwoTotal = 0;
            int playerscore = 0;
            int computerscore = 0;
            System.Random random1 = new System.Random();
            int randomdice = random1.Next(1, 6);
            if (randomdice == 1)
            {
                Debug.Log("Computer choose a D4 and got " + die4);
                computerTwoTotal = die4;
            }
            else if (randomdice == 2)
            {
                Debug.Log("Computer choose a D6 and got " + die6);
                computerTwoTotal = die6;
            }
            else if (randomdice == 3)
            {
                Debug.Log("Computer choose a D8 and got " + die8);
                computerTwoTotal = die8;
            }
            else if (randomdice == 4)
            {
                Debug.Log("Computer choose a D12 and got " + die12);
                computerTwoTotal = die12;
            }
            else if (randomdice == 5)
            {
                Debug.Log("Computer choose a D20 and got " + die20);
                computerTwoTotal = die20;
            }
            Console.WriteLine(); 
            Debug.Log("It's your turn! Pick your dice!");
            Debug.Log("1.- D4 , 2.- D6, 3.- D8 , 4.- D12, 5.- D20");            //Pretty much the same as the player starts, just switching positions, i tried to make everything more optimized
            Debug.Log("Type your option");
            string optionOne = Console.ReadLine();
            if (optionOne == "1")
            {
                Debug.Log("You choose a D4");
                Debug.Log("It landed in a " + die4 + "!");
                computerOneTotal = die4;
            }
            else if (optionOne == "2")
            {
                Debug.Log("You choose a D6");
                Debug.Log("It landed in a " + die6 + "!");
                computerOneTotal = die6;
            }
            else if (optionOne == "3")
            {
                Debug.Log("You choose a D8");
                Debug.Log("It landed in a " + die8 + "!");
                computerOneTotal = die8;
            }
            else if (optionOne == "4")
            {
                Debug.Log("You choose a D12");
                Debug.Log("It landed in a " + die12 + "!");
                computerOneTotal = die12;
            }
            else if (optionOne == "5")
            {
                Debug.Log("You choose a D20");
                Debug.Log("It landed in a " + die20 + "!");
                computerOneTotal = die20;
            }
            else
            {
                Debug.Log("Invalid choice, using the d6 as default");
                Debug.Log("It landed in a " + die6 + "!");
                computerOneTotal = die6;
            }

            if (computerTwoTotal > computerOneTotal)
            {
                Debug.Log("The computer wins!!!");
                computerscore = +1;
            }
            else if (computerTwoTotal < computerOneTotal)
            {
                Debug.Log("You won!!!");
                playerscore = +1;
            }
            else if (computerTwoTotal == computerOneTotal)
            {
                Debug.Log("It's a tie! Re-rolling time it is!");
                PlayerStart();                                                              //Used a lot of if and else, but it was the only way i could make it work
            }
            Debug.Log("The score is--> Player: " + playerscore + " Computer: " + computerscore);
        } 
    }
}
