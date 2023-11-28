using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPointTrig : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderC;
    [SerializeField] private Color _finalCol;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<FreeWayChecer>(out FreeWayChecer player))
        {
            _renderC.color = _finalCol;
        }
    }
}
