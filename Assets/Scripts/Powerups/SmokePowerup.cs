using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokePowerup : TemporaryPowerup
{
    private Invisibility _invisibility;

    public override void Apply(GameObject target)
    {
        _invisibility = target.GetComponent<Invisibility>();
        _invisibility.SetLeyrMask();
        base.Apply(target);
    }

    protected override void OnExpire()
    {
        _invisibility.SetLeyrMaskDefault();
    }
}
