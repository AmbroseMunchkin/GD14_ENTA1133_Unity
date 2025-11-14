using UnityEngine;

public class CombatRoom : RoomBase
{
    [SerializeField] private Enemy[] EnemyPrefab;

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
        Debug.Log("You search the combat room");
    }
}