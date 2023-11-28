using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndPointEvTrig : MonoBehaviour
{
    [SerializeField] private UnityEvent _evenChakc = new UnityEvent();

    public event UnityAction Reached
    {
        add => _evenChakc.AddListener(value);
        remove => _evenChakc.RemoveListener(value);
    }
    public bool IsReached { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsReached)
            return;

        if (collision.TryGetComponent<FreeWayChecer>(out FreeWayChecer freeWayChecer))
        {
            IsReached = true;
            //Debug.Log("Work");
            _evenChakc.Invoke();
        }
    }
}
