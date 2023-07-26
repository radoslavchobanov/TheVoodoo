using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : CharacterState
{
    protected new EnemyController thisCharacter;
    
    public EnemyState(CharacterController characterController, CharacterStateController stateController, State state) : base(characterController, stateController, state)
    {
    }

    public override void Enter()
    {
        base.Enter();
        this.thisCharacter = base.thisCharacter as EnemyController;
    }
}
