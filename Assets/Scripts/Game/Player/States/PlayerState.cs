using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : CharacterState
{
    protected new PlayerController thisCharacter;
    
    public PlayerState(CharacterController characterController, CharacterStateController stateController, State state) : base(characterController, stateController, state)
    {
    }

    public override void Enter()
    {
        base.Enter();
        this.thisCharacter = base.thisCharacter as PlayerController;
    }
}
