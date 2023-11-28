using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeWayChecer : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidbody2D;
    [SerializeField] float _speed;
    [SerializeField] ContactFilter2D _filter;

    private readonly RaycastHit2D[] _result = new RaycastHit2D[1];

    private void FixedUpdate()
    {
        var contactResult = _rigidbody2D.Cast(transform.right, _filter, _result, 10);
        if (contactResult == 0)
        {
            _rigidbody2D.velocity = transform.right * _speed;
        }
        else
        {
            _rigidbody2D.velocity = Vector3.zero;
        }
    }
}
