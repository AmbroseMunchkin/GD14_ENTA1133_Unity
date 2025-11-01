using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] private RoomBase[] RoomPrefabs;
    [SerializeField] private float RoomSize = 1;
    [SerializeField] private int MapSize = 3;
    private RoomBase[,] _map;
    public void CreateMap()
    {
        _map = new RoomBase[MapSize, MapSize];
        for (int x = 0; x < MapSize; x++)
        {
            for (int z = 0; z < MapSize; z++)
            {
                Vector3 coords = new Vector3(x * RoomSize, 3 , z * RoomSize);

                var roomInstance = Instantiate(RoomPrefabs[Random.Range(0, RoomPrefabs.Length)], transform);

                roomInstance.transform.position = coords;

                //roomInstance.SetRoomLocation(coords);
                //_rooms.Add(coords, roomInstance);
                _map[x, z] = roomInstance;
            }
        }
        for (int x = 0; x < MapSize; x++)
        {
            for (int z = 0; z < MapSize; z++)
            {
                //The rooms get linked here
                RoomBase currentRoom = _map[x, z];
                RoomBase north = null, south = null, east = null, west = null;
                if (x > 0) east = _map[x - 1, z];       //Checks if there can be a north room
                if (x < MapSize - 1) west = _map[x + 1, z];   //Checks if there can be a south room 
                if (z > 0) north = _map[x, z - 1];       //Checks if there can be a west room
                if (z < MapSize - 1) south = _map[x, z + 1];   //Checks if there can be an east room
                currentRoom.SetRooms(north, south, east, west);
            }
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
