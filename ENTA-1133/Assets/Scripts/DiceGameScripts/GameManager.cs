using System;
using UnityEngine;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class GameManager
    {
        public void ProgramStart()
        {
            //Player.User(); //Took this down since i dont need player username
            Intro(); 
            RollOrDie();
            Outro();
        }
        private void Intro()
        {
            DateTime today = DateTime.Now.Date;
            Debug.Log("Welcome to Dice Rolling! My name is Arlet Alcaraz and today is " + today);
            Debug.Log("Let's roll some dice! May the odds be ever in your favor\n");
        }
        private void RollOrDie()
        {
            RandomTurn randomTurn = new RandomTurn();
            randomTurn.Turn();
        }
        private static void Outro()
        {
            Debug.Log("Now this was a lot of rolling! So many possibilities with so few dice.\n");
            Debug.Log("Thanks for giving this a try! Have a wonderful day!");
        }
    }
}
