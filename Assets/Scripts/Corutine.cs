using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutine : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _color;
    void Start()
    {
        _color = GetComponent<SpriteRenderer>();

        StartCoroutine(ChengerAlpha());
    }
    private IEnumerator ChengerAlpha()
    {
        var color = _color.color;

        for (int i = 0; i < 255; i++)
        {
            color.a = 1 - (1f/255f * i);
            _color.color = color;

             yield return null;
        }
    }
 
}
