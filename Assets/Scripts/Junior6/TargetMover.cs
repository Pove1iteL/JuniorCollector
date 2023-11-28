using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    private float _speed = 2;
    private Vector3 _startPosition;
    private Vector3 _target;
    private bool isTarget = false;

    private void Awake()
    {
        _target = new Vector3(transform.position.x + 2, transform.position.y, 0);
        _startPosition = new Vector3(transform.position.x, transform.position.y, 0);
    }

    private void Update()
    {
        if (isTarget)
        {
            Move(_startPosition);
            isTarget = transform.position.x != _startPosition.x;
        }
        else
        {
            Move(_target);
            isTarget = transform.position.x == _target.x;
        }
    }

    private void Move(Vector3 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);
    }
}
