using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonCircle : Spell
{
    public float CircleRadius = 3;

    protected override void OnStart()
    {
        base.OnStart();

        this.transform.position = new Vector3(Config.Performer.transform.position.x,
                                              Config.Performer.transform.position.y,
                                              Config.Spell.transform.position.z) + new Vector3(CircleRadius, 0, 0);
    }

    protected override void LogicalUpdate()
    {
        base.LogicalUpdate();
    }

    protected override void PhysicalUpdate()
    {
        base.PhysicalUpdate();

        transform.RotateAround(Config.Performer.transform.position, Vector3.forward, Config.MovementSpeed);
    }

    protected override void AnimationUpdate()
    {
        base.AnimationUpdate();
    }

    public override void Perform()
    {
        base.Perform();

        Instantiate(this, Config.Performer.transform);
    }
}
