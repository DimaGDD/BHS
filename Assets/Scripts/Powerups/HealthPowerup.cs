using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BHSCamp;

public class HealthPowerup : MonoBehaviour, IPowerup
{
    [SerializeField] private int _healAmout;

    public void Apply(GameObject target)
    {
        IHealable healable = target.GetComponent<IHealable>();
        healable.Heal(_healAmout);
    }
}
