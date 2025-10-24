using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class DieRoller
    {
        public void CpuOneStart()
        {
            System.Random random = new System.Random();
            int die4 = random.Next(1, 5);
            int die6 = random.Next(1, 7);
            int die8 = random.Next(1, 9); 
            int die12 = random.Next(1, 13);
            int die20 = random.Next(1, 21);
            
            int computerOneTotal = 0;
            int computerTwoTotal = 0;
            int cpuOneScore = 0;
            int cpuTwoScore = 0;

            Debug.Log("It's computer 1 turn!");
            int optionOne = random.Next(1, 6);
            if (optionOne == 1)
            {
                Debug.Log("Computer 1 choose a D4");
                Debug.Log("It landed in a " + die4 + "!");
                computerOneTotal = die4;
            }
            else if (optionOne == 2)
            {
                Debug.Log("Compurer 1 choose a D6");
                Debug.Log("It landed in a " + die6 + "!");
                computerOneTotal = die6;
            }
            else if (optionOne == 3)
            {
                Debug.Log("Computer 1 choose a D8");
                Debug.Log("It landed in a " + die8 + "!");
                computerOneTotal = die8;
            }
            else if (optionOne == 4)
            {
                Debug.Log("Computer 1 choose a D12");
                Debug.Log("It landed in a " + die12 + "!");
                computerOneTotal = die12;
            }
            else if (optionOne == 5)
            {
                Debug.Log("Computer 1 choose a D20");
                Debug.Log("It landed in a " + die20 + "!");
                computerOneTotal = die20;
            }
           
            Debug.Log("It's the computer 2 turn!");
            int optionTwo = random.Next(1, 6);
            if (optionTwo == 1)
            {
                Debug.Log("Computer 2 choose a D4");
                Debug.Log("It landed in a " + die4 + "!");
                computerTwoTotal = die4;
            }
            else if (optionTwo == 2)
            {
                Debug.Log("Computer 2 choose a D6");
                Debug.Log("It landed in a " + die6 + "!");
                computerTwoTotal = die6;
            }
            else if (optionTwo == 3)
            {
                Debug.Log("Computer 2 choose a D8");
                Debug.Log("It landed in a " + die8 + "!");
                computerTwoTotal = die8;
            }
            else if (optionTwo == 4)
            {
                Debug.Log("Computer 2 choose a D12");
                Debug.Log("It landed in a " + die12 + "!");
                computerTwoTotal = die12;
            }
            else if (optionTwo == 5)
            {
                Debug.Log("Computer 2 choose a D20");
                Debug.Log("It landed in a " + die20 + "!");
                computerTwoTotal = die20;
            }
            if (computerTwoTotal > computerOneTotal)
            {
                Debug.Log("Computer 2 wins!!!");
                cpuTwoScore = +1;
            }
            else if (computerTwoTotal < computerOneTotal)
            {
                Debug.Log("Computer 1 wins!!!");
                cpuOneScore = +1;
            }
            else
            {
                Debug.Log("It's a tie!");
            }
            Debug.Log("The score is--> Computer 1: " + cpuOneScore + " Computer 2: " + cpuTwoScore);
        }
        public void CpuTwoStart() //It was easier for me to have the dice rolling for the player and the computer in different public voids
        {
            System.Random random = new System.Random();
            int die4 = random.Next(1, 5);
            int die6 = random.Next(1, 7);
            int die8 = random.Next(1, 9);
            int die12 = random.Next(1, 13);
            int die20 = random.Next(1, 21);
            int computerOneTotal = 0;
            int computerTwoTotal = 0;
            int cpuOneScore = 0;
            int cpuTwoScore = 0;

            Debug.Log("It's computer 2 turn!");
            int optionTwo = random.Next(1, 6);
            if (optionTwo == 1)
            {
                Debug.Log("Computer 2 choose a D4");
                Debug.Log("It landed in a " + die4 + "!");
                computerTwoTotal = die4;
            }
            else if (optionTwo == 2)
            {
                Debug.Log("Computer 2 choose a D6");
                Debug.Log("It landed in a " + die6 + "!");
                computerTwoTotal = die6;
            }
            else if (optionTwo == 3)
            {
                Debug.Log("Computer 2 choose a D8");
                Debug.Log("It landed in a " + die8 + "!");
                computerTwoTotal = die8;
            }
            else if (optionTwo == 4)
            {
                Debug.Log("Computer 2 choose a D12");
                Debug.Log("It landed in a " + die12 + "!");
                computerTwoTotal = die12;
            }
            else if (optionTwo == 5)
            {
                Debug.Log("Computer 2 choose a D20");
                Debug.Log("It landed in a " + die20 + "!");
                computerTwoTotal = die20;
            }

            Debug.Log("It's computer 1 turn!");
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

            if (computerTwoTotal > computerOneTotal)
            {
                Debug.Log("Computer 2 wins!!!");
                cpuTwoScore = +1;
            }
            else if (computerTwoTotal < computerOneTotal)
            {
                Debug.Log("Computer 1 wins!!!");
                cpuOneScore = +1;
            }
            else if (computerTwoTotal == computerOneTotal)
            {
                Debug.Log("It's a tie!");
            }
            Debug.Log("The score is--> Computer 1: " + cpuOneScore + " Computer 2: " + cpuTwoScore);
        } 
    }
}
