using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSpell : Spell
{
    protected GameObject target;
    protected Vector2 directionToTarget;

    protected override void OnStart()
    {
        base.OnStart();

        this.transform.position = new Vector2(Config.Performer.transform.position.x,
                                              Config.Performer.transform.position.y);

        target = PlayerManager.Instance.Player.GetClosestEnemy()?.gameObject;
        directionToTarget = (target.transform.position - this.transform.position).normalized;
        this.transform.up = -directionToTarget;
    }

    protected override void LogicalUpdate()
    {
        base.LogicalUpdate();
    }

    protected override void PhysicalUpdate()
    {
        base.PhysicalUpdate();
        this.transform.position += (Vector3)directionToTarget * Config.MovementSpeed * Time.deltaTime;
    }

    protected override void AnimationUpdate()
    {
        base.AnimationUpdate();
    }

    public override void Perform()
    {
        base.Perform();
        
        Instantiate(this);
    }
}
