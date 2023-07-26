using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(CharacterController characterController, CharacterStateController stateController, State state) : base(characterController, stateController, state)
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
        if (Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.D))
        {
            StateController.ChangeState(thisCharacter.PlayerStates.MovingState);
        }
    }

    public override void PhysicalUpdates()
    {
        base.PhysicalUpdates();
    }

    public override void AnimationUpdates()
    {
        base.AnimationUpdates();

        thisCharacter.Animator.Play("Idle");
    }
}
