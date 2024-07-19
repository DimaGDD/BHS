using UnityEngine;
using BHSCamp;

public class JumpPowerup : TemporaryPowerup
{
    [SerializeField] private float _jumpMultiplier;
    private Jump _jump;

    public override void Apply(GameObject target)
    {
        _jump = target.GetComponent<Jump>();
        _jump.SetPowerupJump(_jumpMultiplier);
        base.Apply(target);
    }

    protected override void OnExpire()
    {
        _jump.SetPowerupJump(1f);
    }
}