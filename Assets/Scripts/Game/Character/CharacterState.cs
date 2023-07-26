using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState
{
    protected CharacterController thisCharacter;
    protected CharacterStateController StateController;

    protected float startTime;

    public enum State
    {
        Idle,
        Moving,
    }
    public State _state { get; private set; }

    public CharacterState(CharacterController characterController, CharacterStateController stateController, State state)
    {
        this.thisCharacter = characterController;
        this.StateController = stateController;
        this._state = state;
    }

    public virtual void Enter()
    {
        // Debug.Log(UnitController.gameObject + " Enters " + _state);

        thisCharacter.CurrentState = _state;

        startTime = Time.time;
    }

    public virtual void LogicalUpdates()
    {
        // Debug.Log(UnitController.gameObject + " is " + _state);
    }

    public virtual void PhysicalUpdates()
    {
    }

    public virtual void AnimationUpdates()
    {
    }

    public virtual void Exit()
    {
        // Debug.Log(UnitController.gameObject + " Exits " + _state);
    }
}
