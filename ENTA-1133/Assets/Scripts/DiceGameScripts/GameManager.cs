using UnityEngine;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class GameManager
    {
        public void ProgramStart()
        {
            Player.User(); //Decided to add this one first so it looks more clean
            Intro(); 
            RollOrDie();
            Outro();
        }
        private void Intro()
        {
            Debug.Log("Let's roll some dice! May the odds be ever in your favor\n");
        }
        private void RollOrDie()
        {
            RandomTurn.Turn();
        }
        private static void Outro()
        {
            Debug.Log("Now this was a lot of rolling! So many possibilities with so few dice.\n");
            Debug.Log("Thanks for giving this a try! Have a wonderful day!");
        }
    }
}
