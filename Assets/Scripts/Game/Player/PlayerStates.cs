using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates
{
    public PlayerIdleState IdleState { get; private set; }
    public PlayerMovingState MovingState { get; private set; }

    public PlayerStates(CharacterController characterController, CharacterStateController stateController)
    {
        IdleState = new PlayerIdleState(characterController, stateController, CharacterState.State.Idle);
        MovingState = new PlayerMovingState(characterController, stateController, CharacterState.State.Moving);
    }
}
