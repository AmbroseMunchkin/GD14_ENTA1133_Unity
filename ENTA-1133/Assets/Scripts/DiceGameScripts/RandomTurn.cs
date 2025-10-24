using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class RandomTurn
    {
         
        public void Turn()
        {
            DieRoller dieRoller = new DieRoller();
            System.Random random = new System.Random();

            int playerTurn = random.Next(1, 3); //Wanted to make the random turn simple and in it's own script to use it in future proyects

            if (playerTurn == 1)
            {
                Console.WriteLine("You go first!"); //Wanted to use the player name but i dont know how to call the username from the player script
                Console.WriteLine();
                dieRoller.CpuOneStart();
                Console.WriteLine();
                
            }
            else
            {
                Console.WriteLine("Computer goes first!");
                dieRoller.CpuTwoStart();
                Console.WriteLine();
            }
        }
    }
}
