using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Manager : MonoBehaviour
{
    public virtual void Enable() { }
    public virtual void Disable() { }
    public virtual void OnAwake() { }
    public virtual void OnStart() { }
    public virtual void OnLogicalUpdate() { }
    public virtual void OnPhysicalUpdate() { }
    public virtual void OnAnimationUpdate() { }
    public virtual void OnEnterGame() { }
    public virtual void OnExitGame() { }
}
