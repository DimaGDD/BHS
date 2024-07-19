using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility : MonoBehaviour
{
    [SerializeField] private string _defaultLayerMask;

    public void SetLeyrMask()
    {
        gameObject.layer = LayerMask.NameToLayer("Invisibility");
    }

    public void SetLeyrMaskDefault()
    {
        gameObject.layer = LayerMask.NameToLayer(_defaultLayerMask);
    }
}
