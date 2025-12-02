using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatRoom : RoomBase
{
    [SerializeField] private Enemy[] EnemyPrefab; //The enemy gets spawned when the player searches or enters the room

    public override void OnRoomEntered()
    {
        Debug.Log("You enter a combat room");
    }
    public override void OnRoomExited()
    {
        Debug.Log("You exit the combat room");
    }
    public override void OnRoomSearched()
    {
        SceneManager.LoadScene("Battle");
        Debug.Log("You search the combat room");
    }
}