using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;

    private void Update()
    {
        Move();
    }

    public void Init(Vector3 direction)
    {
        _direction = direction;
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position,_direction,_speed * Time.deltaTime);
    }
}
