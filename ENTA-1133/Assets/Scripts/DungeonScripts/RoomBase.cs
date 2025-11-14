using UnityEngine;

public class RoomBase : MonoBehaviour
{
    [SerializeField] private GameObject NorthDoorway, EastDoorway, SouthDoorway, WestDoorway;
    private RoomBase _north, _south, _east, _west;

    public RoomBase South { get => _south; set => _south = value; }
    public RoomBase North { get => _north; set => _north = value; }
    public RoomBase East { get => _east; set => _east = value; }
    public RoomBase West { get => _west; set => _west = value; }

    public void SetRooms(RoomBase roomNorth, RoomBase roomSouth, RoomBase roomEast, RoomBase roomWest)
    {
        North = roomNorth;
        NorthDoorway.SetActive(North == null);
        East = roomEast;
        EastDoorway.SetActive(East == null);
        South = roomSouth;
        SouthDoorway.SetActive(South == null);
        West = roomWest;
        WestDoorway.SetActive(West == null);
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
