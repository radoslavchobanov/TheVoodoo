using System;

public class CharacterStateController
{
    public CharacterState CurrentState { get; private set; }

    public void Start(CharacterState startingState)
    {
        CurrentState = startingState;
        CurrentState.Enter();
    }

    public void ChangeState(CharacterState newState)
    {
        if (CurrentState == newState)
            return;

        CurrentState?.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }
}
