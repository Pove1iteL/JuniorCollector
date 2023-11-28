using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoitMovment : MonoBehaviour
{
    [SerializeField] private Transform _point;
    [SerializeField] private int _speed;

    private Transform[] _points;
    private int _currentPoint;

    private void Start()
    {
        _points = new Transform[_point.childCount];

        for (int i = 0; i < _point.childCount; i++)
        {
            _points[i] = _point.GetChild(i);
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
        }
    
    }



}
