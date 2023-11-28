using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerWithTransform : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _myColor;
    [SerializeField] private Color _targetCol;
    public void Cange()
    {
        _myColor.color = _targetCol;
    }

}
