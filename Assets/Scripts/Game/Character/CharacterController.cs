using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract partial class CharacterController : MonoBehaviour
{
    protected Animator _animator;
    protected CharacterSO _character;

    #region State Machine
    [SerializeField] protected CharacterState.State _currentState;
    protected CharacterStateController _stateController;
    #endregion

    public CharacterSO Character { get => _character; private set => _character = value; }
    public CharacterState.State CurrentState { get => _currentState; set => _currentState = value; }
    public CharacterStateController StateController { get => _stateController; private set => _stateController = value; }
    public Animator Animator { get => _animator; private set => _animator = value; }

    public void Init(CharacterSO character)
    {
        _character = character;
        var characterObj = Instantiate(_character.Prefab, this.transform);
        Animator = characterObj.GetComponent<Animator>();
    }

    protected virtual void InitializeCharacterController()
    {
        StateController = new CharacterStateController();
    }

    protected virtual void Awake()
    {
        InitializeCharacterController();
    }

    protected virtual void Start()
    {
        RegisterEvents();
    }

    protected virtual void Update()
    {
        StateController.CurrentState.LogicalUpdates();
    }

    protected virtual void FixedUpdate()
    {
        StateController.CurrentState.PhysicalUpdates();
    }

    protected virtual void LateUpdate()
    {
        StateController.CurrentState.AnimationUpdates();
    }

    public void MoveInDirection(Vector3 direction)
    {
        FaceAt(direction);
        this.transform.position += direction * _character.BasicStats.MovementSpeed * Time.deltaTime;
    }

    public void MoveTowardsPoint(Vector3 point)
    {
        if (this.transform.position.x < point.x)
        {
            FaceAt(Vector3.left);
        }
        else if (this.transform.position.x > point.x)
        {
            FaceAt(Vector3.right);
        }

        var directionToTarget = (point - this.transform.position).normalized;
        this.transform.position += directionToTarget * _character.BasicStats.MovementSpeed * Time.deltaTime;
    }

    public void FaceAt(Vector3 direction)
    {
        var characterObj = this.transform.GetChild(0);
        if (direction == Vector3.left)
        {
            characterObj.transform.rotation = new Quaternion(0, 180, 0, 0);
        }
        else if (direction == Vector3.right)
        {
            characterObj.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
