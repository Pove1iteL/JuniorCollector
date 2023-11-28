using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFindTrigger : MonoBehaviour
{
    private EndPointEvTrig[] _points;

    private void OnEnable()
    {
       _points = gameObject.GetComponentsInChildren<EndPointEvTrig>();

        foreach (var point in _points)
            point.Reached += OnEndPointReached;

    }
    private void OnDisable()
    {
        foreach (var point in _points)
            point.Reached -= OnEndPointReached;
    }
    private void OnEndPointReached()
    {
        foreach (var point in _points)
             if (point.IsReached == false)
                     return;

        Debug.Log("Fine!");
        
    }
}
