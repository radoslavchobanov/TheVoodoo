using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class EnemyController : CharacterController
{
    public EnemyStates EnemyStates { get; private set; }

    protected override void InitializeCharacterController()
    {
        base.InitializeCharacterController();

        EnemyStates = new EnemyStates(this, StateController);
    }

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();

        StateController.Start(EnemyStates.IdleState);
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    protected override void LateUpdate()
    {
        base.LateUpdate();
    }
}
