using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PlayerController : CharacterController
{
    public PlayerStates PlayerStates { get; private set; }

    protected override void InitializeCharacterController()
    {
        base.InitializeCharacterController();

        PlayerStates = new PlayerStates(this, StateController);
    }

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();

        StateController.Start(PlayerStates.IdleState);
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

    public EnemyController GetClosestEnemy()
    {
        float closestDistance = Mathf.Infinity;
        EnemyController closestEnemy = null;

        foreach (var enemy in EnemyManager.Instance.Enemies)
        {
            var currentDistance = Vector3.Distance(this.transform.position, enemy.transform.position);
            if (currentDistance < closestDistance)
            {
                closestDistance = currentDistance;
                closestEnemy = enemy;
            }
        }

        return closestEnemy;
    }
}
