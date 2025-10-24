using GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts;
using UnityEngine;

public class GameRunner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager gameManager = new GameManager();
        gameManager.ProgramStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
