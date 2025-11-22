using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InGameHud _inGameHud;

    public Vector2 Move;
    //Directions N,E,S and W gets set for rotation and walking movement
    private Dictionary<Direction, int> _rotationByDirection = new()
    {
        {Direction.North, 0 },
        {Direction.East, 90 },
        {Direction.South, 180 },
        {Direction.West, 270 }
    };
    //Smooth rotation
    private Direction _facingDirection;
    private bool _isRotating = false;

    [SerializeField] private float RotationTime = 0.5f;
    private float _rotationTimer = 0.0f;
    private Quaternion _previousRotation;

    private RoomBase _currentRoom = null;

    //Smooth movement
    [SerializeField] private float MovementTime = 2.0f;
    private bool _isMoving = false;
    private float _movementTimer = 0.0f;
    private Vector3 _previousPosition;
    private Vector3 _moveToPosition;

    //The direction is being set up here
    public void Setup()
    {
        Direction[] directions = new Direction[] { Direction.North, Direction.East, Direction.South, Direction.West };

        _facingDirection = directions[UnityEngine.Random.Range(0, directions.Length)];

        SetFacingDirection();
    }

    //Rotation starts
    private void StartRotating()
    {
        _previousRotation = transform.rotation;
        _isRotating = true;
    }

    //Facing direction gets set here
    private void SetFacingDirection()
    {
        Vector3 facing = transform.rotation.eulerAngles;
        facing.y = _rotationByDirection[_facingDirection];
        transform.rotation = Quaternion.Euler(facing);
    }

    //Movement starts
    private void StartMovement(RoomBase targetRoom)
    {
        _previousPosition = transform.position;
        _moveToPosition = targetRoom.transform.position;
        _isMoving = true;
    }

    //Gets the WASD input for movement
    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

    //Gets the space bar input for searching the rooms
    public void OnSearch()
    {
        if (_currentRoom != null)
        {
            _currentRoom.OnRoomSearched();
        }
    }

    //public void OnPause()
    //{
    //    _inGameHud.OnPauseGame();
    //}

    //WASD and SPACE BAR inputs get called here with their respective actions
    private void MoveInput(Vector2 newMoveDirection)
    {
        Move = newMoveDirection;
        //Debug.Log($"Move input: {Move.x} {Move.y}");   //To get visual values on what using WASD do
        if (Move.x < 0)
        {
            TurnLeft();
        }
        else if (Move.x > 0)
        {
            TurnRight();
        }
        else if (Move.y > 0)
        {
            MoveFoward();
        }
    }

    //Sets the new facing direction when player inputs D key
    private void TurnLeft()
    {
        switch (_facingDirection)
        {
            case Direction.South:
                _facingDirection = Direction.East;
                break;
            case Direction.North:
                _facingDirection = Direction.West;
                break;
            case Direction.East:
                _facingDirection = Direction.North;
                break;
            case Direction.West:
                _facingDirection = Direction.South;
                break;
        }
        StartRotating();
    }

    //Sets the new facing direction when player inputs A key
    private void TurnRight()
    {
        switch (_facingDirection)
        {
            case Direction.South:
                _facingDirection = Direction.West;
                break;
            case Direction.North:
                _facingDirection = Direction.East;
                break;
            case Direction.East:
                _facingDirection = Direction.South;
                break;
            case Direction.West:
                _facingDirection = Direction.North;
                break;
        }
        StartRotating();
    }

    //The player moves foward if there is a room in the facing direction, if not it wont go foward
    private void MoveFoward()
    {
        RoomBase roomInFacingDirection = NextRoomInDirection();
        if (roomInFacingDirection != null)
        {
            StartMovement(roomInFacingDirection);
        }
        Debug.Log("You move foward");
    }

    //Sets the next room the player will move to
    private RoomBase NextRoomInDirection()
    {
        if (_currentRoom == null)
        {
            return null;
        }
        switch (_facingDirection)
        {
            case Direction.North:
                return _currentRoom.South;
            case Direction.East:
                return _currentRoom.West;
            case Direction.South:
                return _currentRoom.North;
            case Direction.West:
                return _currentRoom.East;
            default:
                Debug.LogError("Error: Unknown Direction!");
                return null;
        }
    }

    //When player enters the room it triggers the collider of set room
    private void OnTriggerEnter(Collider otherObject)
    {
        _currentRoom = otherObject.GetComponent<RoomBase>();
        _currentRoom.OnRoomEntered();
    }
    //When player exits the room it triggers the collider of set room
    private void OnTriggerExit(Collider otherObject)
    {
        RoomBase exitingRoom = otherObject.GetComponent<RoomBase>();
        exitingRoom.OnRoomExited();
    }
    private void Update()
    {
        //Does the actual rotation once _isRotating is set to true
        if (_isRotating)
        {
            Quaternion currentRotation = Quaternion.Lerp(_previousRotation, Quaternion.Euler(new Vector3(0, _rotationByDirection[_facingDirection])), _rotationTimer / RotationTime);
            transform.rotation = currentRotation;

            _rotationTimer += Time.deltaTime;
            if (_rotationTimer > RotationTime)
            {
                _isRotating = false;
                _rotationTimer = 0.0f;
                SetFacingDirection();
            }
        }
        //Does the actual movement once _isMoving is set to true
        if (_isMoving)
        {
            Vector3 currentPositon = Vector3.Lerp(_previousPosition, _moveToPosition, _movementTimer / MovementTime);

            transform.position = currentPositon;

            _movementTimer += Time.deltaTime;

            if (_movementTimer > MovementTime)
            {
                _isMoving = false;
                _movementTimer = 0.0f;
                transform.position = _moveToPosition;
            }
        }
    }
}