using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleState : EnemyState
{
    public EnemyIdleState(CharacterController characterController, CharacterStateController stateController, State state) : base(characterController, stateController, state)
    {
    }

    public override void Enter()
    {
        base.Enter();

        StateController.ChangeState(thisCharacter.EnemyStates.MovingState);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicalUpdates()
    {
        base.LogicalUpdates();
    }

    public override void PhysicalUpdates()
    {
        base.PhysicalUpdates();
    }

    public override void AnimationUpdates()
    {
        base.AnimationUpdates();
    }
}
