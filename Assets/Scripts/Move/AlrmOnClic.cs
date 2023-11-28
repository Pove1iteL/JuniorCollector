using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlrmOnClic : MonoBehaviour
{
    private Animator _animation;

    private void Start()
    {
        _animation = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        _animation.SetTrigger("Alarm");
    }
}
