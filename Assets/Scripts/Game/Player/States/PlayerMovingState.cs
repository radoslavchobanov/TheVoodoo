using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingState : PlayerState
{
    public PlayerMovingState(CharacterController characterController, CharacterStateController stateController, State state) : base(characterController, stateController, state)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicalUpdates()
    {
        base.LogicalUpdates();

        // temporary input
        if (!Input.GetKey(KeyCode.W) &&
            !Input.GetKey(KeyCode.A) &&
            !Input.GetKey(KeyCode.S) &&
            !Input.GetKey(KeyCode.D))
        {
            StateController.ChangeState(thisCharacter.PlayerStates.IdleState);
        }
    }

    public override void PhysicalUpdates()
    {
        base.PhysicalUpdates();

        // temporary input
        if (Input.GetKey(KeyCode.W))
        {
            thisCharacter.MoveInDirection(Vector2.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            thisCharacter.MoveInDirection(Vector2.left);
        }
        if (Input.GetKey(KeyCode.S))
        {
            thisCharacter.MoveInDirection(Vector2.down);
        }
        if (Input.GetKey(KeyCode.D))
        {
            thisCharacter.MoveInDirection(Vector2.right);
        }
    }

    public override void AnimationUpdates()
    {
        base.AnimationUpdates();

        thisCharacter.Animator.Play("Moving");
    }
}
