using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBTN2 : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public void OnButtnClic()
    {
        _animator.Play("Buttonanim");
        
    }
}
