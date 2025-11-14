using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Vector2 Move;
    private Dictionary<Direction, int> _rotationByDirection = new()
    {
        {Direction.North, 0 },
        {Direction.East, 90 },
        {Direction.South, 180 },
        {Direction.West, 270 }
    };
    private Direction _facingDirection;
    private bool _isRotating = false;
    private bool _isWalking = false;

    [SerializeField] private float RotationTime = 0.5f;
    [SerializeField] private float WalkingTime = 1.0f;
    private float _rotationTimer = 0.0f;
    private Quaternion _previousRotation;

    private RoomBase _currentRoom = null;
    public void Setup()
    {
        Direction[] directions = new Direction[] { Direction.North, Direction.East, Direction.South, Direction.West };

        _facingDirection = directions[UnityEngine.Random.Range(0, directions.Length)];

        SetFacingDirection();
    }
    private void StartRotating()
    {
        _previousRotation = transform.rotation;
        _isRotating = true;
    }
    private void SetFacingDirection()
    {
        Vector3 facing = transform.rotation.eulerAngles;
        facing.y = _rotationByDirection[_facingDirection];
        transform.rotation = Quaternion.Euler(facing);
    }
    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }
    public void OnSearch()
    {
        if (_currentRoom != null)
        {
            _currentRoom.OnRoomSearched();
        }
    }
    private void MoveInput(Vector2 newMoveDirection)
    {
        Move = newMoveDirection;
        Debug.Log($"Move input: {Move.x} {Move.y}");
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
    private void MoveFoward()
    {
        //switch (_facingDirection)
        //{
        //    case Direction.South:
        //        _facingDirection = Direction.West;
        //        break;
        //    case Direction.North:
        //        _facingDirection = Direction.East;
        //        break;
        //    case Direction.East:
        //        _facingDirection = Direction.South;
        //        break;
        //    case Direction.West:
        //        _facingDirection = Direction.North;
        //        break;
        //}
        Debug.Log("You try to move foward");
    }
    private void OnTriggerEnter(Collider otherObject)
    {
        _currentRoom = otherObject.GetComponent<RoomBase>();
        _currentRoom.OnRoomEntered();
    }
    private void OnTriggerExit(Collider otherObject)
    {
        RoomBase exitingRoom = otherObject.GetComponent<RoomBase>();
        exitingRoom.OnRoomExited();
    }
    private void Update()
    {
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
        
        //if (_isWalking)
        //    {

        //    }
    }
}