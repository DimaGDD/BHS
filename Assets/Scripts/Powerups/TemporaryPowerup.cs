using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TemporaryPowerup : MonoBehaviour, IPowerup
{
    [SerializeField] protected float _duration;

    public virtual void Apply(GameObject target)
    {
        ActionOnTimer executer = target.GetComponent<ActionOnTimer>();
        if (null != executer)
            executer.ExecuteAfterTime(OnExpire, _duration);
    }

    protected abstract void OnExpire();
}
