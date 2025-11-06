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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
