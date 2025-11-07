using UnityEngine;

public class GameManagerUltra : MonoBehaviour
{
    [SerializeField] private MapManager GameMapPrefab;

    private MapManager _gameMap;

    public void Start()
    {
        Debug.Log("GameManager Start");

        transform.position = Vector3.zero;

        _gameMap = Instantiate(GameMapPrefab, transform);
        _gameMap.transform.position = Vector3.zero;

        _gameMap.CreateMap();

        Debug.Log("GameManager Map Created");


    }
    private void StartGame()
    {
        Debug.Log("Hello, World!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
