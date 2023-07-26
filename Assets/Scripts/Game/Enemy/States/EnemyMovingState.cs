using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovingState : EnemyState
{
    public EnemyMovingState(CharacterController characterController, CharacterStateController stateController, State state) : base(characterController, stateController, state)
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

        thisCharacter.MoveTowardsPoint(PlayerManager.Instance.Player.transform.position);
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
