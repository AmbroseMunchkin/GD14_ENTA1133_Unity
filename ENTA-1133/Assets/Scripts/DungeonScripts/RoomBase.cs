using UnityEngine;

public class RoomBase : MonoBehaviour
{
    [SerializeField] private GameObject NorthDoorway, EastDoorway, SouthDoorway, WestDoorway;
    private RoomBase _north, _south, _east, _west;
    public void SetRooms(RoomBase roomNorth, RoomBase roomSouth, RoomBase roomEast, RoomBase roomWest)
    {
        _north = roomNorth;
        NorthDoorway.SetActive(_north == null);
        _east = roomEast;
        EastDoorway.SetActive(_east == null);
        _south = roomSouth;
        SouthDoorway.SetActive(_south == null);
        _west = roomWest;
        WestDoorway.SetActive(_west == null);
    }
    public virtual void OnRoomEntered()
    {
        Debug.Log("You enter an empty room");
    }
    public virtual void OnRoomExited()
    {
        Debug.Log("You exit the empty room");
    }
    public virtual void OnRoomSearched()
    {
        Debug.Log("You search the empty room");
    }
}
