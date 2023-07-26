using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStates
{
    public EnemyIdleState IdleState { get; private set; }
    public EnemyMovingState MovingState { get; private set; }

    public EnemyStates(CharacterController characterController, CharacterStateController stateController)
    {
        IdleState = new EnemyIdleState(characterController, stateController, CharacterState.State.Idle);
        MovingState = new EnemyMovingState(characterController, stateController, CharacterState.State.Moving);
    }
}
