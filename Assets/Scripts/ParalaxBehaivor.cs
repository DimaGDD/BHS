using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBehaivor : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField, Range(0f, 1)] private float _horizontalMovementMultiplier;

    [SerializeField, Range(0f, 1)] float _verticalMovementMultiplier;

    private Vector3 _targetPosition => _target.position;

    private Vector3 _lastTargetPosition;

    private void Start()
    {
        _lastTargetPosition = _targetPosition;
    }

    private void Update()
    {
        Vector3 delta = _targetPosition - _lastTargetPosition;
        delta *= new Vector2(_horizontalMovementMultiplier, _verticalMovementMultiplier);
        transform.position += delta;
        _lastTargetPosition = _targetPosition;
    }
}
