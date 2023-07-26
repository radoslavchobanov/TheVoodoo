using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Spell : MonoBehaviour
{
    [SerializeField] protected SpellSO Config;

    private void Start() => OnStart();
    private void Update() => LogicalUpdate();
    private void FixedUpdate() => PhysicalUpdate();
    private void LateUpdate() => AnimationUpdate();

    protected virtual void OnStart()
    {
    }

    protected virtual void LogicalUpdate()
    {
    }

    protected virtual void PhysicalUpdate()
    {
    }

    protected virtual void AnimationUpdate()
    {
    }

    public virtual void Perform()
    {
    }
}
