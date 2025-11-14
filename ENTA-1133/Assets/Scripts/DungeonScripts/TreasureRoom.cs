using UnityEngine;

public class TreasureRoom : RoomBase
{
    public override void OnRoomEntered()
    {
        Debug.Log("You enter a treasure room");
    }
    public override void OnRoomExited()
    {
        Debug.Log("You exit the treasure room");
    }
    public override void OnRoomSearched()
    {
        Debug.Log("You search the treasure room");
    }
}
