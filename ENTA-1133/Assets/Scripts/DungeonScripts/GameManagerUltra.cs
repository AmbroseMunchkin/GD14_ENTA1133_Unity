using UnityEngine;

public class GameManagerUltra : MonoBehaviour
{
    [SerializeField] private MapManager GameMapPrefab;
    [SerializeField] private PlayerController PlayerPrefab;

    private MapManager _gameMap;
    private PlayerController _playerController;

    public void StartTheGame()
    {
        Debug.Log("GameManager Start Begins");

        transform.position = Vector3.zero;

        SetupMap();
        SpawnPlayer();
        StartGame();

        Debug.Log("GameManager Start Complete");
    }

    //Generates the map
    private void SetupMap()
    {
        Debug.Log("GameManager SetupMap Begins");
        _gameMap = Instantiate(GameMapPrefab, transform);
        _gameMap.transform.position = Vector3.zero;

        _gameMap.CreateMap();
        Debug.Log("GameManager Map Created");
    }

    //Player spawns at a random location between the rooms generated once the map is fully generated
    private void SpawnPlayer()
    {
        Debug.Log("GameManager SpawnPlayer Begins");
        var randomStartingRoom = _gameMap.Rooms[Random.Range(0, _gameMap.MapSizeR), Random.Range(0, _gameMap.MapSizeR)]; 
        _playerController = Instantiate(PlayerPrefab, transform);
        _playerController.transform.position = new Vector3(randomStartingRoom.transform.position.x, 0, randomStartingRoom.transform.position.z);
        _playerController.Setup();
        Debug.Log("GameManager SpawnPlayer Complete");
    }

    private void StartGame()
    {
        Debug.Log("GameManager StartGame Begins");
        Debug.Log("GameManager Start Game Complete");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
