using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpExemple : MonoBehaviour
{
    [SerializeField] private Transform _a;
    [SerializeField] private Transform _b;
    [SerializeField] private Transform _target;

    [SerializeField] private float _path;
    [SerializeField] private float runingTimePerSec;

    private void Update()
    {
        /*
         if (runingTimePerSec <= _path)
         {
             runingTimePerSec += Time.deltaTime;
         }
         else
         {
             return;
         }
         _target.position = Vector3.Lerp(_a.position, _b.position, runingTimePerSec / _path);
        */

        _target.position = Vector3.Lerp(_target.position, _b.position, 0.01f);

    }

    public void LerpStartPos(float position)
    {
        _target.position = Vector3.Lerp(_a.position, _b.position, position);
    }

}
